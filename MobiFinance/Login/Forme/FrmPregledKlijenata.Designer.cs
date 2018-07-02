namespace Login.Forme
{
    partial class FrmPregledKlijenata
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.btnDodajPrivatnog = new System.Windows.Forms.Button();
            this.btnDodajPoslovnog = new System.Windows.Forms.Button();
            this.btnPrethodna = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 286);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(762, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(762, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Image = global::MobiFinance.Properties.Resources.filter1;
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(957, 210);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(97, 38);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.ForeColor = System.Drawing.Color.Black;
            this.btnOdjaviSe.Location = new System.Drawing.Point(991, 432);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(75, 30);
            this.btnOdjaviSe.TabIndex = 6;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            // 
            // btnDodajPrivatnog
            // 
            this.btnDodajPrivatnog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPrivatnog.ForeColor = System.Drawing.Color.Black;
            this.btnDodajPrivatnog.Image = global::MobiFinance.Properties.Resources.addUser;
            this.btnDodajPrivatnog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPrivatnog.Location = new System.Drawing.Point(808, 283);
            this.btnDodajPrivatnog.Name = "btnDodajPrivatnog";
            this.btnDodajPrivatnog.Size = new System.Drawing.Size(231, 57);
            this.btnDodajPrivatnog.TabIndex = 7;
            this.btnDodajPrivatnog.Text = "Privatni korisnik";
            this.btnDodajPrivatnog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajPrivatnog.UseVisualStyleBackColor = true;
            this.btnDodajPrivatnog.Click += new System.EventHandler(this.btnDodajPrivatnog_Click);
            // 
            // btnDodajPoslovnog
            // 
            this.btnDodajPoslovnog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPoslovnog.ForeColor = System.Drawing.Color.Black;
            this.btnDodajPoslovnog.Image = global::MobiFinance.Properties.Resources.addUser1;
            this.btnDodajPoslovnog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPoslovnog.Location = new System.Drawing.Point(808, 346);
            this.btnDodajPoslovnog.Name = "btnDodajPoslovnog";
            this.btnDodajPoslovnog.Size = new System.Drawing.Size(231, 57);
            this.btnDodajPoslovnog.TabIndex = 8;
            this.btnDodajPoslovnog.Text = "Poslovni korisnik";
            this.btnDodajPoslovnog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajPoslovnog.UseVisualStyleBackColor = true;
            this.btnDodajPoslovnog.Click += new System.EventHandler(this.btnDodajPoslovnog_Click);
            // 
            // btnPrethodna
            // 
            this.btnPrethodna.ForeColor = System.Drawing.Color.Black;
            this.btnPrethodna.Location = new System.Drawing.Point(2, 112);
            this.btnPrethodna.Name = "btnPrethodna";
            this.btnPrethodna.Size = new System.Drawing.Size(88, 30);
            this.btnPrethodna.TabIndex = 9;
            this.btnPrethodna.Text = "Prethodna";
            this.btnPrethodna.UseVisualStyleBackColor = true;
            this.btnPrethodna.Click += new System.EventHandler(this.btnPrethodna_Click);
            // 
            // btnPocetna
            // 
            this.btnPocetna.ForeColor = System.Drawing.Color.Black;
            this.btnPocetna.Location = new System.Drawing.Point(2, 148);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(88, 30);
            this.btnPocetna.TabIndex = 10;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // FrmPregledKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 474);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.btnPrethodna);
            this.Controls.Add(this.btnDodajPoslovnog);
            this.Controls.Add(this.btnDodajPrivatnog);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPregledKlijenata";
            this.Text = "FrmPregledKorisnika";
            this.Load += new System.EventHandler(this.FrmPregledKorisnika_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.btnFilter, 0);
            this.Controls.SetChildIndex(this.btnOdjaviSe, 0);
            this.Controls.SetChildIndex(this.btnDodajPrivatnog, 0);
            this.Controls.SetChildIndex(this.btnDodajPoslovnog, 0);
            this.Controls.SetChildIndex(this.btnPrethodna, 0);
            this.Controls.SetChildIndex(this.btnPocetna, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Button btnDodajPrivatnog;
        private System.Windows.Forms.Button btnDodajPoslovnog;
        private System.Windows.Forms.Button btnPrethodna;
        private System.Windows.Forms.Button btnPocetna;
    }
}