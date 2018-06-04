namespace Login.Forme
{
    partial class FrmMjenjacnica
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
            this.cbKupujem = new System.Windows.Forms.ComboBox();
            this.cbProdajem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnOdjaviSe = new System.Windows.Forms.Button();
            this.btnVratiSe = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(528, 316);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbKupujem
            // 
            this.cbKupujem.FormattingEnabled = true;
            this.cbKupujem.Location = new System.Drawing.Point(625, 130);
            this.cbKupujem.Name = "cbKupujem";
            this.cbKupujem.Size = new System.Drawing.Size(121, 24);
            this.cbKupujem.TabIndex = 3;
            // 
            // cbProdajem
            // 
            this.cbProdajem.FormattingEnabled = true;
            this.cbProdajem.Location = new System.Drawing.Point(800, 130);
            this.cbProdajem.Name = "cbProdajem";
            this.cbProdajem.Size = new System.Drawing.Size(121, 24);
            this.cbProdajem.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(800, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(625, 219);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 6;
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.ForeColor = System.Drawing.Color.Black;
            this.btnPromijeni.Location = new System.Drawing.Point(839, 322);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(82, 33);
            this.btnPromijeni.TabIndex = 7;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            // 
            // btnOdjaviSe
            // 
            this.btnOdjaviSe.ForeColor = System.Drawing.Color.Black;
            this.btnOdjaviSe.Location = new System.Drawing.Point(985, 439);
            this.btnOdjaviSe.Name = "btnOdjaviSe";
            this.btnOdjaviSe.Size = new System.Drawing.Size(82, 23);
            this.btnOdjaviSe.TabIndex = 8;
            this.btnOdjaviSe.Text = "Odjavi se";
            this.btnOdjaviSe.UseVisualStyleBackColor = true;
            // 
            // btnVratiSe
            // 
            this.btnVratiSe.ForeColor = System.Drawing.Color.Black;
            this.btnVratiSe.Location = new System.Drawing.Point(625, 289);
            this.btnVratiSe.Name = "btnVratiSe";
            this.btnVratiSe.Size = new System.Drawing.Size(82, 33);
            this.btnVratiSe.TabIndex = 9;
            this.btnVratiSe.Text = "Previous";
            this.btnVratiSe.UseVisualStyleBackColor = true;
            // 
            // btnPocetna
            // 
            this.btnPocetna.ForeColor = System.Drawing.Color.Black;
            this.btnPocetna.Location = new System.Drawing.Point(664, 360);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(82, 33);
            this.btnPocetna.TabIndex = 10;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            // 
            // FrmMjenjacnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 474);
            this.Controls.Add(this.btnPocetna);
            this.Controls.Add(this.btnVratiSe);
            this.Controls.Add(this.btnOdjaviSe);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbProdajem);
            this.Controls.Add(this.cbKupujem);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMjenjacnica";
            this.Text = "FrmMjenjacnica";
            this.Load += new System.EventHandler(this.FrmMjenjacnica_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.cbKupujem, 0);
            this.Controls.SetChildIndex(this.cbProdajem, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.btnPromijeni, 0);
            this.Controls.SetChildIndex(this.btnOdjaviSe, 0);
            this.Controls.SetChildIndex(this.btnVratiSe, 0);
            this.Controls.SetChildIndex(this.btnPocetna, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbKupujem;
        private System.Windows.Forms.ComboBox cbProdajem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnOdjaviSe;
        private System.Windows.Forms.Button btnVratiSe;
        private System.Windows.Forms.Button btnPocetna;
    }
}