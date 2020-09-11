namespace Knjiznica
{
    partial class knjiznicaMainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtKnjiga = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelIzdavac = new System.Windows.Forms.Label();
            this.labelGod = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelKnjiga = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVrati = new System.Windows.Forms.Button();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.txtPosudio = new System.Windows.Forms.TextBox();
            this.labelPosudio = new System.Windows.Forms.Label();
            this.toolTipDodaj = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUredi = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipObrisi = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPosudi = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVrati = new System.Windows.Forms.ToolTip(this.components);
            this.btnSpajanje = new System.Windows.Forms.Button();
            this.btnOdspoji = new System.Windows.Forms.Button();
            this.toolTipSpajanje = new System.Windows.Forms.ToolTip(this.components);
            this.btnAzur = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxPretraga = new System.Windows.Forms.GroupBox();
            this.labelPretraga = new System.Windows.Forms.Label();
            this.comboBoxPretraga = new System.Windows.Forms.ComboBox();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spajanjeSBazomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odspojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izgledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojaPozadineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCisti = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoxPretraga.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtIzdavac);
            this.groupBox1.Controls.Add(this.txtGod);
            this.groupBox1.Controls.Add(this.txtAutor);
            this.groupBox1.Controls.Add(this.txtKnjiga);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.labelISBN);
            this.groupBox1.Controls.Add(this.labelIzdavac);
            this.groupBox1.Controls.Add(this.labelGod);
            this.groupBox1.Controls.Add(this.labelAutor);
            this.groupBox1.Controls.Add(this.labelKnjiga);
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PODACI O KNJIZI";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(121, 201);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(237, 20);
            this.txtISBN.TabIndex = 11;
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(121, 165);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(237, 20);
            this.txtIzdavac.TabIndex = 10;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(121, 134);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(237, 20);
            this.txtGod.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(121, 99);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(237, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // txtKnjiga
            // 
            this.txtKnjiga.Location = new System.Drawing.Point(121, 68);
            this.txtKnjiga.Name = "txtKnjiga";
            this.txtKnjiga.Size = new System.Drawing.Size(237, 20);
            this.txtKnjiga.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(237, 20);
            this.txtID.TabIndex = 6;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(21, 208);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(35, 15);
            this.labelISBN.TabIndex = 5;
            this.labelISBN.Text = "ISBN";
            this.labelISBN.Click += new System.EventHandler(this.labelISBN_Click);
            // 
            // labelIzdavac
            // 
            this.labelIzdavac.AutoSize = true;
            this.labelIzdavac.Location = new System.Drawing.Point(21, 172);
            this.labelIzdavac.Name = "labelIzdavac";
            this.labelIzdavac.Size = new System.Drawing.Size(48, 15);
            this.labelIzdavac.TabIndex = 4;
            this.labelIzdavac.Text = "Izdavač";
            this.labelIzdavac.Click += new System.EventHandler(this.labelIzdavac_Click);
            // 
            // labelGod
            // 
            this.labelGod.AutoSize = true;
            this.labelGod.Location = new System.Drawing.Point(21, 137);
            this.labelGod.Name = "labelGod";
            this.labelGod.Size = new System.Drawing.Size(90, 15);
            this.labelGod.TabIndex = 3;
            this.labelGod.Text = "Godina izdanja";
            this.labelGod.Click += new System.EventHandler(this.labelGod_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(21, 106);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 15);
            this.labelAutor.TabIndex = 2;
            this.labelAutor.Text = "Autor";
            this.labelAutor.Click += new System.EventHandler(this.labelAutor_Click);
            // 
            // labelKnjiga
            // 
            this.labelKnjiga.AutoSize = true;
            this.labelKnjiga.Location = new System.Drawing.Point(21, 68);
            this.labelKnjiga.Name = "labelKnjiga";
            this.labelKnjiga.Size = new System.Drawing.Size(73, 15);
            this.labelKnjiga.TabIndex = 1;
            this.labelKnjiga.Text = "Naziv knjige";
            this.labelKnjiga.Click += new System.EventHandler(this.labelKnjiga_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(21, 38);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(19, 15);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            this.labelID.Click += new System.EventHandler(this.labelID_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(456, 56);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(143, 53);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.toolTipDodaj.SetToolTip(this.btnDodaj, "Unesite podatke o knjizi te ju dodajte u knjižnicu!");
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(456, 127);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(143, 55);
            this.btnIzmjeni.TabIndex = 2;
            this.btnIzmjeni.Text = "Izmjeni";
            this.toolTipUredi.SetToolTip(this.btnIzmjeni, "Unesite ID i podatke knjige koju želite izmijeniti!");
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(456, 200);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(143, 51);
            this.btnBrisi.TabIndex = 3;
            this.btnBrisi.Text = "Obriši";
            this.toolTipObrisi.SetToolTip(this.btnBrisi, "Unesite ID knjige koju želite izbrisati iz knjižnice!");
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVrati);
            this.groupBox2.Controls.Add(this.btnPosudi);
            this.groupBox2.Controls.Add(this.txtPosudio);
            this.groupBox2.Controls.Add(this.labelPosudio);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.groupBox2.Location = new System.Drawing.Point(727, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 116);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "POSUĐIVANJE";
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(242, 68);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(212, 29);
            this.btnVrati.TabIndex = 3;
            this.btnVrati.Text = "VRATI";
            this.toolTipVrati.SetToolTip(this.btnVrati, "Unesite ID knjige koju želite vratiti!");
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(34, 68);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(189, 29);
            this.btnPosudi.TabIndex = 2;
            this.btnPosudi.Text = "POSUDI";
            this.toolTipPosudi.SetToolTip(this.btnPosudi, "Unesite ID knjige koju želite posuditi te ime i prezime klijenta!");
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // txtPosudio
            // 
            this.txtPosudio.Location = new System.Drawing.Point(131, 30);
            this.txtPosudio.Name = "txtPosudio";
            this.txtPosudio.Size = new System.Drawing.Size(323, 20);
            this.txtPosudio.TabIndex = 1;
            // 
            // labelPosudio
            // 
            this.labelPosudio.AutoSize = true;
            this.labelPosudio.Location = new System.Drawing.Point(31, 33);
            this.labelPosudio.Name = "labelPosudio";
            this.labelPosudio.Size = new System.Drawing.Size(52, 15);
            this.labelPosudio.TabIndex = 0;
            this.labelPosudio.Text = "Posudio";
            this.labelPosudio.Click += new System.EventHandler(this.labelPosudio_Click);
            // 
            // toolTipDodaj
            // 
            this.toolTipDodaj.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipDodaj.ToolTipTitle = "Dodaj";
            // 
            // toolTipUredi
            // 
            this.toolTipUredi.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUredi.ToolTipTitle = "Uredi/Izmjeni";
            // 
            // toolTipObrisi
            // 
            this.toolTipObrisi.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipObrisi.ToolTipTitle = "Obriši";
            // 
            // toolTipPosudi
            // 
            this.toolTipPosudi.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipPosudi.ToolTipTitle = "Posudi";
            // 
            // toolTipVrati
            // 
            this.toolTipVrati.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipVrati.ToolTipTitle = "Vrati";
            // 
            // btnSpajanje
            // 
            this.btnSpajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpajanje.Location = new System.Drawing.Point(781, 202);
            this.btnSpajanje.Name = "btnSpajanje";
            this.btnSpajanje.Size = new System.Drawing.Size(155, 49);
            this.btnSpajanje.TabIndex = 5;
            this.btnSpajanje.Text = "SPAJANJE";
            this.toolTipSpajanje.SetToolTip(this.btnSpajanje, "Kliknite kao biste uspostavili konekciju sa bazom!");
            this.btnSpajanje.UseVisualStyleBackColor = true;
            this.btnSpajanje.Click += new System.EventHandler(this.btnSpajanje_Click);
            // 
            // btnOdspoji
            // 
            this.btnOdspoji.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdspoji.Location = new System.Drawing.Point(991, 202);
            this.btnOdspoji.Name = "btnOdspoji";
            this.btnOdspoji.Size = new System.Drawing.Size(177, 49);
            this.btnOdspoji.TabIndex = 6;
            this.btnOdspoji.Text = "ODSPAJANJE";
            this.btnOdspoji.UseVisualStyleBackColor = true;
            this.btnOdspoji.Click += new System.EventHandler(this.btnOdspoji_Click);
            // 
            // toolTipSpajanje
            // 
            this.toolTipSpajanje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipSpajanje.ToolTipTitle = "Spajanje na bazu";
            // 
            // btnAzur
            // 
            this.btnAzur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAzur.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzur.Location = new System.Drawing.Point(716, 329);
            this.btnAzur.Name = "btnAzur";
            this.btnAzur.Size = new System.Drawing.Size(485, 66);
            this.btnAzur.TabIndex = 7;
            this.btnAzur.Text = "Ažurirajte pregled podataka";
            this.btnAzur.UseVisualStyleBackColor = false;
            this.btnAzur.Click += new System.EventHandler(this.btnAzur_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 431);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1237, 256);
            this.dataGridView.TabIndex = 8;
            // 
            // groupBoxPretraga
            // 
            this.groupBoxPretraga.Controls.Add(this.labelPretraga);
            this.groupBoxPretraga.Controls.Add(this.comboBoxPretraga);
            this.groupBoxPretraga.Controls.Add(this.txtPretraga);
            this.groupBoxPretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.groupBoxPretraga.Location = new System.Drawing.Point(23, 312);
            this.groupBoxPretraga.Name = "groupBoxPretraga";
            this.groupBoxPretraga.Size = new System.Drawing.Size(576, 103);
            this.groupBoxPretraga.TabIndex = 9;
            this.groupBoxPretraga.TabStop = false;
            this.groupBoxPretraga.Text = "PRETRAGA";
            // 
            // labelPretraga
            // 
            this.labelPretraga.AutoSize = true;
            this.labelPretraga.Location = new System.Drawing.Point(395, 19);
            this.labelPretraga.Name = "labelPretraga";
            this.labelPretraga.Size = new System.Drawing.Size(74, 15);
            this.labelPretraga.TabIndex = 2;
            this.labelPretraga.Text = "Pretraga po:";
            // 
            // comboBoxPretraga
            // 
            this.comboBoxPretraga.FormattingEnabled = true;
            this.comboBoxPretraga.Location = new System.Drawing.Point(387, 47);
            this.comboBoxPretraga.Name = "comboBoxPretraga";
            this.comboBoxPretraga.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPretraga.TabIndex = 1;
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(15, 47);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(323, 20);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.urediToolStripMenuItem,
            this.izgledToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1261, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spajanjeSBazomToolStripMenuItem,
            this.odspojiToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // spajanjeSBazomToolStripMenuItem
            // 
            this.spajanjeSBazomToolStripMenuItem.Name = "spajanjeSBazomToolStripMenuItem";
            this.spajanjeSBazomToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.spajanjeSBazomToolStripMenuItem.Text = "Spajanje s bazom";
            this.spajanjeSBazomToolStripMenuItem.Click += new System.EventHandler(this.spajanjeSBazomToolStripMenuItem_Click);
            // 
            // odspojiToolStripMenuItem
            // 
            this.odspojiToolStripMenuItem.Name = "odspojiToolStripMenuItem";
            this.odspojiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.odspojiToolStripMenuItem.Text = "Odspoji";
            this.odspojiToolStripMenuItem.Click += new System.EventHandler(this.odspojiToolStripMenuItem_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // urediToolStripMenuItem
            // 
            this.urediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.izmjeniToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this.urediToolStripMenuItem.Name = "urediToolStripMenuItem";
            this.urediToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.urediToolStripMenuItem.Text = "Uredi";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // izmjeniToolStripMenuItem
            // 
            this.izmjeniToolStripMenuItem.Name = "izmjeniToolStripMenuItem";
            this.izmjeniToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.izmjeniToolStripMenuItem.Text = "Izmjeni";
            this.izmjeniToolStripMenuItem.Click += new System.EventHandler(this.izmjeniToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // izgledToolStripMenuItem
            // 
            this.izgledToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bojaPozadineToolStripMenuItem});
            this.izgledToolStripMenuItem.Name = "izgledToolStripMenuItem";
            this.izgledToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.izgledToolStripMenuItem.Text = "Izgled";
            // 
            // bojaPozadineToolStripMenuItem
            // 
            this.bojaPozadineToolStripMenuItem.Name = "bojaPozadineToolStripMenuItem";
            this.bojaPozadineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.bojaPozadineToolStripMenuItem.Text = "Boja pozadine";
            this.bojaPozadineToolStripMenuItem.Click += new System.EventHandler(this.bojaPozadineToolStripMenuItem_Click);
            // 
            // btnCisti
            // 
            this.btnCisti.Location = new System.Drawing.Point(159, 273);
            this.btnCisti.Name = "btnCisti";
            this.btnCisti.Size = new System.Drawing.Size(75, 23);
            this.btnCisti.TabIndex = 11;
            this.btnCisti.Text = "Očisti";
            this.btnCisti.UseVisualStyleBackColor = true;
            this.btnCisti.Click += new System.EventHandler(this.btnCisti_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(924, 273);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 12;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // knjiznicaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 699);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCisti);
            this.Controls.Add(this.groupBoxPretraga);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnAzur);
            this.Controls.Add(this.btnOdspoji);
            this.Controls.Add(this.btnSpajanje);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "knjiznicaMainForm";
            this.Text = "Knjižnica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.knjiznicaMainForm_FormClosing);
            this.Load += new System.EventHandler(this.knjiznicaMainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoxPretraga.ResumeLayout(false);
            this.groupBoxPretraga.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtKnjiga;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelIzdavac;
        private System.Windows.Forms.Label labelGod;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelKnjiga;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPosudio;
        private System.Windows.Forms.Label labelPosudio;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.ToolTip toolTipDodaj;
        private System.Windows.Forms.ToolTip toolTipUredi;
        private System.Windows.Forms.ToolTip toolTipObrisi;
        private System.Windows.Forms.ToolTip toolTipPosudi;
        private System.Windows.Forms.ToolTip toolTipVrati;
        private System.Windows.Forms.Button btnSpajanje;
        private System.Windows.Forms.ToolTip toolTipSpajanje;
        private System.Windows.Forms.Button btnOdspoji;
        private System.Windows.Forms.Button btnAzur;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBoxPretraga;
        private System.Windows.Forms.Label labelPretraga;
        private System.Windows.Forms.ComboBox comboBoxPretraga;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spajanjeSBazomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odspojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izgledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bojaPozadineToolStripMenuItem;
        private System.Windows.Forms.Button btnCisti;
        private System.Windows.Forms.Button btnLog;
    }
}

