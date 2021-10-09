using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4etnoene4etnoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8) 
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int a = Convert.ToInt32(textBox1.Text);
            if ((a % 2)==0)
            {
                label3.Visible = false;
                label4.Visible = false;
                label2.Visible = true;
                
            }

            //if (a == 0)
            //{
            //    label2.Visible = false;
            //    label3.Visible = false;
            //    label4.Visible = true;
               
            //}

            else
            {
                label2.Visible = false;
                label4.Visible = false;
                label3.Visible = true;
              
            }
        }
    }
}
