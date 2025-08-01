using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42.Foreach_Döngüsü
{
    public partial class Form1 : Form
    {

        Random rastgele = new Random();

        int sayac = 0, bolunebilenlerToplami = 0, diziToplamı = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            label5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int[] sayilar = new int[15];

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rastgele.Next(0, 101);

                listBox1.Items.Add(sayilar[i]);

                if (sayilar[i] % 4 == 0 )
                {
                    listBox2.Items.Add(sayilar[i]);

                    sayac++;
                    bolunebilenlerToplami = bolunebilenlerToplami + sayilar[i];
                }
            }

            label2.Text = sayac.ToString() + " adet 4'e bölünebilen sayı vardır.";
            label3.Text = "4'e tam bölünen sayılar toplamı :" + bolunebilenlerToplami.ToString();

            foreach (int sayi in sayilar)
            {
                diziToplamı = diziToplamı + sayi;
                label5.Text = "Dizinin elemanlarının toplamı: " + diziToplamı.ToString(); 
            }
            

        }
    }
}
