using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
