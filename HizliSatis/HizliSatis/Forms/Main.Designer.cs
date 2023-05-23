namespace HizliSatis.Forms
{
    partial class Main
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
            this.salesButton = new System.Windows.Forms.Button();
            this.stokButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.tedarikciButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salesButton
            // 
            this.salesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesButton.Location = new System.Drawing.Point(12, 12);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(200, 150);
            this.salesButton.TabIndex = 0;
            this.salesButton.Text = "SATIŞ";
            this.salesButton.UseVisualStyleBackColor = true;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // stokButton
            // 
            this.stokButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stokButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokButton.Location = new System.Drawing.Point(218, 12);
            this.stokButton.Name = "stokButton";
            this.stokButton.Size = new System.Drawing.Size(200, 150);
            this.stokButton.TabIndex = 1;
            this.stokButton.Text = "STOK";
            this.stokButton.UseVisualStyleBackColor = true;
            this.stokButton.Click += new System.EventHandler(this.stokButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Enabled = false;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerButton.Location = new System.Drawing.Point(12, 168);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(200, 150);
            this.customerButton.TabIndex = 2;
            this.customerButton.Text = "MÜŞTERİ";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // tedarikciButton
            // 
            this.tedarikciButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tedarikciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tedarikciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tedarikciButton.Location = new System.Drawing.Point(218, 168);
            this.tedarikciButton.Name = "tedarikciButton";
            this.tedarikciButton.Size = new System.Drawing.Size(200, 150);
            this.tedarikciButton.TabIndex = 3;
            this.tedarikciButton.Text = "TEDARİKÇİ";
            this.tedarikciButton.UseVisualStyleBackColor = true;
            this.tedarikciButton.Click += new System.EventHandler(this.tedarikciButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportButton.Location = new System.Drawing.Point(12, 324);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(200, 150);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "RAPOR";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.settingsButton.Location = new System.Drawing.Point(218, 324);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(200, 150);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "AYARLAR";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 481);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.tedarikciButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.stokButton);
            this.Controls.Add(this.salesButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button stokButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button tedarikciButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button settingsButton;
    }
}