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
            this.kreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOtplatnaTablica = new System.Windows.Forms.DataGridView();
            this.btnPrintanje = new System.Windows.Forms.Button();
            this.otplatnatablicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brojMjesecaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anuitetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otplatnaKvotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ostatakDugaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otplaceniDioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kreditidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kreditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtplatnaTablica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otplatnatablicaBindingSource)).BeginInit();
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
            this.cbPopisKredita.SelectedIndexChanged += new System.EventHandler(this.cbPopisKredita_SelectedIndexChanged);
            // 
            // kreditBindingSource
            // 
            this.kreditBindingSource.DataSource = typeof(Login.Kredit_);
            // 
            // dgvOtplatnaTablica
            // 
            this.dgvOtplatnaTablica.AllowUserToAddRows = false;
            this.dgvOtplatnaTablica.AllowUserToDeleteRows = false;
            this.dgvOtplatnaTablica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOtplatnaTablica.AutoGenerateColumns = false;
            this.dgvOtplatnaTablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtplatnaTablica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brojMjesecaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.kamateDataGridViewTextBoxColumn,
            this.anuitetDataGridViewTextBoxColumn,
            this.otplatnaKvotaDataGridViewTextBoxColumn,
            this.ostatakDugaDataGridViewTextBoxColumn,
            this.otplaceniDioDataGridViewTextBoxColumn,
            this.kreditidDataGridViewTextBoxColumn,
            this.kreditDataGridViewTextBoxColumn});
            this.dgvOtplatnaTablica.DataSource = this.otplatnatablicaBindingSource;
            this.dgvOtplatnaTablica.Location = new System.Drawing.Point(30, 180);
            this.dgvOtplatnaTablica.Name = "dgvOtplatnaTablica";
            this.dgvOtplatnaTablica.Size = new System.Drawing.Size(643, 214);
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
            // otplatnatablicaBindingSource
            // 
            this.otplatnatablicaBindingSource.DataSource = typeof(Login.Otplatna_tablica);
            // 
            // brojMjesecaDataGridViewTextBoxColumn
            // 
            this.brojMjesecaDataGridViewTextBoxColumn.DataPropertyName = "BrojMjeseca";
            this.brojMjesecaDataGridViewTextBoxColumn.HeaderText = "Broj mjeseca";
            this.brojMjesecaDataGridViewTextBoxColumn.Name = "brojMjesecaDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // kamateDataGridViewTextBoxColumn
            // 
            this.kamateDataGridViewTextBoxColumn.DataPropertyName = "Kamate";
            this.kamateDataGridViewTextBoxColumn.HeaderText = "Kamate";
            this.kamateDataGridViewTextBoxColumn.Name = "kamateDataGridViewTextBoxColumn";
            // 
            // anuitetDataGridViewTextBoxColumn
            // 
            this.anuitetDataGridViewTextBoxColumn.DataPropertyName = "Anuitet";
            this.anuitetDataGridViewTextBoxColumn.HeaderText = "Anuitet";
            this.anuitetDataGridViewTextBoxColumn.Name = "anuitetDataGridViewTextBoxColumn";
            // 
            // otplatnaKvotaDataGridViewTextBoxColumn
            // 
            this.otplatnaKvotaDataGridViewTextBoxColumn.DataPropertyName = "OtplatnaKvota";
            this.otplatnaKvotaDataGridViewTextBoxColumn.HeaderText = "Otplatna kvota";
            this.otplatnaKvotaDataGridViewTextBoxColumn.Name = "otplatnaKvotaDataGridViewTextBoxColumn";
            // 
            // ostatakDugaDataGridViewTextBoxColumn
            // 
            this.ostatakDugaDataGridViewTextBoxColumn.DataPropertyName = "OstatakDuga";
            this.ostatakDugaDataGridViewTextBoxColumn.HeaderText = "Ostatak duga";
            this.ostatakDugaDataGridViewTextBoxColumn.Name = "ostatakDugaDataGridViewTextBoxColumn";
            // 
            // otplaceniDioDataGridViewTextBoxColumn
            // 
            this.otplaceniDioDataGridViewTextBoxColumn.DataPropertyName = "OtplaceniDio";
            this.otplaceniDioDataGridViewTextBoxColumn.HeaderText = "Otplaceni dio";
            this.otplaceniDioDataGridViewTextBoxColumn.Name = "otplaceniDioDataGridViewTextBoxColumn";
            // 
            // kreditidDataGridViewTextBoxColumn
            // 
            this.kreditidDataGridViewTextBoxColumn.DataPropertyName = "Kredit_id";
            this.kreditidDataGridViewTextBoxColumn.HeaderText = "Kredit_id";
            this.kreditidDataGridViewTextBoxColumn.Name = "kreditidDataGridViewTextBoxColumn";
            this.kreditidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kreditDataGridViewTextBoxColumn
            // 
            this.kreditDataGridViewTextBoxColumn.DataPropertyName = "Kredit_";
            this.kreditDataGridViewTextBoxColumn.HeaderText = "Kredit_";
            this.kreditDataGridViewTextBoxColumn.Name = "kreditDataGridViewTextBoxColumn";
            this.kreditDataGridViewTextBoxColumn.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.kreditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtplatnaTablica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otplatnatablicaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPopisKredita;
        private System.Windows.Forms.DataGridView dgvOtplatnaTablica;
        private System.Windows.Forms.Button btnPrintanje;
        private System.Windows.Forms.BindingSource kreditBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojMjesecaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anuitetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otplatnaKvotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ostatakDugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otplaceniDioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kreditidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource otplatnatablicaBindingSource;
    }
}