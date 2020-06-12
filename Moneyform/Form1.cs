using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneyform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gobutton_Click(object sender, EventArgs e)
        {
            int change = 0;
            int prevChange = Int32.Parse(TotalmoneyTextbox.Text);
            int boxNum = 0;

            change = prevChange % 100;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 100;
            HundredthTextbox.Text = "" + boxNum;

            change = prevChange % 50; 
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 50;
            FiftythTextbox.Text = "" + boxNum;

            change = prevChange % 20;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 20;
            TwentythTextbox.Text= "" + boxNum;

            change = prevChange % 10;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 10;
            TenthTextbox.Text= "" + boxNum;

            change = prevChange % 5;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 5;
            FifthTextbox.Text= "" + boxNum;

            change = prevChange % 2;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 2;
            SecondTextbox.Text= "" + boxNum;

            change = prevChange % 1;
            boxNum = prevChange - change;
            prevChange = prevChange - boxNum;
            boxNum = boxNum / 1;
            FirstTextbox.Text= "" + boxNum;



        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
