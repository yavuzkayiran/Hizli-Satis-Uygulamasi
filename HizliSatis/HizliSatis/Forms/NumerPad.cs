using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace HizliSatis.Forms
{
    public partial class NumerPad : Form
    {
        public NumerPad()
        {
            InitializeComponent();
        }
        private Boolean buttonDown=false,firstValue = true;
        private float adet;
        private Boolean cancel;

        public float Adet { get => adet; set => adet = value; }
        public bool Cancel { get => cancel; set => cancel = value; }

        private void buttonClick(object sender, EventArgs e)
        {
            if (label1.Text.Length < 4)
            {
                if (firstValue) { 
                    label1.Text = (sender as Button).Text;
                    firstValue = false;
                }
                else
                {
                    label1.Text += (sender as Button).Text;
                }
                 
            }
         

        }

        private void NumerPad_Load(object sender, EventArgs e)
        {
            label1.Width = this.Width - 20;
            Repeater(button11, 250);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clearLabelOperation();
                
        }


        private void clearLabelOperation()
        {
            if (label1.Text.Length != 1)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1);

            }
            else
            {
                label1.Text = "1";
                firstValue = true;
                buttonDown = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cancel = false;
            adet=float.Parse(label1.Text);
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        public void Repeater(Button btn, int interval)
        {
            var timer = new System.Windows.Forms.Timer { Interval = interval };
            timer.Tick += (sender, e) => clearLabelOperation();
            btn.MouseDown += (sender, e) => timer.Start();
            btn.MouseUp += (sender, e) => timer.Stop();
            btn.Disposed += (sender, e) =>
            {
                timer.Stop();
                timer.Dispose();
            };
        }
    }
}
