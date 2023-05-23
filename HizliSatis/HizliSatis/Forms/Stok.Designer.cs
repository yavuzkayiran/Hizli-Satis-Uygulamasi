namespace HizliSatis.Forms
{
    partial class Stok
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuGuncelleButton = new System.Windows.Forms.Button();
            this.menuEkleButton = new System.Windows.Forms.Button();
            this.menuSilButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stokGridView = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tedarikci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Skt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.barkodRadio = new System.Windows.Forms.RadioButton();
            this.urunNameRadio = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.satisFiyatiText = new System.Windows.Forms.TextBox();
            this.adetFiyatiText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toplamMiktarText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.birimAdetText = new System.Windows.Forms.TextBox();
            this.stokSilButton = new System.Windows.Forms.Button();
            this.stokGuncelleButton = new System.Windows.Forms.Button();
            this.stokEkleButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.captureImageButton = new System.Windows.Forms.Button();
            this.stokImagePictureBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.birimCombo = new System.Windows.Forms.ComboBox();
            this.tedarikciCombo = new System.Windows.Forms.ComboBox();
            this.sktDate = new System.Windows.Forms.DateTimePicker();
            this.birimFiyatText = new System.Windows.Forms.TextBox();
            this.kdvText = new System.Windows.Forms.TextBox();
            this.miktarText = new System.Windows.Forms.TextBox();
            this.urunAdiText = new System.Windows.Forms.TextBox();
            this.barkodText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuGuncelleButton);
            this.panel1.Controls.Add(this.menuEkleButton);
            this.panel1.Controls.Add(this.menuSilButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 461);
            this.panel1.TabIndex = 0;
            // 
            // menuGuncelleButton
            // 
            this.menuGuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuGuncelleButton.Location = new System.Drawing.Point(5, 151);
            this.menuGuncelleButton.Name = "menuGuncelleButton";
            this.menuGuncelleButton.Size = new System.Drawing.Size(105, 127);
            this.menuGuncelleButton.TabIndex = 3;
            this.menuGuncelleButton.Tag = "update";
            this.menuGuncelleButton.Text = "Güncelle";
            this.menuGuncelleButton.UseVisualStyleBackColor = true;
            this.menuGuncelleButton.Click += new System.EventHandler(this.menuButtonsPress);
            // 
            // menuEkleButton
            // 
            this.menuEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuEkleButton.Location = new System.Drawing.Point(5, 18);
            this.menuEkleButton.Name = "menuEkleButton";
            this.menuEkleButton.Size = new System.Drawing.Size(105, 127);
            this.menuEkleButton.TabIndex = 2;
            this.menuEkleButton.Tag = "add";
            this.menuEkleButton.Text = "Ekle";
            this.menuEkleButton.UseVisualStyleBackColor = true;
            this.menuEkleButton.Click += new System.EventHandler(this.menuButtonsPress);
            // 
            // menuSilButton
            // 
            this.menuSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuSilButton.Location = new System.Drawing.Point(5, 284);
            this.menuSilButton.Name = "menuSilButton";
            this.menuSilButton.Size = new System.Drawing.Size(105, 127);
            this.menuSilButton.TabIndex = 4;
            this.menuSilButton.Tag = "delete";
            this.menuSilButton.Text = "Sil";
            this.menuSilButton.UseVisualStyleBackColor = true;
            this.menuSilButton.Click += new System.EventHandler(this.menuButtonsPress);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.stokGridView);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(115, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 450);
            this.panel2.TabIndex = 1;
            // 
            // stokGridView
            // 
            this.stokGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stokGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.Barkod,
            this.UrunAdi,
            this.Tedarikci,
            this.Skt,
            this.Birim,
            this.Miktar,
            this.birimAdet,
            this.toplamMiktar,
            this.BirimFiyat,
            this.adetFiyat,
            this.Kdv,
            this.satisFiy});
            this.stokGridView.Location = new System.Drawing.Point(0, 50);
            this.stokGridView.Name = "stokGridView";
            this.stokGridView.RowHeadersVisible = false;
            this.stokGridView.Size = new System.Drawing.Size(578, 401);
            this.stokGridView.TabIndex = 0;
            this.stokGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokGridView_CellClick);
            this.stokGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokGridView_CellContentClick);
            // 
            // image
            // 
            this.image.FillWeight = 40.37056F;
            this.image.HeaderText = "Resim";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Barkod
            // 
            this.Barkod.HeaderText = "Barkod No";
            this.Barkod.Name = "Barkod";
            // 
            // UrunAdi
            // 
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // Tedarikci
            // 
            this.Tedarikci.HeaderText = "Tedarikçi";
            this.Tedarikci.Name = "Tedarikci";
            // 
            // Skt
            // 
            this.Skt.HeaderText = "SKT";
            this.Skt.Name = "Skt";
            // 
            // Birim
            // 
            this.Birim.HeaderText = "Birimi";
            this.Birim.Name = "Birim";
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "Birim Miktarı";
            this.Miktar.Name = "Miktar";
            // 
            // birimAdet
            // 
            this.birimAdet.HeaderText = "Birim Adet";
            this.birimAdet.Name = "birimAdet";
            // 
            // toplamMiktar
            // 
            this.toplamMiktar.HeaderText = "Toplam Miktar";
            this.toplamMiktar.Name = "toplamMiktar";
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.HeaderText = "Birim Fiyatı";
            this.BirimFiyat.Name = "BirimFiyat";
            // 
            // adetFiyat
            // 
            this.adetFiyat.HeaderText = "Adet Fiyat";
            this.adetFiyat.Name = "adetFiyat";
            // 
            // Kdv
            // 
            this.Kdv.HeaderText = "KDV";
            this.Kdv.Name = "Kdv";
            // 
            // satisFiy
            // 
            this.satisFiy.HeaderText = "Satış Fiyatı";
            this.satisFiy.Name = "satisFiy";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 50);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Controls.Add(this.barkodRadio);
            this.groupBox1.Controls.Add(this.urunNameRadio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(497, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Ara";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Location = new System.Drawing.Point(172, 19);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(319, 20);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // barkodRadio
            // 
            this.barkodRadio.AutoSize = true;
            this.barkodRadio.Checked = true;
            this.barkodRadio.Location = new System.Drawing.Point(6, 15);
            this.barkodRadio.Name = "barkodRadio";
            this.barkodRadio.Size = new System.Drawing.Size(144, 17);
            this.barkodRadio.TabIndex = 0;
            this.barkodRadio.TabStop = true;
            this.barkodRadio.Text = "Barkod Numarasına Göre";
            this.barkodRadio.UseVisualStyleBackColor = true;
            this.barkodRadio.CheckedChanged += new System.EventHandler(this.barkodRadio_CheckedChanged);
            // 
            // urunNameRadio
            // 
            this.urunNameRadio.AutoSize = true;
            this.urunNameRadio.Location = new System.Drawing.Point(6, 30);
            this.urunNameRadio.Name = "urunNameRadio";
            this.urunNameRadio.Size = new System.Drawing.Size(104, 17);
            this.urunNameRadio.TabIndex = 0;
            this.urunNameRadio.Text = "Ürün Adına Göre";
            this.urunNameRadio.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.satisFiyatiText);
            this.panel3.Controls.Add(this.adetFiyatiText);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.toplamMiktarText);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.birimAdetText);
            this.panel3.Controls.Add(this.stokSilButton);
            this.panel3.Controls.Add(this.stokGuncelleButton);
            this.panel3.Controls.Add(this.stokEkleButton);
            this.panel3.Controls.Add(this.loadImageButton);
            this.panel3.Controls.Add(this.captureImageButton);
            this.panel3.Controls.Add(this.stokImagePictureBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.birimCombo);
            this.panel3.Controls.Add(this.tedarikciCombo);
            this.panel3.Controls.Add(this.sktDate);
            this.panel3.Controls.Add(this.birimFiyatText);
            this.panel3.Controls.Add(this.kdvText);
            this.panel3.Controls.Add(this.miktarText);
            this.panel3.Controls.Add(this.urunAdiText);
            this.panel3.Controls.Add(this.barkodText);
            this.panel3.Location = new System.Drawing.Point(701, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 461);
            this.panel3.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 395);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Satış Fiyatı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Adet Fiyatı:";
            // 
            // satisFiyatiText
            // 
            this.satisFiyatiText.Location = new System.Drawing.Point(90, 392);
            this.satisFiyatiText.Name = "satisFiyatiText";
            this.satisFiyatiText.Size = new System.Drawing.Size(150, 20);
            this.satisFiyatiText.TabIndex = 15;
            this.satisFiyatiText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.satisFiyatiText_KeyPress);
            // 
            // adetFiyatiText
            // 
            this.adetFiyatiText.Enabled = false;
            this.adetFiyatiText.Location = new System.Drawing.Point(90, 261);
            this.adetFiyatiText.Name = "adetFiyatiText";
            this.adetFiyatiText.Size = new System.Drawing.Size(150, 20);
            this.adetFiyatiText.TabIndex = 16;
            this.adetFiyatiText.Text = "1";
            this.adetFiyatiText.TextChanged += new System.EventHandler(this.textFiled_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Toplam Miktar:";
            // 
            // toplamMiktarText
            // 
            this.toplamMiktarText.Enabled = false;
            this.toplamMiktarText.Location = new System.Drawing.Point(90, 313);
            this.toplamMiktarText.Name = "toplamMiktarText";
            this.toplamMiktarText.Size = new System.Drawing.Size(150, 20);
            this.toplamMiktarText.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Birim Adet:";
            // 
            // birimAdetText
            // 
            this.birimAdetText.Enabled = false;
            this.birimAdetText.Location = new System.Drawing.Point(90, 287);
            this.birimAdetText.Name = "birimAdetText";
            this.birimAdetText.Size = new System.Drawing.Size(150, 20);
            this.birimAdetText.TabIndex = 11;
            // 
            // stokSilButton
            // 
            this.stokSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stokSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokSilButton.Location = new System.Drawing.Point(6, 415);
            this.stokSilButton.Name = "stokSilButton";
            this.stokSilButton.Size = new System.Drawing.Size(240, 30);
            this.stokSilButton.TabIndex = 10;
            this.stokSilButton.Tag = "delete";
            this.stokSilButton.Text = "Sil";
            this.stokSilButton.UseVisualStyleBackColor = true;
            this.stokSilButton.Click += new System.EventHandler(this.stokSilButton_Click);
            // 
            // stokGuncelleButton
            // 
            this.stokGuncelleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stokGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokGuncelleButton.Location = new System.Drawing.Point(6, 415);
            this.stokGuncelleButton.Name = "stokGuncelleButton";
            this.stokGuncelleButton.Size = new System.Drawing.Size(240, 30);
            this.stokGuncelleButton.TabIndex = 9;
            this.stokGuncelleButton.Tag = "update";
            this.stokGuncelleButton.Text = "Güncelle";
            this.stokGuncelleButton.UseVisualStyleBackColor = true;
            this.stokGuncelleButton.Click += new System.EventHandler(this.stokGuncelleButton_Click);
            // 
            // stokEkleButton
            // 
            this.stokEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stokEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokEkleButton.Location = new System.Drawing.Point(6, 415);
            this.stokEkleButton.Name = "stokEkleButton";
            this.stokEkleButton.Size = new System.Drawing.Size(240, 30);
            this.stokEkleButton.TabIndex = 8;
            this.stokEkleButton.Tag = "add";
            this.stokEkleButton.Text = "Ekle";
            this.stokEkleButton.UseVisualStyleBackColor = true;
            this.stokEkleButton.Click += new System.EventHandler(this.stokEkleButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Image = global::HizliSatis.Properties.Resources.folder_open;
            this.loadImageButton.Location = new System.Drawing.Point(165, 59);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(75, 38);
            this.loadImageButton.TabIndex = 7;
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // captureImageButton
            // 
            this.captureImageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.captureImageButton.Image = global::HizliSatis.Properties.Resources.camera;
            this.captureImageButton.Location = new System.Drawing.Point(165, 10);
            this.captureImageButton.Name = "captureImageButton";
            this.captureImageButton.Size = new System.Drawing.Size(75, 36);
            this.captureImageButton.TabIndex = 6;
            this.captureImageButton.UseVisualStyleBackColor = true;
            this.captureImageButton.Click += new System.EventHandler(this.captureImageButton_Click);
            // 
            // stokImagePictureBox
            // 
            this.stokImagePictureBox.ErrorImage = global::HizliSatis.Properties.Resources.image;
            this.stokImagePictureBox.Image = global::HizliSatis.Properties.Resources.image;
            this.stokImagePictureBox.InitialImage = global::HizliSatis.Properties.Resources.image;
            this.stokImagePictureBox.Location = new System.Drawing.Point(6, 10);
            this.stokImagePictureBox.Name = "stokImagePictureBox";
            this.stokImagePictureBox.Size = new System.Drawing.Size(139, 87);
            this.stokImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stokImagePictureBox.TabIndex = 5;
            this.stokImagePictureBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Birim Fiyatı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "KDV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Son Kull. Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tedarikçi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Barkod No:";
            // 
            // birimCombo
            // 
            this.birimCombo.FormattingEnabled = true;
            this.birimCombo.Location = new System.Drawing.Point(90, 208);
            this.birimCombo.Name = "birimCombo";
            this.birimCombo.Size = new System.Drawing.Size(150, 21);
            this.birimCombo.TabIndex = 3;
            this.birimCombo.SelectedIndexChanged += new System.EventHandler(this.birimCombo_SelectedIndexChanged);
            // 
            // tedarikciCombo
            // 
            this.tedarikciCombo.FormattingEnabled = true;
            this.tedarikciCombo.Location = new System.Drawing.Point(90, 155);
            this.tedarikciCombo.Name = "tedarikciCombo";
            this.tedarikciCombo.Size = new System.Drawing.Size(150, 21);
            this.tedarikciCombo.TabIndex = 3;
            // 
            // sktDate
            // 
            this.sktDate.CustomFormat = "yyyy-MM-dd";
            this.sktDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sktDate.Location = new System.Drawing.Point(90, 182);
            this.sktDate.Name = "sktDate";
            this.sktDate.Size = new System.Drawing.Size(150, 20);
            this.sktDate.TabIndex = 2;
            // 
            // birimFiyatText
            // 
            this.birimFiyatText.Enabled = false;
            this.birimFiyatText.Location = new System.Drawing.Point(90, 339);
            this.birimFiyatText.Name = "birimFiyatText";
            this.birimFiyatText.Size = new System.Drawing.Size(150, 20);
            this.birimFiyatText.TabIndex = 1;
            // 
            // kdvText
            // 
            this.kdvText.Enabled = false;
            this.kdvText.Location = new System.Drawing.Point(90, 365);
            this.kdvText.Name = "kdvText";
            this.kdvText.Size = new System.Drawing.Size(150, 20);
            this.kdvText.TabIndex = 1;
            this.kdvText.Text = "8";
            // 
            // miktarText
            // 
            this.miktarText.Location = new System.Drawing.Point(90, 235);
            this.miktarText.Name = "miktarText";
            this.miktarText.Size = new System.Drawing.Size(150, 20);
            this.miktarText.TabIndex = 1;
            this.miktarText.TextChanged += new System.EventHandler(this.textFiled_TextChanged);
            this.miktarText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.miktarText_KeyPress);
            // 
            // urunAdiText
            // 
            this.urunAdiText.Location = new System.Drawing.Point(90, 129);
            this.urunAdiText.Name = "urunAdiText";
            this.urunAdiText.Size = new System.Drawing.Size(150, 20);
            this.urunAdiText.TabIndex = 10;
            this.urunAdiText.TextChanged += new System.EventHandler(this.urunAdiText_TextChanged);
            this.urunAdiText.Enter += new System.EventHandler(this.urunAdiText_Enter);
            // 
            // barkodText
            // 
            this.barkodText.Location = new System.Drawing.Point(90, 103);
            this.barkodText.Name = "barkodText";
            this.barkodText.Size = new System.Drawing.Size(150, 20);
            this.barkodText.TabIndex = 0;
            this.barkodText.TextChanged += new System.EventHandler(this.barkodText_TextChanged);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Stok";
            this.Text = "Stok";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stok_Load);
            this.Resize += new System.EventHandler(this.Stok_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stokGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView stokGridView;
        private System.Windows.Forms.Button menuEkleButton;
        private System.Windows.Forms.Button menuGuncelleButton;
        private System.Windows.Forms.Button menuSilButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.RadioButton barkodRadio;
        private System.Windows.Forms.RadioButton urunNameRadio;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button captureImageButton;
        private System.Windows.Forms.PictureBox stokImagePictureBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox birimCombo;
        private System.Windows.Forms.ComboBox tedarikciCombo;
        private System.Windows.Forms.DateTimePicker sktDate;
        private System.Windows.Forms.TextBox birimFiyatText;
        private System.Windows.Forms.TextBox kdvText;
        private System.Windows.Forms.TextBox miktarText;
        private System.Windows.Forms.TextBox urunAdiText;
        private System.Windows.Forms.TextBox barkodText;
        private System.Windows.Forms.Button stokSilButton;
        private System.Windows.Forms.Button stokGuncelleButton;
        private System.Windows.Forms.Button stokEkleButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox satisFiyatiText;
        private System.Windows.Forms.TextBox adetFiyatiText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox toplamMiktarText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox birimAdetText;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tedarikci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Skt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisFiy;
    }
}