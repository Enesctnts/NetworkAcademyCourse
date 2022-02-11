using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders21_Form_AdoNet
{
    public partial class OgretmenForm : Form
    {

        public OgretmenForm()
        {
            InitializeComponent();
        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            Form1 ogrenciForm = new Form1();
            ogrenciForm.Show();
            this.Hide();
        }
    }
}
