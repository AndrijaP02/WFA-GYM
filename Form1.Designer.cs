using WindowsFormsAppAP;

namespace WindowsFormsAppAnastasija
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDClanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodatneUslugeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDTreningaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsAppAP.DataSet1();
            this.clanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clanTableAdapter = new WindowsFormsAppAP.DataSet1TableAdapters.ClanTableAdapter();
            this.treningTableAdapter = new WindowsFormsAppAP.DataSet1TableAdapters.TreningTableAdapter();
            this.gbBrojClanova = new System.Windows.Forms.GroupBox();
            this.tbBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbVrste = new System.Windows.Forms.GroupBox();
            this.rbOba = new System.Windows.Forms.RadioButton();
            this.rbTeretana = new System.Windows.Forms.RadioButton();
            this.rbKardio = new System.Windows.Forms.RadioButton();
            this.gbPrikaz = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPrikaz = new System.Windows.Forms.ListBox();
            this.cmbIme = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviClanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).BeginInit();
            this.gbBrojClanova.SuspendLayout();
            this.gbVrste.SuspendLayout();
            this.gbPrikaz.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClanaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.dodatneUslugeDataGridViewCheckBoxColumn,
            this.iDTreningaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDClanaDataGridViewTextBoxColumn
            // 
            this.iDClanaDataGridViewTextBoxColumn.DataPropertyName = "IDClana";
            this.iDClanaDataGridViewTextBoxColumn.HeaderText = "IDClana";
            this.iDClanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDClanaDataGridViewTextBoxColumn.Name = "iDClanaDataGridViewTextBoxColumn";
            this.iDClanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dodatneUslugeDataGridViewCheckBoxColumn
            // 
            this.dodatneUslugeDataGridViewCheckBoxColumn.DataPropertyName = "DodatneUsluge";
            this.dodatneUslugeDataGridViewCheckBoxColumn.HeaderText = "DodatneUsluge";
            this.dodatneUslugeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dodatneUslugeDataGridViewCheckBoxColumn.Name = "dodatneUslugeDataGridViewCheckBoxColumn";
            this.dodatneUslugeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // iDTreningaDataGridViewTextBoxColumn
            // 
            this.iDTreningaDataGridViewTextBoxColumn.DataPropertyName = "IDTreninga";
            this.iDTreningaDataGridViewTextBoxColumn.DataSource = this.treningBindingSource;
            this.iDTreningaDataGridViewTextBoxColumn.DisplayMember = "VrstaTreninga";
            this.iDTreningaDataGridViewTextBoxColumn.HeaderText = "Trening";
            this.iDTreningaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDTreningaDataGridViewTextBoxColumn.Name = "iDTreningaDataGridViewTextBoxColumn";
            this.iDTreningaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDTreningaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDTreningaDataGridViewTextBoxColumn.ValueMember = "IDTreninga";
            this.iDTreningaDataGridViewTextBoxColumn.Width = 125;
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataMember = "Trening";
            this.treningBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clanBindingSource
            // 
            this.clanBindingSource.DataMember = "Clan";
            this.clanBindingSource.DataSource = this.dataSet1;
            // 
            // clanTableAdapter
            // 
            this.clanTableAdapter.ClearBeforeFill = true;
            // 
            // treningTableAdapter
            // 
            this.treningTableAdapter.ClearBeforeFill = true;
            // 
            // gbBrojClanova
            // 
            this.gbBrojClanova.Controls.Add(this.tbBroj);
            this.gbBrojClanova.Controls.Add(this.label1);
            this.gbBrojClanova.Controls.Add(this.gbVrste);
            this.gbBrojClanova.Location = new System.Drawing.Point(13, 281);
            this.gbBrojClanova.Name = "gbBrojClanova";
            this.gbBrojClanova.Size = new System.Drawing.Size(775, 133);
            this.gbBrojClanova.TabIndex = 1;
            this.gbBrojClanova.TabStop = false;
            this.gbBrojClanova.Text = "Broj clanova";
            // 
            // tbBroj
            // 
            this.tbBroj.Location = new System.Drawing.Point(574, 56);
            this.tbBroj.Name = "tbBroj";
            this.tbBroj.ReadOnly = true;
            this.tbBroj.Size = new System.Drawing.Size(100, 22);
            this.tbBroj.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj članova za odabranu vrstu";
            // 
            // gbVrste
            // 
            this.gbVrste.Controls.Add(this.rbOba);
            this.gbVrste.Controls.Add(this.rbTeretana);
            this.gbVrste.Controls.Add(this.rbKardio);
            this.gbVrste.Location = new System.Drawing.Point(28, 37);
            this.gbVrste.Name = "gbVrste";
            this.gbVrste.Size = new System.Drawing.Size(289, 65);
            this.gbVrste.TabIndex = 0;
            this.gbVrste.TabStop = false;
            this.gbVrste.Text = "Vrste treninga";
            // 
            // rbOba
            // 
            this.rbOba.AutoSize = true;
            this.rbOba.Location = new System.Drawing.Point(191, 22);
            this.rbOba.Name = "rbOba";
            this.rbOba.Size = new System.Drawing.Size(54, 20);
            this.rbOba.TabIndex = 2;
            this.rbOba.TabStop = true;
            this.rbOba.Text = "Oba";
            this.rbOba.UseVisualStyleBackColor = true;
            this.rbOba.CheckedChanged += new System.EventHandler(this.rbKardio_CheckedChanged);
            // 
            // rbTeretana
            // 
            this.rbTeretana.AutoSize = true;
            this.rbTeretana.Location = new System.Drawing.Point(102, 22);
            this.rbTeretana.Name = "rbTeretana";
            this.rbTeretana.Size = new System.Drawing.Size(83, 20);
            this.rbTeretana.TabIndex = 1;
            this.rbTeretana.TabStop = true;
            this.rbTeretana.Text = "Teretana";
            this.rbTeretana.UseVisualStyleBackColor = true;
            this.rbTeretana.CheckedChanged += new System.EventHandler(this.rbKardio_CheckedChanged);
            // 
            // rbKardio
            // 
            this.rbKardio.AutoSize = true;
            this.rbKardio.Location = new System.Drawing.Point(7, 22);
            this.rbKardio.Name = "rbKardio";
            this.rbKardio.Size = new System.Drawing.Size(67, 20);
            this.rbKardio.TabIndex = 0;
            this.rbKardio.TabStop = true;
            this.rbKardio.Text = "Kardio";
            this.rbKardio.UseVisualStyleBackColor = true;
            this.rbKardio.CheckedChanged += new System.EventHandler(this.rbKardio_CheckedChanged);
            // 
            // gbPrikaz
            // 
            this.gbPrikaz.Controls.Add(this.label3);
            this.gbPrikaz.Controls.Add(this.label2);
            this.gbPrikaz.Controls.Add(this.lbPrikaz);
            this.gbPrikaz.Controls.Add(this.cmbIme);
            this.gbPrikaz.Location = new System.Drawing.Point(13, 431);
            this.gbPrikaz.Name = "gbPrikaz";
            this.gbPrikaz.Size = new System.Drawing.Size(775, 100);
            this.gbPrikaz.TabIndex = 2;
            this.gbPrikaz.TabStop = false;
            this.gbPrikaz.Text = "Prikaz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prikaz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime i Prezime";
            // 
            // lbPrikaz
            // 
            this.lbPrikaz.FormattingEnabled = true;
            this.lbPrikaz.ItemHeight = 16;
            this.lbPrikaz.Location = new System.Drawing.Point(198, 37);
            this.lbPrikaz.Name = "lbPrikaz";
            this.lbPrikaz.Size = new System.Drawing.Size(561, 52);
            this.lbPrikaz.TabIndex = 1;
            // 
            // cmbIme
            // 
            this.cmbIme.FormattingEnabled = true;
            this.cmbIme.Location = new System.Drawing.Point(28, 50);
            this.cmbIme.Name = "cmbIme";
            this.cmbIme.Size = new System.Drawing.Size(151, 24);
            this.cmbIme.TabIndex = 0;
            this.cmbIme.SelectedIndexChanged += new System.EventHandler(this.cmbIme_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clanToolStripMenuItem
            // 
            this.clanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviClanToolStripMenuItem});
            this.clanToolStripMenuItem.Name = "clanToolStripMenuItem";
            this.clanToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.clanToolStripMenuItem.Text = "Clan";
            // 
            // noviClanToolStripMenuItem
            // 
            this.noviClanToolStripMenuItem.Name = "noviClanToolStripMenuItem";
            this.noviClanToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.noviClanToolStripMenuItem.Text = "Novi clan";
            this.noviClanToolStripMenuItem.Click += new System.EventHandler(this.noviClanToolStripMenuItem_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(13, 252);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 4;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(109, 252);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.gbPrikaz);
            this.Controls.Add(this.gbBrojClanova);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clanBindingSource)).EndInit();
            this.gbBrojClanova.ResumeLayout(false);
            this.gbBrojClanova.PerformLayout();
            this.gbVrste.ResumeLayout(false);
            this.gbVrste.PerformLayout();
            this.gbPrikaz.ResumeLayout(false);
            this.gbPrikaz.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clanBindingSource;
        private WindowsFormsAppAP.DataSet1TableAdapters.ClanTableAdapter clanTableAdapter;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private WindowsFormsAppAP.DataSet1TableAdapters.TreningTableAdapter treningTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dodatneUslugeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDTreningaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gbBrojClanova;
        private System.Windows.Forms.TextBox tbBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbVrste;
        private System.Windows.Forms.RadioButton rbOba;
        private System.Windows.Forms.RadioButton rbTeretana;
        private System.Windows.Forms.RadioButton rbKardio;
        private System.Windows.Forms.GroupBox gbPrikaz;
        private System.Windows.Forms.ListBox lbPrikaz;
        private System.Windows.Forms.ComboBox cmbIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviClanToolStripMenuItem;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnObrisi;
    }
}

