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


        }

        #endregion
    }
}
