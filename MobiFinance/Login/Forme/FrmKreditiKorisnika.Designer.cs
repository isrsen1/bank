namespace MobiFinance.Forme
{
    partial class FrmKreditiKorisnika
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
            this.uiNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNazad
            // 
            this.uiNazad.Location = new System.Drawing.Point(2, 113);
            this.uiNazad.Name = "uiNazad";
            this.uiNazad.Size = new System.Drawing.Size(124, 40);
            this.uiNazad.TabIndex = 2;
            this.uiNazad.Text = "uiNazad";
            this.uiNazad.UseVisualStyleBackColor = true;
            this.uiNazad.Click += new System.EventHandler(this.uiNazad_Click);
            // 
            // FrmKreditiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiNazad);
            this.Name = "FrmKreditiKorisnika";
            this.Text = "FrmKreditiKorisnika";
            this.Load += new System.EventHandler(this.FrmKreditiKorisnika_Load);
            this.Controls.SetChildIndex(this.uiNazad, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiNazad;
    }
}