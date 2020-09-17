using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto
{
    public partial class Form1 : Form
    {

            HashSet<int> izvuceni = new HashSet<int>();
            Random rand = new Random();
            int klik = 0;
            public Form1()
            {
                InitializeComponent();
            }

                        private int Izvuci(ref HashSet<int> izvuceni)
            {
                int broj = rand.Next(1, 37);
                while (izvuceni.Contains(broj))
                {
                    broj = rand.Next(1, 37);
                }
                izvuceni.Add(broj);
            return broj;
        }
            private void button1_Click(object sender, EventArgs e)
            {
                klik++;
                switch (klik)
                {
                    case 1:
                        textBox1.Text = Izvuci(ref izvuceni).ToString();
                        break;
                    case 2:
                        textBox2.Text = Izvuci(ref izvuceni).ToString();
                        break;
                    case 3:
                        textBox3.Text = Izvuci(ref izvuceni).ToString();
                        break;
                    case 4:
                        textBox4.Text = Izvuci(ref izvuceni).ToString();
                        break;
                    case 5:
                        textBox5.Text = Izvuci(ref izvuceni).ToString();
                        break;
                    case 6:
                        textBox6.Text = Izvuci(ref izvuceni).ToString();
                        break;
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int[] listic = { 5, 7, 12, 26, 29, 33 };
                int pogodeni = 0;
                for (int i = 0; i < listic.Length; i++)
                {
                    if (izvuceni.Contains(listic[i]))
                        pogodeni++;
                }
                textBox8.Text = pogodeni.ToString() + "/6";

            }
        }
    }
}
