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

            private void button1_Click(object sender, EventArgs e)
            {
                klik++;
                switch (klik)
                {
                    case 1:
                        int prvi = rand.Next(1, 37);
                        textBox1.Text = prvi.ToString();
                        izvuceni.Add(prvi);
                        break;
                    case 2:
                        int drugi = rand.Next(1, 37);
                        while (izvuceni.Contains(drugi))
                        {
                            drugi = rand.Next(1, 37);
                        }
                        textBox2.Text = drugi.ToString();
                        izvuceni.Add(drugi);
                        break;
                    case 3:
                        int treci = rand.Next(1, 37);
                        while (izvuceni.Contains(treci))
                        {
                            treci = rand.Next(1, 37);
                        }
                        textBox3.Text = treci.ToString();
                        izvuceni.Add(treci);
                        break;
                    case 4:
                        int cetvrti = rand.Next(1, 37);
                        while (izvuceni.Contains(cetvrti))
                        {
                            cetvrti = rand.Next(1, 37);
                        }
                        textBox4.Text = cetvrti.ToString();
                        izvuceni.Add(cetvrti);
                        break;
                    case 5:
                        int peti = rand.Next(1, 37);
                        while (izvuceni.Contains(peti))
                        {
                            peti = rand.Next(1, 37);
                        }
                        textBox5.Text = peti.ToString();
                        izvuceni.Add(peti);
                        break;
                    case 6:
                        int sesti = rand.Next(1, 37);
                        while (izvuceni.Contains(sesti))
                        {
                            sesti = rand.Next(1, 37);
                        }
                        textBox6.Text = sesti.ToString();
                        izvuceni.Add(sesti);
                        break;
                }
            }
        }
}
