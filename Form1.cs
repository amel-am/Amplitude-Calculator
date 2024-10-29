using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAmpCalc_Click(object sender, EventArgs e)
        {
            double newNum = Decimal.ToDouble(this.textBoxHz.Value) / 100;
            double result = Math.Log(1 / newNum, 10) * 20 - 6;
            this.textBoxresult.Text = Math.Round(result, 1).ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBoxresult.Text);
        }

        private void  BtnAmpCalcZahn_Click(object sender, EventArgs e)
        {
            double newNum = Decimal.ToDouble(this.textBoxZahnHz.Value) / 100;
            double result = Math.Log(1 / newNum, 10) * 20;
            this.textBoxResultZahn.Text = Math.Round(result, 1).ToString();
        }

        private void CopyButtonZahn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBoxResultZahn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
