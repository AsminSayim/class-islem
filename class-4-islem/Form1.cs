using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_4_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            İslem islem = new İslem();
            islem.sayi1 = Convert.ToInt32(txtSayi1.Text);
            islem.sayi2 = Convert.ToInt32(txtSayi2.Text);
            lblTopla.Text = "Topla" + islem.Topla();
            lblCarp.Text = "Çarpım" + islem.Fark();
            lblBol.Text = "Bolüm" + islem.Bolüm();
            lblCikar.Text = "Çıkar" + islem.Fark();






        }
    }
}
