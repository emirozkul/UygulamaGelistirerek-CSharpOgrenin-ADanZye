using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _45.Geriye_Değer_Döndüren_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int sayilariCarp(int sayi1, int sayi2, int sayi3)
        {
            int carpim = sayi1 * sayi2 * sayi3;
            return carpim;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Sonuç: " + sayilariCarp(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox3.Text));

        }
    }
}
