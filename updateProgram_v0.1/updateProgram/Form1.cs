using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace updateProgram
{
    public partial class Form1 : Form
    {
        private string[] _skipFiles;
        private string[] _deleteFiles;

        private int _fileCopyCount, _folderCopyCount;
        private int _fileDelCount, _folderDelCount;

        public Form1()
        {
            InitializeComponent();
        }

        #region 폴더 선택 버튼 이벤트

        // 원본 폴더 선택 버튼 클릭 이벤트
        private void bt_SrcFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog srcFolderBrowse = new FolderBrowserDialog();
            
            if(srcFolderBrowse.ShowDialog() == DialogResult.OK)
            {
                txt_SrcFolderLocation.Text = srcFolderBrowse.SelectedPath;
            }

        }

        // 대상 폴더 선택 버튼 클릭 이벤트
        private void bt_DstFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dstFolderBrowse = new FolderBrowserDialog();

            if (dstFolderBrowse.ShowDialog() == DialogResult.OK)
            {
                txt_DstFolderLocation.Text = dstFolderBrowse.SelectedPath;
            }
        }

        #endregion

        //private void 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region 폴더 동기화 (Update) 이벤트

        // 동기화 실행 버튼 클릭 이벤트
        private void bt_SyncFolder_Click(object sender, EventArgs e)
        {
            if(txt_SrcFolderLocation.Text.Length <= 3 && txt_DstFolderLocation.Text.Length <= 3)
            {
                MessageBox.Show("대상 폴더에 값을 입력하지 않았습니다.", "폴더 선택");
                return;
            }

            string SrcFolder = txt_SrcFolderLocation.Text.Substring(3);
            string DstFolder = txt_DstFolderLocation.Text.Substring(3);

            string SrcIP = cb_SrcIPList.SelectedItem.ToString();
            string DstIP = cb_DstIPList.SelectedItem.ToString();

            string SrcLocation = "\\\\" + SrcIP + "\\" + SrcFolder;
            string DstLocation = "\\\\" + DstIP + "\\" + DstFolder;

            if(Directory.Exists(SrcLocation) == false)
            {
                MessageBox.Show("동기화할 대상 폴더가 존재하지 않습니다.", "파일 동기화");
                return;
            }

            if(Directory.Exists(DstLocation) == false)
            {
                MessageBox.Show("동기화될 대상 폴더가 존재하지 않습니다.", "파일 동기화");
                return;
            }

            DirectoryInfo SrcInfo = new DirectoryInfo(SrcLocation);
            DirectoryInfo DstInfo = new DirectoryInfo(DstLocation);

            FileInfo[] SrcFiles = SrcInfo.GetFiles();
            FileInfo[] DstFiles = DstInfo.GetFiles();

            bool bFind = false;
            int index = 0;

            // 파일 비교
            foreach(FileInfo SrcFile in SrcFiles)
            {
                string failedFile = "";
                bFind = false;
                index = -1;

                if(isSkippedFile(SrcFile) == true)
                {
                    continue;
                }

                foreach(FileInfo DstFile in DstFiles)
                {
                    index++;

                    if(DstFile == null)
                    {
                        continue;
                    }

                    if(SrcFile.Name.ToLower() == DstFile.Name.ToLower())
                    {
                        bFind = true;

                        if(SrcFile.LastWriteTime != DstFile.LastWriteTime)
                        {
                            FileAttributes SrcAttr = SrcFile.Attributes;
                            FileAttributes DstAttr = DstFile.Attributes;

                            SrcFile.Attributes = FileAttributes.Normal;
                            DstFile.Attributes = FileAttributes.Normal;

                            SrcFile.Refresh();
                            DstFile.Refresh();

                            try
                            {
                                if(SrcFile.LastWriteTime > DstFile.LastWriteTime)
                                {
                                    failedFile = SrcFile.FullName;
                                    File.Copy(SrcFile.FullName, DstFile.FullName, true);
                                    _fileCopyCount++;
                                }
                                else
                                {
                                    failedFile = DstFile.FullName;
                                    File.Copy(DstFile.FullName, SrcFile.FullName, true);
                                    _fileCopyCount++;
                                }
                            }
                            catch
                            {
                                lst_FileName.Items.Add("파일 복사: " + failedFile);
                            }
                            finally
                            {
                                SrcFile.Attributes = SrcAttr;
                                SrcFile.Refresh();
                                DstFile.Attributes = DstAttr;
                                DstFile.Refresh();
                            }
                        }

                        DstFiles[index] = null;

                        break;
                    }
                }


            }
            
        }

        #endregion

        #region 파일 스킵 함수
        private bool isSkippedFile(FileInfo aFile)
        {
            string filepath = aFile.Name.ToLower();

            foreach (string lastWord in _skipFiles)
            {
                if (filepath.EndsWith(lastWord) == true)
                {
                    return true;
                }
            }

            foreach (string lastWord in _deleteFiles)
            {
                if (filepath.EndsWith(lastWord) == true)
                {
                    try
                    {
                        aFile.Attributes = FileAttributes.Normal;
                        aFile.Refresh();
                        aFile.Delete();
                    }
                    catch
                    {
                        lst_FileName.Items.Add("파일 삭제: " + aFile.FullName);
                    }
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
