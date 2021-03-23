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
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        private bool MonHoc(double[] arr, double x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < x) return false;
            return true;
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            string[] s = input.Text.Split(',');
            double[] arr = new double[s.Length];
            Boolean flag; // kiểm tra xem dữ liệu có nhập sai không
            for (int i = 0; i < s.Length; i++)
            {
                flag = !Double.TryParse(s[i], out arr[i]);
                if (flag || arr[i] > 10 || arr[i] < 0)
                {
                    MessageBox.Show("Đã nhập sai format!\n Vui lòng kiểm tra lại!");
                    return;
                }
            }
            MessageBox.Show("Đã nhập đúng format!");
            double dtb = 0;
            int max = 0, min = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                // in ra màn hình
                switch (i % 4)
                {
                    case 0:
                        rtb_Column1.Text += "\nMôn " + (i + 1) + ": " + Math.Round(arr[i], 2) + "đ";
                        break;
                    case 1:
                        rtb_Column2.Text += "\nMôn " + (i + 1) + ": " + Math.Round(arr[i], 2) + "đ";
                        break;
                    case 2:
                        rtb_Column3.Text += "\nMôn " + (i + 1) + ": " + Math.Round(arr[i], 2) + "đ";
                        break;
                    default:
                        rtb_Column4.Text += "\nMôn " + (i + 1) + ": " + Math.Round(arr[i], 2) + "đ";
                        break;
                }
                // tính điểm trung bình
                dtb += arr[i];
                // tính index: max, min
                if (arr[i] > arr[max]) max = i;
                if (arr[i] < arr[min]) min = i;
                // đếm số môn khôn đậu
                if (arr[i] < 5) count++;
            }
            dtb = dtb / arr.Length;
            lb_DiemTB.Text = Math.Round(dtb, 2).ToString();
            lb_MonMax.Text = Math.Round(arr[max], 2) + "đ";
            lb_MonMin.Text = Math.Round(arr[min], 2) + "đ";
            lb_KDau.Text = count.ToString();
            lb_Dau.Text = (arr.Length - count).ToString();
            // Đánh giá học lực
            if (dtb >= 8 && MonHoc(arr, 6.5))
                lb_XepLoai.Text = "Giỏi";
            else if (dtb >= 6.5 && MonHoc(arr, 5))
                lb_XepLoai.Text = "Khá";
            else if (dtb >= 5 && MonHoc(arr, 3.5))
                lb_XepLoai.Text = "TB";
            else if (dtb >= 3.5 && MonHoc(arr, 2))
                lb_XepLoai.Text = "Yếu";
            else lb_XepLoai.Text = "Kém";
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            lb_DiemTB.Text = "";
            lb_MonMax.Text = "";
            lb_MonMin.Text = "";
            lb_KDau.Text = "";
            lb_Dau.Text = "";
            lb_XepLoai.Text = "";
            rtb_Column1.Text = "";
            rtb_Column2.Text = "";
            rtb_Column3.Text = "";
            rtb_Column4.Text = "";
        }
    }
}
