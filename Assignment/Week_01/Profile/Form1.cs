using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = this.thôngTinToolStripMenuItem.BackColor;
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(60, 105);
            this.sởThíchToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.thànhTíchToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(40, 100);

            this.title.Text = "THÔNG TIN CÁ NHÂN";

            this.label1.Text = "Họ và tên :";
            this.label2.Text = "NGUYỄN NGỌC TRƯỞNG\r\n";

            this.label4.Text = "MSSV : ";
            this.label3.Text = "19522440";

            this.label6.Text = "Lớp sinh hoạt : ";
            this.label5.Text = "ATTN 2019";

            this.label8.Text = "Trường : ";
            this.label7.Text = "ĐẠI HỌC CÔNG NGHỆ THÔNG TIN";

            this.label10.Text = "Quê quán : ";
            this.label9.Text = "Tuy Phước - Bình Định";

            this.label12.Text = "Nơi ở hiện tại : ";
            this.label11.Text = "KTX Khu B - ĐHQG TP.HCM";

            this.linkLabel1.Text = "";
            this.linkLabel2.Text = "";
            this.linkLabel3.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sởThíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = this.sởThíchToolStripMenuItem.BackColor;
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.sởThíchToolStripMenuItem.Size = new System.Drawing.Size(60, 105);
            this.thànhTíchToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(40, 100);

            this.title.Text = "SỞ THÍCH CÁ NHÂN";

            this.label1.Text = "1. Sách ưu thích: 'Nhà giả kim', 'Sức mạnh tiềm thức',...";
            this.label2.Text = "";

            this.label4.Text = "2. Ca sĩ ưa thích : Đen Vâu, Phan Mạnh Quỳnh.";
            this.label3.Text = "";

            this.label6.Text = "3. Bài hát ưa thích : 'Một triệu like', 'Lộn xộn 2',...";
            this.label5.Text = "";

            this.label8.Text = "4. Game hay chơi : Liên quân mobile, Cờ tướng, Mậu binh.";
            this.label7.Text = "";

            this.label10.Text = "5. Ngôn ngữ lập trình ưa thích : Python";
            this.label9.Text = "";

            this.label12.Text = "";
            this.label11.Text = "";

            this.linkLabel1.Text = "";
            this.linkLabel2.Text = "";
            this.linkLabel3.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thànhTíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = this.thànhTíchToolStripMenuItem.BackColor;
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.sởThíchToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.thànhTíchToolStripMenuItem.Size = new System.Drawing.Size(60, 105);
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(40, 100);

            this.title.Text = "THÀNH TÍCH CÁ NHÂN";

            this.label1.Text = "- Không có thành tích nào nổi bật";
            this.label2.Text = "";

            this.label4.Text = "- Là sinh viên ĐHCNTT ";
            this.label3.Text = "";

            this.label6.Text = "- Kết quả học tập năm nhất: 8.9";
            this.label5.Text = "";

            this.label8.Text = "- Kết quả học tập HK III : 8.95";
            this.label7.Text = "";

            this.label10.Text = "";
            this.label9.Text = "";

            this.label12.Text = "";
            this.label11.Text = "";

            this.linkLabel1.Text = "";
            this.linkLabel2.Text = "";
            this.linkLabel3.Text = "";

        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.BackColor = this.liênHệToolStripMenuItem.BackColor;
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.sởThíchToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.thànhTíchToolStripMenuItem.Size = new System.Drawing.Size(40, 105);
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(60, 100);

            this.title.Text = "LIÊN HỆ";

            this.label1.Text = "Địa chỉ: ";
            this.label2.Text = "phòng 1003, tòa D5, KTX Khu B";

            this.label4.Text = "SĐT: ";
            this.label3.Text = "0329410211";

            this.label6.Text = "Facebook: ";
            this.label5.Text = "";
            this.linkLabel1.Text = "Nguyễn Ngọc Trưởng";

            this.label8.Text = "Email: ";
            this.label7.Text = "";
            this.linkLabel2.Text = "19522440@gm.uit.edu.vn";

            this.label10.Text = "Github: ";
            this.label9.Text = "";
            this.linkLabel3.Text = "nguyenngoctruong2k1";

            this.label12.Text = "";
            this.label11.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://fb.com/nguyenngoctruong2k1");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:19522440@gm.uit.edu.vn");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nguyenngoctruong2k1");
        }
    }
}





