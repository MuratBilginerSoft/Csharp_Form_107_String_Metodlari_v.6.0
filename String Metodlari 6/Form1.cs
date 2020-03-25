using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace String_Metodlari_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime1 = textBox1.Text; // 1. kelimeyi aldık.

            string kelime2 = textBox2.Text; // 2. kelimeyi aldık

            int a = string.CompareOrdinal(kelime1,kelime2); // karşılaştırmamızı yaptık.

            if (a<0) // durumlara göre gerekli ifadeleri yazdırıyoruz.
            {
                label5.Text = kelime1+" sözlükte daha öncedir. ";
            }

            else if (a>0)
            {
                label5.Text = kelime2+" sözlükte daha öncedir. ";
            }

            else
            {
                label5.Text ="İki kelime aynıdır.";
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime3 = textBox3.Text; // 1. kelimeyi aldık.

            string kelime4 = textBox4.Text; // 2. kelimeyi aldık

            int b = kelime3.CompareTo(kelime4); // iki kelimeyi karşılaştırdık.

            if (b < 0) 
            {
                label6.Text =kelime4+" daha büyüktür.";
            }

            else if (b > 0)
            {
                label6.Text = kelime3 + " daha büyüktür. ";
            }

            else
            {
                label6.Text = "İki kelime aynıdır.";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime5 = textBox5.Text; // kelimemizi aldık.

            char harf = Convert.ToChar(textBox6.Text); // eklemek istediğimiz karakteri aldık.

            int c = int.Parse(textBox7.Text); // kelime uzunluğunu belirledik.

            label10.Text = kelime5.PadLeft(c, harf); // ekleme işlemini yaptık.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kelime6 = textBox8.Text; // kelimemizi aldık.

            char harf2 = Convert.ToChar(textBox9.Text); // eklemek istediğimiz karakteri aldık.

            int d = int.Parse(textBox10.Text); // kelime uzunluğunu belirledik.

            label16.Text = kelime6.PadRight(d, harf2); // ekleme işlemini yaptık.
        }

        
    }
}
