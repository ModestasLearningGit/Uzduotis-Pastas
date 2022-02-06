namespace PastasFull
{
    partial class frmTask2
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbConvertTo = new System.Windows.Forms.ComboBox();
            this.btnChangeDir = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(123, 417);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 14;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmbConvertTo
            // 
            this.cmbConvertTo.FormattingEnabled = true;
            this.cmbConvertTo.Items.AddRange(new object[] {
            ".xml",
            ".xlsx"});
            this.cmbConvertTo.Location = new System.Drawing.Point(123, 375);
            this.cmbConvertTo.Name = "cmbConvertTo";
            this.cmbConvertTo.Size = new System.Drawing.Size(155, 23);
            this.cmbConvertTo.TabIndex = 13;
            // 
            // btnChangeDir
            // 
            this.btnChangeDir.Location = new System.Drawing.Point(122, 338);
            this.btnChangeDir.Name = "btnChangeDir";
            this.btnChangeDir.Size = new System.Drawing.Size(75, 23);
            this.btnChangeDir.TabIndex = 12;
            this.btnChangeDir.Text = "Change Dir";
            this.btnChangeDir.UseVisualStyleBackColor = true;
            this.btnChangeDir.Click += new System.EventHandler(this.btnChangeDir_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(123, 300);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(327, 23);
            this.txtDirectory.TabIndex = 11;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(123, 259);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(100, 23);
            this.txtExtension.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 216);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 9;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(122, 176);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 8;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // frmTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 635);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbConvertTo);
            this.Controls.Add(this.btnChangeDir);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "frmTask2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTask2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConvert;
        private ComboBox cmbConvertTo;
        private Button btnChangeDir;
        private TextBox txtDirectory;
        private TextBox txtExtension;
        private TextBox txtName;
        private Button btnLoadFile;
    }
}