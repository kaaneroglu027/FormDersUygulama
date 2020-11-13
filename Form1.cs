using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersUygulama
{
    public partial class Form1 : Form
    {
        static int toplam = 0;
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            btnsayi1.Text = rnd.Next(100).ToString();
            btnsayi2.Text = rnd.Next(100).ToString();
            btnsayi3.Text = rnd.Next(100).ToString();
            btnsayi2.Click += NumberClick;
            btnsayi3.Click += NumberClick;
            

            

        }

        void NumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            toplam += int.Parse(btn.Text);
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"sayıların toplamını göster:{toplam}");

        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tmrbutton.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
