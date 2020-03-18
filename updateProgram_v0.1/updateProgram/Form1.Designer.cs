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
            this.txt_SrcFolderLocation.Location = new System.Drawing.Point(238, 13);
            this.txt_SrcFolderLocation.Name = "txt_SrcFolderLocation";
            this.txt_SrcFolderLocation.Size = new System.Drawing.Size(266, 23);
            this.txt_SrcFolderLocation.TabIndex = 2;
            // 
            // txt_DstFolderLocation
            // 
            this.txt_DstFolderLocation.Location = new System.Drawing.Point(238, 43);
            this.txt_DstFolderLocation.Name = "txt_DstFolderLocation";
            this.txt_DstFolderLocation.Size = new System.Drawing.Size(266, 23);
            this.txt_DstFolderLocation.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.txt_DstFolderLocation);
            this.Controls.Add(this.txt_SrcFolderLocation);
            this.Controls.Add(this.bt_DstFolder);
            this.Controls.Add(this.bt_SrcFolder);
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
    }
}

