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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = textBox1.Text; 
            string sıfre = textBox2.Text;
            int sayaç = 3;
            for (int i = 0; i <sayaç; i++)
            {
                sayaç = sayaç - i;
                label3.Text = sayaç.ToString();

            }
            
            if ((kullanıcıAdı=="fatma")&&(sıfre=="1357"))
            {
                MessageBox.Show("HOŞGELDİN "+kullanıcıAdı);
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("YANLIŞ KULLANICI ADI VEYA ŞİFRE");
            }
            Close();
        }
    }
}
