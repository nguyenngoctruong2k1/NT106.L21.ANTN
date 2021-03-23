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
    public partial class Lab01_Bai02 : Form
    {
        bool flag1, flag2, flag3;
        double dNumber1, dNumber2, dNumber3;
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Number1.Text = "";
            Number2.Text = "";
            Number3.Text = "";
            Max.Text = "";
            Min.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Number2_Leave(object sender, EventArgs e)
        {
            flag2 = double.TryParse(Number2.Text.Trim(), out dNumber2) || Number2.Text == "";
            if (!flag2 && Number2.Text != "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {
            Min.Text = "";
            Max.Text = "";
        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {
            Min.Text = "";
            Max.Text = "";
        }

        private void Number3_TextChanged(object sender, EventArgs e)
        {
            Min.Text = "";
            Max.Text = "";
        }

        private void Number3_Leave(object sender, EventArgs e)
        {
            flag3 = double.TryParse(Number3.Text.Trim(), out dNumber3) || Number3.Text == "";
            if (!flag3 && Number3.Text != "")
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void Lab01_Bai02_Load(object sender, EventArgs e)
        {
            Number1.Text = "";
            Number2.Text = "";
            Number3.Text = "";
        }

        private void Number1_Leave(object sender, EventArgs e)
        {
            flag1 = double.TryParse(Number1.Text.Trim(), out dNumber1) || Number1.Text == "";
            if (!flag1 && Number1.Text !="")
            {
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
        }

        private void Seach_Click(object sender, EventArgs e)
        {
            if (!(flag1 && flag2 && flag3))
            {
                Max.Text = "";
                Min.Text = "";
                MessageBox.Show("Vui lòng kiểm tra lại");
            }
            else
            {
                if (Number1.Text == "")
                    if (Number2.Text == "")
                    {
                        dNumber1 = dNumber3;
                        dNumber2 = dNumber3;
                    }
                    else dNumber1 = dNumber2;
                else
                {
                    if (Number2.Text == "") dNumber2 = dNumber1;
                    if (Number3.Text == "") dNumber3 = dNumber1;
                }
                Max.Text = Math.Max(dNumber1, Math.Max(dNumber2, dNumber3)).ToString();
                Min.Text = Math.Min(dNumber1, Math.Min(dNumber2, dNumber3)).ToString();
            }    
        }
    }
}
