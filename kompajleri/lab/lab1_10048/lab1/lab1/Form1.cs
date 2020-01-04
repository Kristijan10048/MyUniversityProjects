using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace lab1
{
    public partial class form1 : Form
    {
        private string izraz;
        byte p1p0 = 1;
        byte p1n0 = 0;
        byte n1p0 = 0;
        byte n1n0 = 0;

        public void initState()
        {
             p1p0 = 1;
             p1n0 = 0;
             n1p0 = 0;
             n1n0 = 0;
        }
        private void printState(char ch)
        {
           
            output.Text += "------------------------" + "\r\n";
            output.Text += "p1p0=" + p1p0 + "\r\n";
            output.Text += "p1n0=" + p1n0 + "\r\n";
            output.Text += "n1p0=" + n1p0 + "\r\n";
            output.Text += "n1n0=" + n1n0 + "\r\n";
           
        }

        private void changeState(char ch)
        {

            //sostojba p1p0 i 1 na vlez
            //premin vo n1p0
            //pocetna i krajna sostojba
            if ((ch == '1') && (p1p0 == 1))
            {
                p1p0 = 0;
                p1n0 = 0;
                n1p0 = 1;
                n1n0 = 0;
                printState(ch);
                return;
            }

            //sostojba p1p0 i 0 na vlez
            //premin vo p1n0
            if ((ch == '0') && (p1p0 == 1))
            {
                p1p0 = 0;
                p1n0 = 1;
                n1p0 = 0;
                n1n0 = 0;
                printState(ch);
                return;
            }


            //sostojba p1n0 i 0 na vlez
            //premin vo p1p0
            if ((ch == '0') && (p1n0 == 1))
            {
                p1p0 = 1;
                p1n0 = 0;
                n1p0 = 0;
                n1n0 = 0;
                printState(ch);
                return;
            }


            //sostojba n1p0 i 1 na vlez
            //premin vo p1p0
            if ((ch == '1') && (n1p0 == 1))
            {
                p1p0 = 1;
                p1n0 = 0;
                n1p0 = 0;
                n1n0 = 0;
                printState(ch);
                return;
            }


            //sostojba n1p0 i 0 na vlez
            //premin vo n1n0
            if ((ch == '0') && (n1p0 == 1))
            {
                p1p0 = 0;
                p1n0 = 0;
                n1p0 = 0;
                n1n0 = 1;
                printState(ch);
                return;
            }


            //sostojba n1n0 i 0 na vlez
            //premin n1p0
            if ((ch == '0') && (n1n0 == 1))
            {
                p1p0 = 0;
                p1n0 = 0;
                n1p0 = 1;
                n1n0 = 0;
                printState(ch);
                return;
            }

            //sostojba n1n0 i 1 na vlez
            //premin p1n0
            if ((ch == '1') && (n1n0 == 1))
            {
                p1p0 = 0;
                p1n0 = 0;
                n1p0 = 1;
                n1n0 = 0;
                printState(ch);
                return;
            }

            //sostojba p1n0 i 1 na vlez
            //premin n1n0
            if ((ch == '1') && (p1n0 == 1))
            {
                p1p0 = 0;
                p1n0 = 0;
                n1p0 = 0;
                n1n0 = 1;
                printState(ch);
                return;
            }


        }

        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (izrazTb.Text != null)
            {
                output.Text = "";
                izraz=izrazTb.Text;
                initState();
                int i;
                char ch1;
                for (i = 0; i < izraz.Length; i++)
                {
                    ch1=izraz[i];
                    if ((ch1 != '0') && (ch1 != '1'))
                        output.Text = "Внесениот израз не се состои од азбуката {0,1}";
                    else
                    {
                        changeState(ch1);
                        // output.Text+= "t"+"\r\n";
                    }

                }
                if(p1p0==1)
                    output.Text += "Внесениот израз e валиден";
                else
                    output.Text += "Внесениот израз не e валиден";
            }
        }
    }
}
