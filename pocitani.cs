using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pocitani
{
    public partial class pocitani : Form
    {
        DateTime time = DateTime.Now;

        public pocitani()
        {
            InitializeComponent();
            Sound.PlaySoundFromSubDir("start");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormPocitani scitani = new FormPocitani(0, 31, 0, 21, "+", "choice+");
            scitani.FormClosing += new FormClosingEventHandler(Zavri);
            scitani.Show();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormPocitani odcitani = new FormPocitani(10, 21, -999, -999, "-", "choice-");
            odcitani.FormClosing += new FormClosingEventHandler(Zavri);
            odcitani.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormPocitani scitodec = new FormPocitani(10, 21, -999, -999, "+-", "choice+-");
            scitodec.FormClosing += new FormClosingEventHandler(Zavri);
            scitodec.Show();
        }

        private async void Zavri(object o, FormClosingEventArgs e)
        {
            DateTime time = DateTime.Now;
            using (StreamWriter sw = new StreamWriter("spatne.txt", true))
            {
                sw.WriteLine("\n\nKonec {0}\n", time);
                sw.WriteLine("__________________________________________");
                sw.Flush();
            }
            using (StreamWriter sw = new StreamWriter("spravne.txt", true))
            {
                sw.WriteLine("\n\nKonec v {0}\n", time);
                sw.WriteLine("__________________________________________");
                sw.Flush();
            }
            Sound.PlaySoundFromSubDir("end");
            await Task.Delay(3000);
            Close();
        }

        private void soundon(object sender, EventArgs e)
        {
            Sound.soundon();
            zapnoutToolStripMenuItem.Checked = true;
            vypnoutToolStripMenuItem.Checked = false;
        }

        private void soundoff(object sender, EventArgs e)
        {
            Sound.soundoff();
            zapnoutToolStripMenuItem.Checked = false;
            vypnoutToolStripMenuItem.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            FormPocitani nasob = new FormPocitani(1, 8, 0, 8, "**", "choice");
            nasob.FormClosing += new FormClosingEventHandler(Zavri);
            nasob.Show();
        }
    }
}
