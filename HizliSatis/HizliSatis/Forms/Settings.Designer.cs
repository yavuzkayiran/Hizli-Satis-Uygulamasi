namespace HizliSatis.Forms
{
    partial class Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stokGridView = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.urunRadio = new System.Windows.Forms.RadioButton();
            this.barkodRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.secilenUrunlerGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.secilenUrunLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StnsayisiNumber = new System.Windows.Forms.NumericUpDown();
            this.maxSecimSayisi = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secilenUrunlerGridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StnsayisiNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSecimSayisi)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(926, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hızlı Satış Ürünleri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.stokGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 475);
            this.panel1.TabIndex = 0;
            // 
            // stokGridView
            // 
            this.stokGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stokGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.Barkod,
            this.UrunAdi});
            this.stokGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stokGridView.Location = new System.Drawing.Point(0, 57);
            this.stokGridView.Name = "stokGridView";
            this.stokGridView.RowHeadersVisible = false;
            this.stokGridView.Size = new System.Drawing.Size(598, 418);
            this.stokGridView.TabIndex = 2;
            this.stokGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokGridView_CellClick);
            this.stokGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stokGridView_CellContentClick);
            // 
            // image
            // 
            this.image.FillWeight = 20.37056F;
            this.image.HeaderText = "Resim";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Barkod
            // 
            this.Barkod.FillWeight = 104.3147F;
            this.Barkod.HeaderText = "Barkod No";
            this.Barkod.Name = "Barkod";
            // 
            // UrunAdi
            // 
            this.UrunAdi.FillWeight = 104.3147F;
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.urunRadio);
            this.panel3.Controls.Add(this.barkodRadio);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 57);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(532, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ara";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // urunRadio
            // 
            this.urunRadio.AutoSize = true;
            this.urunRadio.Location = new System.Drawing.Point(11, 29);
            this.urunRadio.Name = "urunRadio";
            this.urunRadio.Size = new System.Drawing.Size(104, 17);
            this.urunRadio.TabIndex = 2;
            this.urunRadio.TabStop = true;
            this.urunRadio.Text = "Ürün Adına Göre";
            this.urunRadio.UseVisualStyleBackColor = true;
            // 
            // barkodRadio
            // 
            this.barkodRadio.AutoSize = true;
            this.barkodRadio.Checked = true;
            this.barkodRadio.Location = new System.Drawing.Point(11, 8);
            this.barkodRadio.Name = "barkodRadio";
            this.barkodRadio.Size = new System.Drawing.Size(150, 17);
            this.barkodRadio.TabIndex = 1;
            this.barkodRadio.TabStop = true;
            this.barkodRadio.Text = "Bardkod Numarasına Göre";
            this.barkodRadio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(167, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(598, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 475);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Controls.Add(this.secilenUrunlerGridView);
            this.panel5.Location = new System.Drawing.Point(0, 178);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 297);
            this.panel5.TabIndex = 5;
            // 
            // secilenUrunlerGridView
            // 
            this.secilenUrunlerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.secilenUrunlerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.secilenUrunlerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.secilenUrunlerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secilenUrunlerGridView.Location = new System.Drawing.Point(0, 0);
            this.secilenUrunlerGridView.Name = "secilenUrunlerGridView";
            this.secilenUrunlerGridView.RowHeadersVisible = false;
            this.secilenUrunlerGridView.Size = new System.Drawing.Size(325, 297);
            this.secilenUrunlerGridView.TabIndex = 3;
            this.secilenUrunlerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.secilenUrunlerGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Barkod No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ürün Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.secilenUrunLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.StnsayisiNumber);
            this.panel4.Controls.Add(this.maxSecimSayisi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 180);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hızlı Satış Sütun Sayısı:";
            // 
            // secilenUrunLabel
            // 
            this.secilenUrunLabel.AutoSize = true;
            this.secilenUrunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secilenUrunLabel.Location = new System.Drawing.Point(154, 44);
            this.secilenUrunLabel.Name = "secilenUrunLabel";
            this.secilenUrunLabel.Size = new System.Drawing.Size(19, 20);
            this.secilenUrunLabel.TabIndex = 3;
            this.secilenUrunLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seçilen Ürün Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hızlı Satış Ürün Sayısı:";
            // 
            // StnsayisiNumber
            // 
            this.StnsayisiNumber.Location = new System.Drawing.Point(158, 75);
            this.StnsayisiNumber.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.StnsayisiNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.StnsayisiNumber.Name = "StnsayisiNumber";
            this.StnsayisiNumber.Size = new System.Drawing.Size(59, 20);
            this.StnsayisiNumber.TabIndex = 0;
            this.StnsayisiNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.StnsayisiNumber.ValueChanged += new System.EventHandler(this.StnsayisiNumber_ValueChanged);
            // 
            // maxSecimSayisi
            // 
            this.maxSecimSayisi.Location = new System.Drawing.Point(158, 16);
            this.maxSecimSayisi.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.maxSecimSayisi.Name = "maxSecimSayisi";
            this.maxSecimSayisi.Size = new System.Drawing.Size(59, 20);
            this.maxSecimSayisi.TabIndex = 0;
            this.maxSecimSayisi.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.maxSecimSayisi.ValueChanged += new System.EventHandler(this.maxSecimSayisi_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 89);
            this.button2.TabIndex = 1;
            this.button2.Text = "Satış Sayfası Açıldığında Fiş Oluştur";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Kullanıcı Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 506);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stokGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secilenUrunlerGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StnsayisiNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSecimSayisi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown maxSecimSayisi;
        private System.Windows.Forms.DataGridView stokGridView;
        private System.Windows.Forms.Label secilenUrunLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView secilenUrunlerGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StnsayisiNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton urunRadio;
        private System.Windows.Forms.RadioButton barkodRadio;
        private System.Windows.Forms.Button button3;
    }
}