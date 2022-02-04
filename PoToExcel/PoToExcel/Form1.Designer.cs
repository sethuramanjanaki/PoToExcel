
namespace PoToExcel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPoFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExcelToPo = new System.Windows.Forms.TextBox();
            this.btnExcelToPoConvert = new System.Windows.Forms.Button();
            this.btnBrowseExcel = new System.Windows.Forms.Button();
            this.txtTargetFolderPath1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnTargetFolder = new System.Windows.Forms.Button();
            this.btnTargetFolder2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTargetFolder2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPoFilePath
            // 
            this.txtPoFilePath.Location = new System.Drawing.Point(155, 82);
            this.txtPoFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoFilePath.Name = "txtPoFilePath";
            this.txtPoFilePath.Size = new System.Drawing.Size(575, 22);
            this.txtPoFilePath.TabIndex = 0;
            this.txtPoFilePath.Text = "C:\\Users\\CADDY CODE SOLUTIONS\\Downloads\\6storage-online-pl_PL 1.po";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Po to Excel";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(769, 82);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse....";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(364, 183);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Excel to PO";
            // 
            // txtExcelToPo
            // 
            this.txtExcelToPo.Location = new System.Drawing.Point(155, 252);
            this.txtExcelToPo.Margin = new System.Windows.Forms.Padding(4);
            this.txtExcelToPo.Name = "txtExcelToPo";
            this.txtExcelToPo.Size = new System.Drawing.Size(575, 22);
            this.txtExcelToPo.TabIndex = 5;
            this.txtExcelToPo.Text = "C:\\Users\\CADDY CODE SOLUTIONS\\Downloads\\PolishLanguageTranslation.xlsx";
            // 
            // btnExcelToPoConvert
            // 
            this.btnExcelToPoConvert.Location = new System.Drawing.Point(364, 382);
            this.btnExcelToPoConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcelToPoConvert.Name = "btnExcelToPoConvert";
            this.btnExcelToPoConvert.Size = new System.Drawing.Size(75, 23);
            this.btnExcelToPoConvert.TabIndex = 6;
            this.btnExcelToPoConvert.Text = "Convert";
            this.btnExcelToPoConvert.UseVisualStyleBackColor = true;
            this.btnExcelToPoConvert.Click += new System.EventHandler(this.btnExcelToPoConvert_Click);
            // 
            // btnBrowseExcel
            // 
            this.btnBrowseExcel.Location = new System.Drawing.Point(769, 254);
            this.btnBrowseExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseExcel.Name = "btnBrowseExcel";
            this.btnBrowseExcel.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseExcel.TabIndex = 7;
            this.btnBrowseExcel.Text = "Browse....";
            this.btnBrowseExcel.UseVisualStyleBackColor = true;
            this.btnBrowseExcel.Click += new System.EventHandler(this.btnBrowseExcel_Click);
            // 
            // txtTargetFolderPath1
            // 
            this.txtTargetFolderPath1.Location = new System.Drawing.Point(155, 119);
            this.txtTargetFolderPath1.Name = "txtTargetFolderPath1";
            this.txtTargetFolderPath1.Size = new System.Drawing.Size(575, 22);
            this.txtTargetFolderPath1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Download Path";
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(769, 117);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(75, 23);
            this.btnTargetFolder.TabIndex = 10;
            this.btnTargetFolder.Text = "Browse";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // btnTargetFolder2
            // 
            this.btnTargetFolder2.Location = new System.Drawing.Point(769, 326);
            this.btnTargetFolder2.Name = "btnTargetFolder2";
            this.btnTargetFolder2.Size = new System.Drawing.Size(75, 23);
            this.btnTargetFolder2.TabIndex = 13;
            this.btnTargetFolder2.Text = "Browse";
            this.btnTargetFolder2.UseVisualStyleBackColor = true;
            this.btnTargetFolder2.Click += new System.EventHandler(this.btnTargetFolder2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Download Path";
            // 
            // txtTargetFolder2
            // 
            this.txtTargetFolder2.Location = new System.Drawing.Point(155, 328);
            this.txtTargetFolder2.Name = "txtTargetFolder2";
            this.txtTargetFolder2.Size = new System.Drawing.Size(575, 22);
            this.txtTargetFolder2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 528);
            this.Controls.Add(this.btnTargetFolder2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTargetFolder2);
            this.Controls.Add(this.btnTargetFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTargetFolderPath1);
            this.Controls.Add(this.btnBrowseExcel);
            this.Controls.Add(this.btnExcelToPoConvert);
            this.Controls.Add(this.txtExcelToPo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoFilePath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtPoFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExcelToPo;
        private System.Windows.Forms.Button btnExcelToPoConvert;
        private System.Windows.Forms.Button btnBrowseExcel;
        private System.Windows.Forms.TextBox txtTargetFolderPath1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnTargetFolder;
        private System.Windows.Forms.Button btnTargetFolder2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTargetFolder2;
    }
}

