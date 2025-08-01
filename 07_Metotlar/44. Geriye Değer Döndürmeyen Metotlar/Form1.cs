using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44.Geriye_Değer_Döndürmeyen_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle() 
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void renklendir()
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.Beige;
            textBox3.BackColor = Color.DarkOrange;
            textBox3.BackColor = Color.Khaki;
            textBox4.BackColor = Color.Magenta;
        }

        private void bilgileriDoldur()
        {
            textBox5.Text = "Emir";
            textBox6.Text = "Özkul";
            textBox7.Text = "25";
            textBox8.Text = "Öğrenci";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bilgileriDoldur();
        }
    }
}
