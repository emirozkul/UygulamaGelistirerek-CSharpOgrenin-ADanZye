using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41.Dizi_Elemanları_Listeleme
{
    public partial class Form1 : Form
    {

        Random rastgele = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[10];

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(0, 100);

                listBox2.Items.Add(sayilar[i]);
            }

            for (int j = 0; j < sayilar.Length; j++)
            {
                if (sayilar[j]>=10 && sayilar[j] % 2 == 0)
                {
                    listBox1.Items.Add(sayilar[j]);
                }
            }

        }
    }
}
