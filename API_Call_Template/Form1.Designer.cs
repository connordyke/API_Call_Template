namespace API_Call_Template
{
    partial class frmAPICall
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
            this.picAPOD = new System.Windows.Forms.PictureBox();
            this.btnNASA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAPOD)).BeginInit();
            this.SuspendLayout();
            // 
            // picAPOD
            // 
            this.picAPOD.Location = new System.Drawing.Point(12, 12);
            this.picAPOD.Name = "picAPOD";
            this.picAPOD.Size = new System.Drawing.Size(776, 356);
            this.picAPOD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAPOD.TabIndex = 0;
            this.picAPOD.TabStop = false;
            // 
            // btnNASA
            // 
            this.btnNASA.Location = new System.Drawing.Point(308, 374);
            this.btnNASA.Name = "btnNASA";
            this.btnNASA.Size = new System.Drawing.Size(169, 53);
            this.btnNASA.TabIndex = 1;
            this.btnNASA.Text = "APOD Image";
            this.btnNASA.UseVisualStyleBackColor = true;
            this.btnNASA.Click += new System.EventHandler(this.btnNASA_Click);
            // 
            // frmAPICall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNASA);
            this.Controls.Add(this.picAPOD);
            this.Name = "frmAPICall";
            this.Text = "API Call";
            this.Load += new System.EventHandler(this.frmAPICall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAPOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAPOD;
        private System.Windows.Forms.Button btnNASA;
    }
}

