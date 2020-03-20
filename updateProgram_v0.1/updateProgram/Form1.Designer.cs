namespace updateProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_SrcFolder = new System.Windows.Forms.Button();
            this.bt_DstFolder = new System.Windows.Forms.Button();
            this.txt_SrcFolderLocation = new System.Windows.Forms.TextBox();
            this.txt_DstFolderLocation = new System.Windows.Forms.TextBox();
            this.lb_SrcDescription = new System.Windows.Forms.Label();
            this.lb_DstDescription = new System.Windows.Forms.Label();
            this.cb_SrcIPList = new System.Windows.Forms.ComboBox();
            this.cb_DstIPList = new System.Windows.Forms.ComboBox();
            this.lst_FileName = new System.Windows.Forms.ListView();
            this.bt_SyncFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_SrcFolder
            // 
            this.bt_SrcFolder.Location = new System.Drawing.Point(510, 12);
            this.bt_SrcFolder.Name = "bt_SrcFolder";
            this.bt_SrcFolder.Size = new System.Drawing.Size(97, 23);
            this.bt_SrcFolder.TabIndex = 0;
            this.bt_SrcFolder.Text = "원본 폴더 선택";
            this.bt_SrcFolder.UseVisualStyleBackColor = true;
            this.bt_SrcFolder.Click += new System.EventHandler(this.bt_SrcFolder_Click);
            // 
            // bt_DstFolder
            // 
            this.bt_DstFolder.Location = new System.Drawing.Point(510, 42);
            this.bt_DstFolder.Name = "bt_DstFolder";
            this.bt_DstFolder.Size = new System.Drawing.Size(97, 23);
            this.bt_DstFolder.TabIndex = 1;
            this.bt_DstFolder.Text = "대상 폴더 선택";
            this.bt_DstFolder.UseVisualStyleBackColor = true;
            this.bt_DstFolder.Click += new System.EventHandler(this.bt_DstFolder_Click);
            // 
            // txt_SrcFolderLocation
            // 
            this.txt_SrcFolderLocation.Location = new System.Drawing.Point(279, 12);
            this.txt_SrcFolderLocation.Name = "txt_SrcFolderLocation";
            this.txt_SrcFolderLocation.Size = new System.Drawing.Size(225, 23);
            this.txt_SrcFolderLocation.TabIndex = 2;
            // 
            // txt_DstFolderLocation
            // 
            this.txt_DstFolderLocation.Location = new System.Drawing.Point(279, 42);
            this.txt_DstFolderLocation.Name = "txt_DstFolderLocation";
            this.txt_DstFolderLocation.Size = new System.Drawing.Size(225, 23);
            this.txt_DstFolderLocation.TabIndex = 2;
            // 
            // lb_SrcDescription
            // 
            this.lb_SrcDescription.AutoSize = true;
            this.lb_SrcDescription.Location = new System.Drawing.Point(12, 16);
            this.lb_SrcDescription.Name = "lb_SrcDescription";
            this.lb_SrcDescription.Size = new System.Drawing.Size(133, 15);
            this.lb_SrcDescription.TabIndex = 3;
            this.lb_SrcDescription.Text = "원본 폴더 IP & 폴더 위치";
            // 
            // lb_DstDescription
            // 
            this.lb_DstDescription.AutoSize = true;
            this.lb_DstDescription.Location = new System.Drawing.Point(12, 46);
            this.lb_DstDescription.Name = "lb_DstDescription";
            this.lb_DstDescription.Size = new System.Drawing.Size(133, 15);
            this.lb_DstDescription.TabIndex = 3;
            this.lb_DstDescription.Text = "대상 폴더 IP & 폴더 위치";
            // 
            // cb_SrcIPList
            // 
            this.cb_SrcIPList.FormattingEnabled = true;
            this.cb_SrcIPList.Items.AddRange(new object[] {
            "172.16.14.10",
            "172.16.14.24",
            "172.16.14.18"});
            this.cb_SrcIPList.Location = new System.Drawing.Point(152, 12);
            this.cb_SrcIPList.Name = "cb_SrcIPList";
            this.cb_SrcIPList.Size = new System.Drawing.Size(121, 23);
            this.cb_SrcIPList.TabIndex = 4;
            this.cb_SrcIPList.Text = "172.16.14.10";
            // 
            // cb_DstIPList
            // 
            this.cb_DstIPList.FormattingEnabled = true;
            this.cb_DstIPList.Items.AddRange(new object[] {
            "172.16.14.10",
            "172.16.14.24",
            "172.16.14.18"});
            this.cb_DstIPList.Location = new System.Drawing.Point(152, 42);
            this.cb_DstIPList.Name = "cb_DstIPList";
            this.cb_DstIPList.Size = new System.Drawing.Size(121, 23);
            this.cb_DstIPList.TabIndex = 4;
            this.cb_DstIPList.Text = "172.16.14.24";
            // 
            // lst_FileName
            // 
            this.lst_FileName.HideSelection = false;
            this.lst_FileName.Location = new System.Drawing.Point(12, 116);
            this.lst_FileName.Name = "lst_FileName";
            this.lst_FileName.Size = new System.Drawing.Size(195, 231);
            this.lst_FileName.TabIndex = 5;
            this.lst_FileName.UseCompatibleStateImageBehavior = false;
            // 
            // bt_SyncFolder
            // 
            this.bt_SyncFolder.Location = new System.Drawing.Point(470, 72);
            this.bt_SyncFolder.Name = "bt_SyncFolder";
            this.bt_SyncFolder.Size = new System.Drawing.Size(136, 23);
            this.bt_SyncFolder.TabIndex = 6;
            this.bt_SyncFolder.Text = "동기화 실행";
            this.bt_SyncFolder.UseVisualStyleBackColor = true;
            this.bt_SyncFolder.Click += new System.EventHandler(this.bt_SyncFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.bt_SyncFolder);
            this.Controls.Add(this.lst_FileName);
            this.Controls.Add(this.cb_DstIPList);
            this.Controls.Add(this.cb_SrcIPList);
            this.Controls.Add(this.lb_DstDescription);
            this.Controls.Add(this.bt_SrcFolder);
            this.Controls.Add(this.txt_SrcFolderLocation);
            this.Controls.Add(this.lb_SrcDescription);
            this.Controls.Add(this.txt_DstFolderLocation);
            this.Controls.Add(this.bt_DstFolder);
            this.Name = "Form1";
            this.Text = "Update Program v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SrcFolder;
        private System.Windows.Forms.Button bt_DstFolder;
        private System.Windows.Forms.TextBox txt_SrcFolderLocation;
        private System.Windows.Forms.TextBox txt_DstFolderLocation;
        private System.Windows.Forms.Label lb_SrcDescription;
        private System.Windows.Forms.Label lb_DstDescription;
        private System.Windows.Forms.ComboBox cb_SrcIPList;
        private System.Windows.Forms.ComboBox cb_DstIPList;
        private System.Windows.Forms.ListView lst_FileName;
        private System.Windows.Forms.Button bt_SyncFolder;
    }
}

