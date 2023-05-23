using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis.Forms
{
    public partial class Camera : Form
    {
        public Camera()
        {
            InitializeComponent();
        }

        private FilterInfoCollection webcam;//webcam isminde tanımladığımız değişken bilgisayara kaç kamera bağlıysa onları tutan bir dizi. 
        private VideoCaptureDevice cam;//cam ise bizim kullanacağımız aygıt.

        private void Camera_Load(object sender, EventArgs e)
        {
           
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);//webcam dizisine mevcut kameraları dolduruyoruz.
            foreach (FilterInfo videocapturedevice in webcam)
            {
                CameraListCmb.Items.Add(videocapturedevice.Name);//kameraları combobox a dolduruyoruz.
            }
            if (CameraListCmb.Items.Count > 0)
            {
                CameraListCmb.SelectedIndex = 0; //Comboboxtaki ilk index numaralı kameranın ekranda görünmesi için
            }
            cam = new VideoCaptureDevice(webcam[CameraListCmb.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);//bu kisimda using .... video kütüphanesi eklenmelidir 
            cam.Start();
        }
        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }

        private void ImageCapture_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning) //kamera açıksa kapatıyoruz.
            {
                pictureBox2.Image = pictureBox1.Image;
                cam.Stop();
                ImageCapture.Text = "Kamerayı Aç";
                pictureBox1.SendToBack();
            }
            else
            {
                ImageCapture.Text = "Resim Çek";
                cam.Start();
                pictureBox2.Image = null;
                pictureBox2.SendToBack();
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                if (cam.IsRunning) //kamera açıksa kapatıyoruz.
                {
                    cam.Stop();
                }
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Kameradan çıkmak istediğinizden emin misiniz?" +
                    " Resim Çekmediniz.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (cam.IsRunning) //kamera açıksa kapatıyoruz.
                    {
                        cam.Stop();
                    }
                    this.Close();
                }
            }
        }

        private void CameraListCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!cam.IsRunning) //kamera açıksa kapatıyoruz.
                {
                    cam = new VideoCaptureDevice(webcam[CameraListCmb.SelectedIndex].MonikerString);
                    cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);//bu kisimda using .... video kütüphanesi eklenmelidir 
                    cam.Start();
                    pictureBox2.Image = null;
                    pictureBox2.SendToBack();
                }
                
            }
            catch (Exception)
            {
            }

        }

        private void Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning) //kamera açıksa kapatıyoruz.
            {
                cam.Stop();
            }
          
        }
    }
}