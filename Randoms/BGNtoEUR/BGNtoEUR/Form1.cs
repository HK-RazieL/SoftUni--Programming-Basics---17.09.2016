using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGNtoEUR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert()
        {
            var amountBGN = numericUpDown1.Value;
            var amountEUR = Math.Round((amountBGN * 1.95583m), 2);
            var result = string.Format("{0} BGN = {1} EUR", amountBGN, amountEUR);
            labelResult.Text = result;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void FormConvert_Load(object sender, EventArgs e)
        {
            Convert();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }
        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            Convert();
        }

    }

}
