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
    public partial class Lab01_Bai04 : Form
    {
        
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        
        private static readonly Dictionary<string, int> HeCoSo = new Dictionary<string, int>
        {
            { "Decimal", 10 },
            { "Binary", 2 },
            { "Hexadecimal", 16 }
        };
        private static readonly Dictionary<string, char> He2to16 = new Dictionary<string, char>
        {
            { "0000", '0' },
            { "0001", '1' },
            { "0010", '2' },
            { "0011", '3' },
            { "0100", '4' },
            { "0101", '5' },
            { "0110", '6' },
            { "0111", '7' },
            { "1000", '8' },
            { "1001", '9' },
            { "1010", 'A' },
            { "1011", 'B' },
            { "1100", 'C' },
            { "1101", 'D' },
            { "1110", 'E' },
            { "1111", 'F' },
        };
        private static readonly Dictionary<char, string> He16to2 = new Dictionary<char, string>
        {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'A', "1010" },
            { 'B', "1011" },
            { 'C', "1100" },
            { 'D', "1101" },
            { 'E', "1110" },
            { 'F', "1111" },
        };

        private bool CheckBinary(string number)
        {
            for (int i = 0; i < number.Length; i++)
                if (number[i] > '1' || number[i] < '0') return false;
            return true;
        }
        private bool CheckDecimal(string number)
        {
            for (int i = 0; i < number.Length; i++)
                if (number[i] > '9' || number[i] < '0') return false;
            return true;
        }
        private bool CheckHexadecimal(string number)
        {
            for (int i = 0; i < number.Length; i++)
                if (number[i] >= '0' && number[i] <= '9') continue;
                else if (number[i] >= 'A' && number[i] <= 'F') continue;
                else return false;
            return true;
        }
        private void ThucHien_Click(object sender, EventArgs e)
        {
            switch (hcsChuyenDoi.Text)
            {
                case "Decimal":
                    Result.Text = Convert.ToInt64(input.Text, HeCoSo[hcsBanDau.Text]).ToString();
                    break;
                case "Binary":
                    if (hcsBanDau.Text == "Decimal")
                        Result.Text = Convert.ToString(Int64.Parse(input.Text), 2).ToString();
                    else if (hcsBanDau.Text == "Hexadecimal")
                    {
                        string s = input.Text.ToUpper();
                        string a = "";
                        int i = 0;
                        for (i = 0; i < s.Length; i++)
                            a += He16to2[s[i]] ;
                        i = 0;
                        while (a[i] == '0')
                            i++;
                        Result.Text = a.Substring(i);
                    }
                    else
                        Result.Text = input.Text;
                    break;
                default:
                    if (hcsBanDau.Text == "Decimal")
                        Result.Text = Convert.ToString(Int64.Parse(input.Text), 16).ToUpper();
                    else if (hcsBanDau.Text == "Binary")
                    {
                        string s = input.Text;
                        while (s.Length % 4 != 0)
                            s = '0' + s;
                        string a = "";
                        for (int i = 0; i < s.Length; i = i + 4)
                            a += He2to16[s.Substring(i, 4)];
                        Result.Text = a;
                    }
                    else
                        Result.Text = input.Text;
                    break;
            }
        }

        private void hcsBanDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void hcsChuyenDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            Result.Text = "";
        }

        private void input_Leave(object sender, EventArgs e)
        {
            input.Text = input.Text.ToUpper();
            hcsBanDau.Items.Clear();
            hcsBanDau.Items.AddRange(new object[] { "Binary", "Decimal", "Hexadecimal" });
            if (!CheckBinary(input.Text.Trim()))
                hcsBanDau.Items.Remove("Binary");
            if (!CheckDecimal(input.Text.Trim()))
                hcsBanDau.Items.Remove("Decimal");
            if (!CheckHexadecimal(input.Text.Trim()))
                hcsBanDau.Items.Remove("Hexadecimal");
        }
    }
}
