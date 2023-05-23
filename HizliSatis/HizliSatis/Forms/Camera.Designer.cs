namespace HizliSatis.Forms
{
    partial class Camera
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
            this.CameraListCmb = new System.Windows.Forms.ComboBox();
            this.ImageCapture = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CameraListCmb
            // 
            this.CameraListCmb.FormattingEnabled = true;
            this.CameraListCmb.Location = new System.Drawing.Point(247, 15);
            this.CameraListCmb.Name = "CameraListCmb";
            this.CameraListCmb.Size = new System.Drawing.Size(121, 21);
            this.CameraListCmb.TabIndex = 0;
            this.CameraListCmb.SelectedIndexChanged += new System.EventHandler(this.CameraListCmb_SelectedIndexChanged);
            // 
            // ImageCapture
            // 
            this.ImageCapture.Location = new System.Drawing.Point(247, 83);
            this.ImageCapture.Name = "ImageCapture";
            this.ImageCapture.Size = new System.Drawing.Size(121, 43);
            this.ImageCapture.TabIndex = 2;
            this.ImageCapture.Text = "Resim Çek";
            this.ImageCapture.UseVisualStyleBackColor = true;
            this.ImageCapture.Click += new System.EventHandler(this.ImageCapture_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(247, 148);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(121, 43);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "Onayla";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HizliSatis.Properties.Resources.image_landscape;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HizliSatis.Properties.Resources.image_landscape;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 179);
            this.panel1.TabIndex = 5;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 235);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.ImageCapture);
            this.Controls.Add(this.CameraListCmb);
            this.Name = "Camera";
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camera_FormClosing);
            this.Load += new System.EventHandler(this.Camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CameraListCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ImageCapture;
        private System.Windows.Forms.Button Ok;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}