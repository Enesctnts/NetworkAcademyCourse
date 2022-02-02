using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_09_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            try
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                textBox2.Text = textBox2.Text.Replace(".", ",");
                toplam = Convert.ToDouble(textBox1.Text) +
                         Convert.ToDouble(textBox2.Text);
                textBox3.Text = toplam.ToString("######.##");
                listBox1.Items.Add(textBox1.Text + " + "
                                   + textBox2.Text + "=" 
                                   + textBox3.Text);
            }
            catch 
            {
                textBox3.Text = "Geçersiz double";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double carpim = 0;
            try
            {
                textBox1.Text = textBox1.Text.Replace(".", ",");
                textBox2.Text = textBox2.Text.Replace(".", ",");
                carpim = Convert.ToDouble(textBox1.Text) *
                         Convert.ToDouble(textBox2.Text);
                textBox3.Text = carpim.ToString("######.##");
                listBox1.Items.Add(textBox1.Text + " * "
                                   + textBox2.Text + "="
                                   + textBox3.Text);
            }
            catch
            {
                textBox3.Text = "Geçersiz double";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
