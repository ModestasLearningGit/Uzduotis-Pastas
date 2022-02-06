namespace PastasFull
{
    partial class FrmTask1_3
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.txtSuma2 = new System.Windows.Forms.TextBox();
            this.txtSuma1 = new System.Windows.Forms.TextBox();
            this.txtKodas = new System.Windows.Forms.TextBox();
            this.txtAdresas = new System.Windows.Forms.TextBox();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.txtSelectFolderPDF = new System.Windows.Forms.Button();
            this.txtPathForPdf = new System.Windows.Forms.TextBox();
            this.txtPdfName = new System.Windows.Forms.TextBox();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(43, 21);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(43, 165);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(323, 23);
            this.txtPath.TabIndex = 7;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(43, 116);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.ReadOnly = true;
            this.txtExtension.Size = new System.Drawing.Size(100, 23);
            this.txtExtension.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 72);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 5;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(23, 212);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowTemplate.Height = 25;
            this.dgvShow.Size = new System.Drawing.Size(390, 387);
            this.dgvShow.TabIndex = 8;
            this.dgvShow.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShow_RowHeaderMouseClick_1);
            // 
            // txtSuma2
            // 
            this.txtSuma2.Location = new System.Drawing.Point(551, 398);
            this.txtSuma2.Name = "txtSuma2";
            this.txtSuma2.ReadOnly = true;
            this.txtSuma2.Size = new System.Drawing.Size(100, 23);
            this.txtSuma2.TabIndex = 20;
            // 
            // txtSuma1
            // 
            this.txtSuma1.Location = new System.Drawing.Point(551, 357);
            this.txtSuma1.Name = "txtSuma1";
            this.txtSuma1.ReadOnly = true;
            this.txtSuma1.Size = new System.Drawing.Size(100, 23);
            this.txtSuma1.TabIndex = 19;
            // 
            // txtKodas
            // 
            this.txtKodas.Location = new System.Drawing.Point(551, 308);
            this.txtKodas.Name = "txtKodas";
            this.txtKodas.ReadOnly = true;
            this.txtKodas.Size = new System.Drawing.Size(100, 23);
            this.txtKodas.TabIndex = 18;
            // 
            // txtAdresas
            // 
            this.txtAdresas.Location = new System.Drawing.Point(551, 260);
            this.txtAdresas.Name = "txtAdresas";
            this.txtAdresas.ReadOnly = true;
            this.txtAdresas.Size = new System.Drawing.Size(100, 23);
            this.txtAdresas.TabIndex = 17;
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(551, 212);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.ReadOnly = true;
            this.txtVardas.Size = new System.Drawing.Size(100, 23);
            this.txtVardas.TabIndex = 16;
            // 
            // txtSelectFolderPDF
            // 
            this.txtSelectFolderPDF.Location = new System.Drawing.Point(433, 21);
            this.txtSelectFolderPDF.Name = "txtSelectFolderPDF";
            this.txtSelectFolderPDF.Size = new System.Drawing.Size(95, 23);
            this.txtSelectFolderPDF.TabIndex = 22;
            this.txtSelectFolderPDF.Text = "Select Folder";
            this.txtSelectFolderPDF.UseVisualStyleBackColor = true;
            this.txtSelectFolderPDF.Click += new System.EventHandler(this.txtSelectFolderPDF_Click);
            // 
            // txtPathForPdf
            // 
            this.txtPathForPdf.Location = new System.Drawing.Point(433, 50);
            this.txtPathForPdf.Name = "txtPathForPdf";
            this.txtPathForPdf.Size = new System.Drawing.Size(374, 23);
            this.txtPathForPdf.TabIndex = 21;
            // 
            // txtPdfName
            // 
            this.txtPdfName.Location = new System.Drawing.Point(551, 91);
            this.txtPdfName.Name = "txtPdfName";
            this.txtPdfName.Size = new System.Drawing.Size(100, 23);
            this.txtPdfName.TabIndex = 24;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(551, 144);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 23;
            this.btnPDF.Text = "To PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "PDF Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sum1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sum2";
            // 
            // FrmTask1_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 635);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPdfName);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.txtSelectFolderPDF);
            this.Controls.Add(this.txtPathForPdf);
            this.Controls.Add(this.txtSuma2);
            this.Controls.Add(this.txtSuma1);
            this.Controls.Add(this.txtKodas);
            this.Controls.Add(this.txtAdresas);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "FrmTask1_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTask1_3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenFile;
        private TextBox txtPath;
        private TextBox txtExtension;
        private TextBox txtName;
        private DataGridView dgvShow;
        private TextBox txtSuma2;
        private TextBox txtSuma1;
        private TextBox txtKodas;
        private TextBox txtAdresas;
        private TextBox txtVardas;
        private Button txtSelectFolderPDF;
        private TextBox txtPathForPdf;
        private TextBox txtPdfName;
        private Button btnPDF;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}