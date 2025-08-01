using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _46.Pratik_Örnek___Küp_Hesaplayan_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double kupunuHesapla(int sayi)
        {
            double kup = Math.Pow(sayi,3);
            return kup;
        }

        private int ikiSayiyiTopla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = kupunuHesapla(Convert.ToInt16(textBox1.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = ikiSayiyiTopla(Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text)).ToString();
        }
    }
}
