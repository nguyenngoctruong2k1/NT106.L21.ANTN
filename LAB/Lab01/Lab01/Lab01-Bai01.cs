using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        Int32 Number1, Number2;
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(intNumber1.Text, out Number1) && Int32.TryParse(intNumber2.Text, out Number2))
            {
                Int32 result = Number1 + Number2;
                intResult.Text = result.ToString();
            }
            else intResult.Text = "";
        }

        private void intNumber1_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(intNumber1.Text.Trim(), out Number1))
            {
                if (intNumber1.Text != "")
                    MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }

        private void Lab01_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void intNumber1_TextChanged(object sender, EventArgs e)
        {
            intResult.Text = "";
        }

        private void intNumber2_TextChanged(object sender, EventArgs e)
        {
            intResult.Text = "";
        }

        private void intNumber2_Leave(object sender, EventArgs e)
        {
            if (!Int32.TryParse(intNumber2.Text.Trim(), out Number2))
            {
                if (intNumber2.Text != "")
                    MessageBox.Show("Vui lòng nhập số nguyên");
            }
        }
    }
}
