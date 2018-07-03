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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiNazad = new System.Windows.Forms.Button();
            this.dgvPrikazKorisnika = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipklijentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilancasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.računDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stednjasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKrediti = new System.Windows.Forms.DataGridView();
            this.kreditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiUplatnicazaKredit = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glavnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokOtplateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamatnaStopaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivKreditaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otplatnatablicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrediti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uiNazad
            // 
            this.uiNazad.Image = global::MobiFinance.Properties.Resources.back;
            this.uiNazad.Location = new System.Drawing.Point(12, 95);
            this.uiNazad.Name = "uiNazad";
            this.uiNazad.Size = new System.Drawing.Size(101, 53);
            this.uiNazad.TabIndex = 2;
            this.uiNazad.UseVisualStyleBackColor = true;
            this.uiNazad.Click += new System.EventHandler(this.uiNazad_Click);
            // 
            // dgvPrikazKorisnika
            // 
            this.dgvPrikazKorisnika.AllowUserToAddRows = false;
            this.dgvPrikazKorisnika.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvPrikazKorisnika.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrikazKorisnika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrikazKorisnika.AutoGenerateColumns = false;
            this.dgvPrikazKorisnika.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPrikazKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kontaktDataGridViewTextBoxColumn,
            this.primanjaDataGridViewTextBoxColumn,
            this.tipklijentaDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.bilancasDataGridViewTextBoxColumn,
            this.kreditDataGridViewTextBoxColumn,
            this.računDataGridViewTextBoxColumn,
            this.stednjasDataGridViewTextBoxColumn});
            this.dgvPrikazKorisnika.DataSource = this.klijentBindingSource;
            this.dgvPrikazKorisnika.Location = new System.Drawing.Point(12, 154);
            this.dgvPrikazKorisnika.Name = "dgvPrikazKorisnika";
            this.dgvPrikazKorisnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazKorisnika.Size = new System.Drawing.Size(645, 97);
            this.dgvPrikazKorisnika.TabIndex = 3;
            this.dgvPrikazKorisnika.SelectionChanged += new System.EventHandler(this.dgvPrikazKorisnika_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            // 
            // primanjaDataGridViewTextBoxColumn
            // 
            this.primanjaDataGridViewTextBoxColumn.DataPropertyName = "Primanja";
            this.primanjaDataGridViewTextBoxColumn.HeaderText = "Primanja";
            this.primanjaDataGridViewTextBoxColumn.Name = "primanjaDataGridViewTextBoxColumn";
            this.primanjaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipklijentaDataGridViewTextBoxColumn
            // 
            this.tipklijentaDataGridViewTextBoxColumn.DataPropertyName = "Tip_klijenta";
            this.tipklijentaDataGridViewTextBoxColumn.HeaderText = "Tip_klijenta";
            this.tipklijentaDataGridViewTextBoxColumn.Name = "tipklijentaDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // bilancasDataGridViewTextBoxColumn
            // 
            this.bilancasDataGridViewTextBoxColumn.DataPropertyName = "Bilancas";
            this.bilancasDataGridViewTextBoxColumn.HeaderText = "Bilancas";
            this.bilancasDataGridViewTextBoxColumn.Name = "bilancasDataGridViewTextBoxColumn";
            this.bilancasDataGridViewTextBoxColumn.Visible = false;
            // 
            // kreditDataGridViewTextBoxColumn
            // 
            this.kreditDataGridViewTextBoxColumn.DataPropertyName = "Kredit_";
            this.kreditDataGridViewTextBoxColumn.HeaderText = "Kredit_";
            this.kreditDataGridViewTextBoxColumn.Name = "kreditDataGridViewTextBoxColumn";
            this.kreditDataGridViewTextBoxColumn.Visible = false;
            // 
            // računDataGridViewTextBoxColumn
            // 
            this.računDataGridViewTextBoxColumn.DataPropertyName = "Račun";
            this.računDataGridViewTextBoxColumn.HeaderText = "Račun";
            this.računDataGridViewTextBoxColumn.Name = "računDataGridViewTextBoxColumn";
            this.računDataGridViewTextBoxColumn.Visible = false;
            // 
            // stednjasDataGridViewTextBoxColumn
            // 
            this.stednjasDataGridViewTextBoxColumn.DataPropertyName = "Stednjas";
            this.stednjasDataGridViewTextBoxColumn.HeaderText = "Stednjas";
            this.stednjasDataGridViewTextBoxColumn.Name = "stednjasDataGridViewTextBoxColumn";
            this.stednjasDataGridViewTextBoxColumn.Visible = false;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(Login.Klijent);
            // 
            // dgvKrediti
            // 
            this.dgvKrediti.AllowUserToAddRows = false;
            this.dgvKrediti.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvKrediti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKrediti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKrediti.AutoGenerateColumns = false;
            this.dgvKrediti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKrediti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.datumPocetkaDataGridViewTextBoxColumn,
            this.glavnicaDataGridViewTextBoxColumn,
            this.rokOtplateDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.klijentidDataGridViewTextBoxColumn,
            this.kamatnaStopaDataGridViewTextBoxColumn,
            this.nazivKreditaDataGridViewTextBoxColumn,
            this.klijentDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.otplatnatablicaDataGridViewTextBoxColumn});
            this.dgvKrediti.DataSource = this.kreditBindingSource;
            this.dgvKrediti.Location = new System.Drawing.Point(12, 257);
            this.dgvKrediti.Name = "dgvKrediti";
            this.dgvKrediti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKrediti.Size = new System.Drawing.Size(663, 191);
            this.dgvKrediti.TabIndex = 4;
            // 
            // kreditBindingSource
            // 
            this.kreditBindingSource.DataSource = typeof(Login.Kredit_);
            // 
            // uiUplatnicazaKredit
            // 
            this.uiUplatnicazaKredit.Image = global::MobiFinance.Properties.Resources.settings;
            this.uiUplatnicazaKredit.Location = new System.Drawing.Point(779, 135);
            this.uiUplatnicazaKredit.Name = "uiUplatnicazaKredit";
            this.uiUplatnicazaKredit.Size = new System.Drawing.Size(94, 57);
            this.uiUplatnicazaKredit.TabIndex = 5;
            this.uiUplatnicazaKredit.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // datumPocetkaDataGridViewTextBoxColumn
            // 
            this.datumPocetkaDataGridViewTextBoxColumn.DataPropertyName = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.HeaderText = "DatumPocetka";
            this.datumPocetkaDataGridViewTextBoxColumn.Name = "datumPocetkaDataGridViewTextBoxColumn";
            // 
            // glavnicaDataGridViewTextBoxColumn
            // 
            this.glavnicaDataGridViewTextBoxColumn.DataPropertyName = "Glavnica";
            this.glavnicaDataGridViewTextBoxColumn.HeaderText = "Glavnica";
            this.glavnicaDataGridViewTextBoxColumn.Name = "glavnicaDataGridViewTextBoxColumn";
            // 
            // rokOtplateDataGridViewTextBoxColumn
            // 
            this.rokOtplateDataGridViewTextBoxColumn.DataPropertyName = "RokOtplate";
            this.rokOtplateDataGridViewTextBoxColumn.HeaderText = "RokOtplate";
            this.rokOtplateDataGridViewTextBoxColumn.Name = "rokOtplateDataGridViewTextBoxColumn";
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "Zaposlenik_id";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // klijentidDataGridViewTextBoxColumn
            // 
            this.klijentidDataGridViewTextBoxColumn.DataPropertyName = "Klijent_id";
            this.klijentidDataGridViewTextBoxColumn.HeaderText = "Klijent_id";
            this.klijentidDataGridViewTextBoxColumn.Name = "klijentidDataGridViewTextBoxColumn";
            this.klijentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kamatnaStopaDataGridViewTextBoxColumn
            // 
            this.kamatnaStopaDataGridViewTextBoxColumn.DataPropertyName = "KamatnaStopa";
            this.kamatnaStopaDataGridViewTextBoxColumn.HeaderText = "KamatnaStopa";
            this.kamatnaStopaDataGridViewTextBoxColumn.Name = "kamatnaStopaDataGridViewTextBoxColumn";
            // 
            // nazivKreditaDataGridViewTextBoxColumn
            // 
            this.nazivKreditaDataGridViewTextBoxColumn.DataPropertyName = "NazivKredita";
            this.nazivKreditaDataGridViewTextBoxColumn.HeaderText = "NazivKredita";
            this.nazivKreditaDataGridViewTextBoxColumn.Name = "nazivKreditaDataGridViewTextBoxColumn";
            // 
            // klijentDataGridViewTextBoxColumn
            // 
            this.klijentDataGridViewTextBoxColumn.DataPropertyName = "Klijent";
            this.klijentDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.klijentDataGridViewTextBoxColumn.Name = "klijentDataGridViewTextBoxColumn";
            this.klijentDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // otplatnatablicaDataGridViewTextBoxColumn
            // 
            this.otplatnatablicaDataGridViewTextBoxColumn.DataPropertyName = "Otplatna_tablica";
            this.otplatnatablicaDataGridViewTextBoxColumn.HeaderText = "Otplatna_tablica";
            this.otplatnatablicaDataGridViewTextBoxColumn.Name = "otplatnatablicaDataGridViewTextBoxColumn";
            this.otplatnatablicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmKreditiKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 463);
            this.Controls.Add(this.uiUplatnicazaKredit);
            this.Controls.Add(this.dgvKrediti);
            this.Controls.Add(this.dgvPrikazKorisnika);
            this.Controls.Add(this.uiNazad);
            this.Name = "FrmKreditiKorisnika";
            this.Text = "FrmKreditiKorisnika";
            this.Load += new System.EventHandler(this.FrmKreditiKorisnika_Load);
            this.Controls.SetChildIndex(this.uiNazad, 0);
            this.Controls.SetChildIndex(this.dgvPrikazKorisnika, 0);
            this.Controls.SetChildIndex(this.dgvKrediti, 0);
            this.Controls.SetChildIndex(this.uiUplatnicazaKredit, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKrediti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiNazad;
        private System.Windows.Forms.DataGridView dgvPrikazKorisnika;
        private System.Windows.Forms.DataGridView dgvKrediti;
        private System.Windows.Forms.Button uiUplatnicazaKredit;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.BindingSource kreditBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipklijentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilancasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn računDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stednjasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glavnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokOtplateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamatnaStopaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivKreditaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otplatnatablicaDataGridViewTextBoxColumn;
    }
}