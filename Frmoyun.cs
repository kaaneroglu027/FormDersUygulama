using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDersUygulama
{
    public partial class Frmoyun : Form
    {
        static int toplam = 0;
        static int sure = 60;
        Random rnd = new Random();
        public Frmoyun()
        {
            InitializeComponent();
        }

        private void tmrbutton_Tick(object sender, EventArgs e)
        {
           
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlgosterge.Width - btn.Width),rnd.Next(this.ClientSize.Height -
               btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);
            lblskor.Text = $"skor:{toplam}";
            btn.Dispose();
        }
       
        private void Frmoyun_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void tmrsure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblsure.Text = sure.ToString();
            if (lblsure.Text == "0")
            {


                tmrsure.Stop();
                tmrbutton.Stop();

                FSYazdir(lblskor.Text);

                DialogResult result = new DialogResult();

                result = MessageBox.Show($"Oynunuz bitti! \nSkorunuz: {lblskor.Text} Puan\n" +
                "Tekrar oynamak istermisiniz ?", "ÇIKIŞ", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                   Close();
                }
                else
                {
                    Application.Restart();

                }
               
               

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tmrbutton.Start();
            tmrsure.Start();
        }
        private static void FSYazdir(string deger)
        {


            FileStream fs = new FileStream("OyunKayıt.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(DateTime.Now + " ");
            sw.Write(deger + "\n");
            fs.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
