using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocitani
{
    public partial class rozmezi : Form
    {
        int max1, max2, min1, min2;

        private FormPocitani pocitani;

        public rozmezi(FormPocitani pocitani, int min1, int max1, int min2, int max2, ZiskejText ZiskejMin1, ZiskejText ZiskejMax1, ZiskejText ZiskejMin2, ZiskejText ZiskejMax2)
        {
            InitializeComponent();
            this.min1 = min1;
            this.min2 = min2;
            this.max1 = max1;
            this.max2 = max2;
            this.pocitani = pocitani;
            textBox1.Text = min1.ToString();
            textBox2.Text = max1.ToString();
            textBox3.Text = min2.ToString();
            textBox4.Text = max2.ToString();
            this.ZiskejMin1 = ZiskejMin1;
            this.ZiskejMax1 = ZiskejMax1;
            this.ZiskejMin2 = ZiskejMin2;
            this.ZiskejMax2 = ZiskejMax2;


        }

        private ZiskejText ZiskejMin1;
        private ZiskejText ZiskejMax1;
        private ZiskejText ZiskejMin2;
        private ZiskejText ZiskejMax2;

        private void btnSave_Click(object sender, EventArgs e)
        {
            ZiskejMin1(textBox1.Text);
            ZiskejMax1(textBox2.Text);
            ZiskejMin2(textBox3.Text);
            ZiskejMax2(textBox4.Text);
            Close();
            pocitani.Vyber();
        }

        public string SaveMin1()
        {
            return textBox1.Text;
        }

        public string SaveMax1()
        {
            return textBox2.Text;
        }

        public string SaveMin2()
        {
            return textBox3.Text;
        }

        public string SaveMax2()
        {
            return textBox4.Text;
        }
    }
}
