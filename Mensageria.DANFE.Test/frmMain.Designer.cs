namespace Mensageria.DANFE.Test
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnFileName = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDanfe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(102, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(533, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(641, 25);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(33, 23);
            this.btnFileName.TabIndex = 2;
            this.btnFileName.Text = "...";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnDanfe
            // 
            this.btnDanfe.Location = new System.Drawing.Point(599, 98);
            this.btnDanfe.Name = "btnDanfe";
            this.btnDanfe.Size = new System.Drawing.Size(75, 40);
            this.btnDanfe.TabIndex = 3;
            this.btnDanfe.Text = "Danfe";
            this.btnDanfe.UseVisualStyleBackColor = true;
            this.btnDanfe.Click += new System.EventHandler(this.btnDanfe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 150);
            this.Controls.Add(this.btnDanfe);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDanfe;
    }
}

