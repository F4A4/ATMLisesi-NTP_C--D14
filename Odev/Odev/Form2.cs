using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string  b = textBox2.Text;
            int sayac = 3;
            for (int i = 1; i <sayac; i++)
            {
                sayac = sayac - i;
                label3.Text = "HAK ="+sayac.ToString();

            }
            if ((a=="fatmaltay")&& (b=="123456"))
            {
                MessageBox.Show("HOŞGELDİNİZ");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("YANLIŞ KULLANICI ADI VEYA ŞİFRE ");
                textBox1.Clear();
                textBox2.Clear();
            }
            Close();
           
            
        }

       
    }
}
