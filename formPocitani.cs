using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pocitani.Properties;
using System.IO;

namespace pocitani
{
    public delegate void ZiskejText(string text);

    public partial class FormPocitani : Form
    {
        
        int number1, number2;
        Random nh = new Random();
        int answ, answright, answwrong;
        bool sound = Sound.setSound();
        DateTime time = DateTime.Now;
        int timeLeft = 30;
        int max1;
        int min1;
        int max2;
        int min2;
        string znam;
        char znamenko;
        bool zapornaCisla = false;

        public FormPocitani(int min1, int max1, int min2, int max2, string znam, string choice)
        {
            InitializeComponent();
            if (sound == true)
            {
                btnSoundOn();
            }
            else
            {
                btnSoundOff();
            }
            Sound.PlaySoundFromSubDir(choice);
            this.znam = znam;
            ChangeText();
            this.min1 = min1;
            this.min2 = min2;
            this.max1 = max1;
            this.max2 = max2;
            Vyber();
            lblAnsw.Text = answ.ToString();

            

        }

        private void ChangeText ()
        {
            if (znam == "+")
            {
                Text = "Sčítání pro Anežku";
                Name = "Sčítání";
                sign.Text = "+";
                this.znamenko = '+';
            }

            if (znam == "-")
            {
                Text = "Odečítání pro Anežku";
                Name = "Odečítání";
                sign.Text = "-";
                this.znamenko = '-';


            }

            if (znam == "+-")
            {
                Text = "Sčítání a odečítání pro Anežku";
                Name = "Sčítání a odečítání";
                
            }

            if (znam == "*")
            {
                Text = "Násobení pro Anežku";
                Name = "Násobení";
                sign.Text = "*";
                this.znamenko = '*';
            }

        }


        private async void blikright()
        {
            lblEval.BackColor = System.Drawing.Color.Blue;
            await Task.Delay(500);
            lblEval.BackColor = System.Drawing.Color.Aqua;
            await Task.Delay(500);
            lblEval.BackColor = System.Drawing.Color.Blue;
            await Task.Delay(500);
            lblEval.BackColor = System.Drawing.Color.Aqua;
            await Task.Delay(500);

        }

        private async void blikwrong()
        {
            lblEval.BackColor = System.Drawing.Color.Azure;
            await Task.Delay(500);
            lblEval.BackColor = System.Drawing.Color.Red;
            await Task.Delay(500);
            lblEval.BackColor = System.Drawing.Color.Azure;
            await Task.Delay(500);
            lblEval.BackColor = System.Drawing.Color.Red;
            await Task.Delay(500);

        }

        public void Vyber()
        {
            int index = nh.Next(znam.Length);// nahodny vyber znamenka
            znamenko = znam[index];
            sign.Text = znamenko.ToString();

            do
            {
                number1 = nh.Next(min1, max1);
                number2 = nh.Next(VypoctiMin2(), VypoctiMax2());
            } while (znamenko == '-' && !zapornaCisla && number1 < number2);
            


            btnNumber1.Text = number1.ToString();
            btnNumber2.Text = number2.ToString();
            lblAnsw.Text = answ.ToString();
       }





        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + 9;
        }

         
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
        }

        

        private void btnSoundOn()
        {
            zapnoutToolStripMenuItem.Checked = true;
            vypnoutToolStripMenuItem.Checked = false;

        }


        private void btnSoundOff()
        {
            zapnoutToolStripMenuItem.Checked = false;
            vypnoutToolStripMenuItem.Checked = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
               Sound.PlaySoundFromSubDir("wait");
                timeLeft = 30;
                timer1.Start();

            }
        }

        private void zapnoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sound.soundon();
            btnSoundOn();
        }

        private void vypnoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Sound.soundoff();
            btnSoundOff();
        }

        private int VypoctiMin2()
        {
            if (min2 != -999)
            {
                return (min2);
            }
            else
                return (number1 - min1);

        }

        private int VypoctiMax2()
        {
            if (max2 != -999)
            {
                return (max2);
            }
            else
                return (number1 + 1);

        }

        private void rozmeziscit(object sender, EventArgs e)
        {
            rozmezi form = new rozmezi(this, min1, max1, min2, max2, new ZiskejText(SaveScitMin1), new ZiskejText(SaveScitMax1), new ZiskejText(SaveScitMin2), new ZiskejText(SaveScitMax2));
            
            form.Show();
        }

        private void SaveScitMin1(string text)
        {
            min1 = int.Parse(text);
        }

        private void SaveScitMax1(string text)
        {
            max1 = int.Parse(text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "-";
        }

        private void SaveScitMin2(string text)
        {
            min2 = int.Parse(text);
        }

        private void minusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zapornaCisla)
            {
                zapornaCisla = false;
            }
            else
            {
                zapornaCisla = true;
            }
            Vyber();
        }

        private void SaveScitMax2(string text)
        {
            max2 = int.Parse(text);
        }

        private bool Sum (int number1, int number2, string znam, string resultText)
        {
            bool boolResult = false;

            int result = Int32.Parse(resultText);
            
    
           
                
                if (znamenko == '-')
                {
                    if (number1 - number2 == result)
                    { boolResult = true; }
                }

                if (znamenko == '+')
                {
                    if (number1 + number2 == result)
                    { boolResult = true; }
                }

            if (znamenko == '*')
            {
                if (number1 * number2 == result)
                { boolResult = true; }
            }




            return boolResult;

        }


        private async void btnControl_Click(object sender, EventArgs e)
        {
            try
            {
                timeLeft = 30;
                timer1.Start();
                
                DateTime time = DateTime.Now;
                if (Sum(number1, number2, znam, txtResult.Text))
                {
                    using (StreamWriter sw = new StreamWriter("spravne.txt", true))
                    {
                        sw.WriteLine("{0} " + znam + " {1} = {2} Správně {3}", number1, number2, txtResult.Text, time);
                        sw.Flush();
                    }
                    Sound.PlaySoundFromSubDir("right");
                    lblEval.Text = "Správně";
                    picSmile.Image = Resources.smile;
                    txtResult.ResetText();
                    answright++;
                    lblAnswRight.Text = answright.ToString();
                    answ++;
                    lblAnsw.Text = answ.ToString();
                    blikright();
                    await Task.Delay(2000);
                    lblEval.ResetText();
                    Vyber();
                    picSmile.Image = Resources.smiley_thinking_815;

                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("spatne.txt", true))
                    {
                        sw.WriteLine("{0} "+ znam +" {1} = {2} Špatně {3}", number1, number2, txtResult.Text, time);
                        sw.Flush();
                    }
                    Sound.PlaySoundFromSubDir("wrong");
                    lblEval.Text = "Špatně";
                    picSmile.Image = Resources.sad;
                    answwrong++;
                    lblAnswWrong.Text = answwrong.ToString();
                    answ++;
                    lblAnsw.Text = answ.ToString();
                    blikwrong();
                    await Task.Delay(2000);
                    lblEval.ResetText();
                    txtResult.ResetText();
                    picSmile.Image = Resources.smiley_thinking_815;

                }

            }
            catch
            {
                txtResult.ResetText();
            }

        }


    }
}
