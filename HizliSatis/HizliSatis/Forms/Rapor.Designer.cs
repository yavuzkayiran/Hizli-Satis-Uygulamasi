namespace HizliSatis.Forms
{
    partial class Rapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.gosterilecekUrunSayisi = new System.Windows.Forms.NumericUpDown();
            this.labelKg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gosterilecekUrunSayisi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 83);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.Red};
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series5.IsValueShownAsLabel = true;
            series5.LabelBorderWidth = 0;
            series5.Legend = "Legend1";
            series5.Name = "SATIS";
            series5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "INDIRIMSIZ";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1024, 503);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "RAPORLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Toplam Satış",
            "En Çok Satılan Ürünler"});
            this.comboBox1.Location = new System.Drawing.Point(27, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Rapor Türü Seçiniz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.CustomFormat = "yyyy-MM-dd";
            this.baslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.baslangicTarihi.Location = new System.Drawing.Point(27, 57);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(150, 20);
            this.baslangicTarihi.TabIndex = 3;
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.CustomFormat = "yyyy-MM-dd";
            this.bitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bitisTarihi.Location = new System.Drawing.Point(195, 57);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(150, 20);
            this.bitisTarihi.TabIndex = 4;
            // 
            // gosterilecekUrunSayisi
            // 
            this.gosterilecekUrunSayisi.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gosterilecekUrunSayisi.Location = new System.Drawing.Point(223, 12);
            this.gosterilecekUrunSayisi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.gosterilecekUrunSayisi.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gosterilecekUrunSayisi.Name = "gosterilecekUrunSayisi";
            this.gosterilecekUrunSayisi.Size = new System.Drawing.Size(120, 20);
            this.gosterilecekUrunSayisi.TabIndex = 5;
            this.gosterilecekUrunSayisi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.gosterilecekUrunSayisi.Visible = false;
            // 
            // labelKg
            // 
            this.labelKg.AutoSize = true;
            this.labelKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKg.Location = new System.Drawing.Point(9, 14);
            this.labelKg.Name = "labelKg";
            this.labelKg.Size = new System.Drawing.Size(59, 20);
            this.labelKg.TabIndex = 6;
            this.labelKg.Text = "00000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gr";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelKg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(451, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 49);
            this.panel1.TabIndex = 8;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gosterilecekUrunSayisi);
            this.Controls.Add(this.bitisTarihi);
            this.Controls.Add(this.baslangicTarihi);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "Rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.Resize += new System.EventHandler(this.Rapor_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gosterilecekUrunSayisi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker baslangicTarihi;
        private System.Windows.Forms.DateTimePicker bitisTarihi;
        private System.Windows.Forms.NumericUpDown gosterilecekUrunSayisi;
        private System.Windows.Forms.Label labelKg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}