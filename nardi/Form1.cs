using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nardi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, fx, b;
            x = Convert.ToDouble(shahid.Text);
            y = Convert.ToDouble(knigga.Text);
            fx = Math.Pow(x, 2);

            if(x == 0)
            {
                b = Math.Pow((Math.Pow(fx, 2) + y), 3);
            }
            else if(y == 0)
            {
                b = 0;
            }
            else if(x / y > 0)
            {
                b = Math.Log(fx) + Math.Pow(fx + y, 3);
            }
            else
            {
                b = Math.Abs(Math.Log(fx / y)) + Math.Pow(fx + y, 3);
            }

            suboba.Text = Convert.ToString(b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, r;
            a = Convert.ToDouble(papich.Text);
            b = Convert.ToDouble(amogus.Text);
            c = Convert.ToDouble(kazahstan.Text);

            if((a > b && b > c) || (b > a && a > c))
            {
                r = a + b;
            }
            else if ((c > a && a > b) || (a > c && c > b))
            {
                r = a + c;
            }
            else
            {
                r = c + b;
            }

            bombardirovka.Text = r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mast, siu;
            mast = Convert.ToInt32(tiKtoPoMasti.Text);
            siu = Convert.ToInt32(aPoSushestvu.Text);

            string nazvanieMasti = "", dostoinstvoMasti = "";

            switch(mast)
            {
                case 1:
                    nazvanieMasti = "пик";
                        break;
                case 2:
                    nazvanieMasti = "треф";
                        break;
                case 3:
                    nazvanieMasti = "бубен";
                        break;
                case 4:
                    nazvanieMasti = "червей";
                        break;
            }

            switch(siu)
            {
                case 11:
                    dostoinstvoMasti = "валет";
                    break;
                case 12:
                    dostoinstvoMasti = "дама";
                    break;
                case 13:
                    dostoinstvoMasti = "король";
                    break;
                case 14:
                    dostoinstvoMasti = "туз";
                    break;
            }

            tiLoh.Text = dostoinstvoMasti + " " + nazvanieMasti;
        }
    }
}
