using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int calcul = 0;
        double a1,b1,rez1;
        string a="", b="";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //reset
            a = "";
            b = "";
            rez1 = 0;
            calcul = 0;
            richTextBox1.Text = "";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //delete last introduced character
            if (calcul == 0) a=a.Remove(a.Length -1);
            else b = b.Remove(b.Length - 1);
            afisare();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double procent = Convert.ToDouble(a) * 100;
            richTextBox1.Text = Convert.ToString(procent);
            b = "";
            a = Convert.ToString(rez1);
            calcul = 0;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            calcul = 1;
            //+
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calcul = 2;
            //-
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calcul = 5;
            a1 = Convert.ToDouble(a);
            double rez1 = Math.Sqrt(a1);
            richTextBox1.Text = Convert.ToString(rez1);
            b = "";
            a = Convert.ToString(rez1);
            calcul = 0;
            //sqrt
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //=
            a1 = Convert.ToDouble(a);
            if (b != "") b1 = Convert.ToDouble(b);
            else b1 = 0;

            switch (calcul)
            {
                case 1: 
                    if (b != "")
                    {
                        rez1 = a1 + b1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    else
                    {
                        rez1 = a1 + a1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    break;

                case 2:
                    if (b != "")
                    {
                        rez1 = a1 - b1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    else
                    {
                        rez1 = a1 - a1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    break;

                case 3:
                    if (b != "")
                    {
                        rez1 = a1 * b1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    else
                    {
                        rez1 = a1 * a1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    break;

                case 4:
                    if (b != "")
                    {
                        rez1 = a1 / b1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    else
                    {
                        rez1 = a1 / a1;
                        richTextBox1.Text = Convert.ToString(rez1);
                        b = "";
                        a = Convert.ToString(rez1);
                        calcul = 0;
                    }
                    break;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            calcul = 3;
            //*
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calcul = 4;
            // /
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += ',';
            else b += ',';
            afisare();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += "00";
            else b += "00";
            afisare();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '0';
            else b += '0';
            afisare();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '9';
            else b += '9';
            afisare();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '8';
            else b += '8';
            afisare();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '7';
            else b += '7';
            afisare();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '6';
            else b += '6';
            afisare();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '5';
            else b += '5';
            afisare();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '4';
            else b += '4';
            afisare();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '3';
            else b += '3';
            afisare();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '2';
            else b += '2';
            afisare();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calcul == 0) a += '1';
            else b+= '1';
            afisare();
        }

        private void afisare()
        {
            if(calcul == 0) { richTextBox1.Text=a; }
            else richTextBox1.Text=b;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
