namespace PastasFull
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILE\r\nMANIPULATION\r\nPROGRAM\r\n";
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(352, 237);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(134, 96);
            this.btn13.TabIndex = 1;
            this.btn13.Text = "TASK 1 AND 3";
            this.btn13.UseVisualStyleBackColor = true;
            this.btn13.Click += new System.EventHandler(this.btn13_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(560, 237);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(134, 96);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "TASK 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 635);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn13;
        private Button btn2;
    }
}