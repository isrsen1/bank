namespace Login.Forme
{
    partial class FrmOtplatnaTablica
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOtplatnaTablica));
            this.cbPopisKredita = new System.Windows.Forms.ComboBox();
            this.dgvOtplatnaTablica = new System.Windows.Forms.DataGridView();
            this.btnPrintanje = new System.Windows.Forms.Button();
            this.kreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtplatnaTablica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPopisKredita
            // 
            this.cbPopisKredita.DataSource = this.kreditBindingSource;
            this.cbPopisKredita.DisplayMember = "NazivKredita";
            this.cbPopisKredita.FormattingEnabled = true;
            this.cbPopisKredita.Location = new System.Drawing.Point(12, 139);
            this.cbPopisKredita.Name = "cbPopisKredita";
            this.cbPopisKredita.Size = new System.Drawing.Size(319, 21);
            this.cbPopisKredita.TabIndex = 0;
            this.cbPopisKredita.ValueMember = "Id";
            // 
            // dgvOtplatnaTablica
            // 
            this.dgvOtplatnaTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtplatnaTablica.Location = new System.Drawing.Point(12, 177);
            this.dgvOtplatnaTablica.Name = "dgvOtplatnaTablica";
            this.dgvOtplatnaTablica.Size = new System.Drawing.Size(655, 214);
            this.dgvOtplatnaTablica.TabIndex = 1;
            // 
            // btnPrintanje
            // 
            this.btnPrintanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintanje.ForeColor = System.Drawing.Color.Black;
            this.btnPrintanje.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintanje.Image")));
            this.btnPrintanje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintanje.Location = new System.Drawing.Point(711, 262);
            this.btnPrintanje.Name = "btnPrintanje";
            this.btnPrintanje.Size = new System.Drawing.Size(163, 61);
            this.btnPrintanje.TabIndex = 2;
            this.btnPrintanje.Text = "Printanje";
            this.btnPrintanje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintanje.UseVisualStyleBackColor = true;
            // 
            // kreditBindingSource
            // 
            this.kreditBindingSource.DataSource = typeof(Login.Kredit_);
            // 
            // FrmOtplatnaTablica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.btnPrintanje);
            this.Controls.Add(this.dgvOtplatnaTablica);
            this.Controls.Add(this.cbPopisKredita);
            this.Name = "FrmOtplatnaTablica";
            this.Text = "FrmOtplatnaTablica";
            this.Load += new System.EventHandler(this.FrmOtplatnaTablica_Load);
            this.Controls.SetChildIndex(this.cbPopisKredita, 0);
            this.Controls.SetChildIndex(this.dgvOtplatnaTablica, 0);
            this.Controls.SetChildIndex(this.btnPrintanje, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtplatnaTablica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPopisKredita;
        private System.Windows.Forms.DataGridView dgvOtplatnaTablica;
        private System.Windows.Forms.Button btnPrintanje;
        private System.Windows.Forms.BindingSource kreditBindingSource;
    }
}