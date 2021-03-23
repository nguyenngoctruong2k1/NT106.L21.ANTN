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
    public partial class Lab01_Bai03 : Form
    {
        string s;
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            strResult.Text = "";
        }

        private string Read1Number(char k)
        {
            switch (k)
            {
                case '0':
                    return "không";
                case '1':
                    return "một";
                case '2':
                    return "hai";
                case '3':
                    return "ba";
                case '4':
                    return "bốn";
                case '5':
                    return "năm";
                case '6':
                    return "sáu";
                case '7':
                    return "bảy";
                case '8':
                    return "tám";
                default:
                    return "chín";
            }
        }
        private string Read3Number(char _a, char _b, char _c)
        {
            if (_a == '0' && _b == '0' && _c == '0')
                return "";
            string  a = Read1Number(_a) + " trăm ",
                    b = Read1Number(_b) + " mươi ",
                    c = Read1Number(_c);
            if (_c == '1' && _b > '1')
                c = "mốt";
            if (_b > '1' && _c == '4')
                c = "tư";
            if (_c == '5')
                c = "lăm";
            if (_b == '0')
                b = "lẻ ";
            if (_b == '1')
            {
                b = "mười ";
                if (_c == '0') c = "";
            }
            if (_c == '0')
            {
                c = "";
                if (_b == '0') b = "";
            }
            return a + b + c;
        }

        private string Read2Number(string s)
        {
            if (s.Length == 1)
                return Read1Number(s[0]);
            string  b = Read1Number(s[0]) + " mươi ",
                    c = Read1Number(s[1]);
            if (s[1] == '1' && s[0] > '1')
                c = "mốt";
            if (s[0] > '1' && s[1] == '4')
                c = "tư";
            if (s[1] == '5')
                c = "lăm";
            if (s[0] == '0')
                b = "";
            if (s[0] == '1')
            {
                b = "mười";
                if (s[1] == '0') c = "";
                else c = " " + c;
            }
            if (s[1] == '0') c = "";
            return b + c;
        }

        /* Định hướng thuật toán:
            - Đọc từng 3 số mỗi lần từ phải sang trái
            - Nếu phần cuối cùng là số có 2 chữ số hoặc 1 chữ số thì đọc khác
            - Sử dụng một số điều kiện để đọc số cho đúng, dựa trên đọc số có 1 chữ số
         */
        private void ReadNumber()
        {
            string sult = "";
            int i = s.Length - 1;
            for (; i >= 2; i = i-3)
            {
                string text = Read3Number(s[i - 2], s[i - 1], s[i]);
                if (i == s.Length - 4 && text != "")
                    sult = text + " nghìn " + sult;
                else if (i == s.Length - 7 && text != "")
                    sult = text + " triệu " + sult;
                else if (i == s.Length - 10 && text != "")
                    sult = text + " tỉ " + sult;
                else
                    sult = text;
            }
            if (i == 1)
            {
                string m = "";
                for (int j = 0; j <= 1; j++)
                    m += intNumber.Text[j];
                if (i == s.Length - 4)
                    sult = Read2Number(m) + " nghìn " + sult;
                else if (i == s.Length - 7)
                    sult = Read2Number(m) + " triệu " + sult;
                else if (i == s.Length - 10)
                    sult = Read2Number(m) + " tỉ " + sult;
                else
                    sult = Read2Number(m);
            }
            else if (i == 0)
            {
                if (i == s.Length - 4)
                    sult = Read1Number(intNumber.Text[0]) + " nghìn " + sult;
                else if (i == s.Length - 7)
                    sult = Read1Number(intNumber.Text[0]) + " triệu " + sult;
                else if (i == s.Length - 10)
                    sult = Read1Number(intNumber.Text[0]) + " tỉ " + sult;
                else
                    sult = Read1Number(intNumber.Text[0]);
            }

            strResult.Text = char.ToUpper(sult[0]) + sult.Substring(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Read_Click(object sender, EventArgs e)
        {
            Int32 number;
            if (!Int32.TryParse(s, out number))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên [0..10,000,000,000]\n Lưu ý! Nhập đúng format số tự nhiên");
            }
            else
            {
                ReadNumber();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            intNumber.Text = "";
            strResult.Text = "";      
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void intNumber_Leave(object sender, EventArgs e)
        {
            Int64 number;
            s = intNumber.Text.Trim();
            if (s.Contains(" ")) s = String.Join("",intNumber.Text.Split());
            else if (s.Contains(",")) s = String.Join("",intNumber.Text.Split(','));
            
            if (!Int64.TryParse(s, out number) && !(intNumber.Text.Trim() == ""))
            {
                MessageBox.Show("Vui lòng nhập số tự nhiên [0..10,000,000,000]\n Lưu ý! Nhập đúng format số tự nhiên");

            }
        }
    }
}
