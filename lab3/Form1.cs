using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class lab3 : Form
    {
        public lab3()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string s;
        double a, b, c, d, e1, f1 = 0;

        private void Tab1_Click(object sender, EventArgs e)
        {

        }

        private void textBox444_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                a = 0;
            }
            else
            {
                s = textBox1.Text;
                a = Convert.ToDouble(s);
            }
            textBox3.Text = "Идет расчет";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                b = 0;
            }

            else
            {
                s = textBox2.Text;
                b = Convert.ToDouble(s);
            }

            c = a + b;

            textBox3.Text = Convert.ToString(c);

        }


        private void textBox111_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox111.Text == "")
            {
                a = 0;
            }
            else
            {

                a = Convert.ToDouble(textBox111.Text);

            }
            d = a + b;
            e1 = d * c;
            f1 = e1 / 2;

            if (d == 0)
            {
                textBox444.Text = "Идет расчет";
            }
            if (e1 == 0){

                textBox555.Text = "Идет расчет";
            }
            if (f1 == 0)
            {
                textBox666.Text = "Идет расчет";
            }
            else
            {
                
                textBox444.Text = d.ToString();
                textBox555.Text = e1.ToString();
                textBox666.Text = f1.ToString();
            }
        }

        private void textBox222_TextChanged(object sender, EventArgs e)
        {
            
           
            if (textBox222.Text == "")
            {
                b = 0;
            }
            else
            {

                b = Convert.ToDouble(textBox222.Text);

            }


            d = a + b;
            e1 = d * c;
            f1 = e1 / 2;
            if (d == 0)
            {
                textBox444.Text = "Идет расчет";
            }
            if (e1 == 0)
            {
                textBox555.Text = "Идет расчет";
            }
            if (f1 == 0)
            {
                textBox666.Text = "Идет расчет";
            }
            else
            {
                
                textBox444.Text = d.ToString();
                textBox555.Text = e1.ToString();
                textBox666.Text = f1.ToString();
            }
        }

        
        private void textBox333_TextChanged(object sender, EventArgs e)
        {
            
            
            if (textBox333.Text == "")
            {
                c = 0;
            }
            else
            {

                c = Convert.ToDouble(textBox333.Text);

            }


            
            d = a + b;
            e1 = d * c;
            f1 = e1 / 2;

            
            if (d == 0)
            {
                textBox444.Text = "Идет расчет";
            }
            if (e1 == 0)
            {
                textBox555.Text = "Идет расчет";
            }
            if (f1 == 0)
            {
                textBox666.Text = "Идет расчет";
            }
            else
            {
                
                textBox444.Text = d.ToString();
                textBox555.Text = e1.ToString();
                textBox666.Text = f1.ToString();
            }
        }
    }

}

