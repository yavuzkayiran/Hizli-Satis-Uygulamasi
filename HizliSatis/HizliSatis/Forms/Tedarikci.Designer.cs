namespace HizliSatis.Forms
{
    partial class Tedarikci
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tedarikciGridView = new System.Windows.Forms.DataGridView();
            this.ticariUnvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.menuGuncelleButton = new System.Windows.Forms.Button();
            this.menuEkleButton = new System.Windows.Forms.Button();
            this.menuSilButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.musteriSilButton = new System.Windows.Forms.Button();
            this.musteriEkleButton = new System.Windows.Forms.Button();
            this.musteriGuncelleButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iletisimTipEkleButton = new System.Windows.Forms.Button();
            this.iletisimTipComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yetkiliAdiText = new System.Windows.Forms.TextBox();
            this.ticariUnvanText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tedarikciGridView);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 450);
            this.panel2.TabIndex = 10;
            // 
            // tedarikciGridView
            // 
            this.tedarikciGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tedarikciGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tedarikciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tedarikciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticariUnvan,
            this.yetkili});
            this.tedarikciGridView.Location = new System.Drawing.Point(0, 50);
            this.tedarikciGridView.Name = "tedarikciGridView";
            this.tedarikciGridView.RowHeadersVisible = false;
            this.tedarikciGridView.Size = new System.Drawing.Size(578, 401);
            this.tedarikciGridView.TabIndex = 0;
            this.tedarikciGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedarikciGridView_CellClick);
            this.tedarikciGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tedarikciGridView_CellContentClick);
            // 
            // ticariUnvan
            // 
            this.ticariUnvan.HeaderText = "Ticari Ünvan";
            this.ticariUnvan.Name = "ticariUnvan";
            // 
            // yetkili
            // 
            this.yetkili.HeaderText = "Yetkili";
            this.yetkili.Name = "yetkili";
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
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Location = new System.Drawing.Point(6, 19);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(485, 20);
            this.searchText.TabIndex = 1;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
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
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.yetkiliAdiText);
            this.panel3.Controls.Add(this.ticariUnvanText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(701, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 450);
            this.panel3.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.musteriSilButton);
            this.panel6.Controls.Add(this.musteriEkleButton);
            this.panel6.Controls.Add(this.musteriGuncelleButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 409);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 39);
            this.panel6.TabIndex = 25;
            // 
            // musteriSilButton
            // 
            this.musteriSilButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriSilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.musteriSilButton.Location = new System.Drawing.Point(4, 3);
            this.musteriSilButton.Name = "musteriSilButton";
            this.musteriSilButton.Size = new System.Drawing.Size(249, 33);
            this.musteriSilButton.TabIndex = 23;
            this.musteriSilButton.Tag = "delete";
            this.musteriSilButton.Text = "Sil";
            this.musteriSilButton.UseVisualStyleBackColor = true;
            this.musteriSilButton.Click += new System.EventHandler(this.musteriSilButton_Click);
            // 
            // musteriEkleButton
            // 
            this.musteriEkleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.musteriEkleButton.Location = new System.Drawing.Point(4, 3);
            this.musteriEkleButton.Name = "musteriEkleButton";
            this.musteriEkleButton.Size = new System.Drawing.Size(249, 33);
            this.musteriEkleButton.TabIndex = 21;
            this.musteriEkleButton.Tag = "add";
            this.musteriEkleButton.Text = "Ekle";
            this.musteriEkleButton.UseVisualStyleBackColor = true;
            this.musteriEkleButton.Click += new System.EventHandler(this.musteriEkleButton_Click);
            // 
            // musteriGuncelleButton
            // 
            this.musteriGuncelleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriGuncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.musteriGuncelleButton.Location = new System.Drawing.Point(4, 3);
            this.musteriGuncelleButton.Name = "musteriGuncelleButton";
            this.musteriGuncelleButton.Size = new System.Drawing.Size(249, 33);
            this.musteriGuncelleButton.TabIndex = 22;
            this.musteriGuncelleButton.Tag = "update";
            this.musteriGuncelleButton.Text = "Güncelle";
            this.musteriGuncelleButton.UseVisualStyleBackColor = true;
            this.musteriGuncelleButton.Click += new System.EventHandler(this.musteriGuncelleButton_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Controls.Add(this.iletisimTipEkleButton);
            this.panel5.Controls.Add(this.iletisimTipComboBox);
            this.panel5.Location = new System.Drawing.Point(-1, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 319);
            this.panel5.TabIndex = 11;
            // 
            // iletisimTipEkleButton
            // 
            this.iletisimTipEkleButton.BackgroundImage = global::HizliSatis.Properties.Resources.add;
            this.iletisimTipEkleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iletisimTipEkleButton.Location = new System.Drawing.Point(199, 3);
            this.iletisimTipEkleButton.Name = "iletisimTipEkleButton";
            this.iletisimTipEkleButton.Size = new System.Drawing.Size(31, 31);
            this.iletisimTipEkleButton.TabIndex = 24;
            this.iletisimTipEkleButton.UseVisualStyleBackColor = true;
            this.iletisimTipEkleButton.Click += new System.EventHandler(this.iletisimTipEkleButton_Click);
            // 
            // iletisimTipComboBox
            // 
            this.iletisimTipComboBox.FormattingEnabled = true;
            this.iletisimTipComboBox.Location = new System.Drawing.Point(4, 9);
            this.iletisimTipComboBox.Name = "iletisimTipComboBox";
            this.iletisimTipComboBox.Size = new System.Drawing.Size(190, 21);
            this.iletisimTipComboBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Yetkili:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticari Ünvan:";
            // 
            // yetkiliAdiText
            // 
            this.yetkiliAdiText.Location = new System.Drawing.Point(89, 46);
            this.yetkiliAdiText.Name = "yetkiliAdiText";
            this.yetkiliAdiText.Size = new System.Drawing.Size(150, 20);
            this.yetkiliAdiText.TabIndex = 1;
            // 
            // ticariUnvanText
            // 
            this.ticariUnvanText.Location = new System.Drawing.Point(89, 16);
            this.ticariUnvanText.Name = "ticariUnvanText";
            this.ticariUnvanText.Size = new System.Drawing.Size(150, 20);
            this.ticariUnvanText.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.menuGuncelleButton);
            this.panel1.Controls.Add(this.menuEkleButton);
            this.panel1.Controls.Add(this.menuSilButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 450);
            this.panel1.TabIndex = 9;
            // 
            // Tedarikci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(950, 450);
            this.Name = "Tedarikci";
            this.Text = "Tedarikci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Tedarikci_Load);
            this.Resize += new System.EventHandler(this.Tedarikci_Resize);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikciGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tedarikciGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button menuGuncelleButton;
        private System.Windows.Forms.Button menuEkleButton;
        private System.Windows.Forms.Button menuSilButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yetkiliAdiText;
        private System.Windows.Forms.TextBox ticariUnvanText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticariUnvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkili;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox iletisimTipComboBox;
        private System.Windows.Forms.Button iletisimTipEkleButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button musteriSilButton;
        private System.Windows.Forms.Button musteriEkleButton;
        private System.Windows.Forms.Button musteriGuncelleButton;
    }
}