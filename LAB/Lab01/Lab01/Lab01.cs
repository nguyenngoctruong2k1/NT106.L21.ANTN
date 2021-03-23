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
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Bai01_Click(object sender, EventArgs e)
        {
            new Lab01_Bai01().Show();
        }

        private void Bai02_Click(object sender, EventArgs e)
        {
            new Lab01_Bai02().Show();
        }

        private void Bai03_Click_1(object sender, EventArgs e)
        {
            new Lab01_Bai03().Show();
        }

        private void Bai04_Click(object sender, EventArgs e)
        {
            new Lab01_Bai04().Show();
        }

        private void Bai05_Click(object sender, EventArgs e)
        {
            new Lab01_Bai05().Show();
        }
    }
}
