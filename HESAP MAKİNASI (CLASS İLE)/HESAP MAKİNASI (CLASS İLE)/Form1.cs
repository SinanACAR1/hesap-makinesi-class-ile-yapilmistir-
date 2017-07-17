using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 yenimakina = new Class1();//sınıfı cagırıyoruz.
        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = 1;
            textBox1.Text += sayı.ToString();
        }


        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = yenimakina.sayıayrıstır(textBox1.Text).ToString();//sayı ayrıstır sınıfı burda çalıştırıyoruz;

        }
    }
}
