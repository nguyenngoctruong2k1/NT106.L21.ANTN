
namespace Lab01
{
    partial class Lab01_Bai04
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ThucHien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hcsChuyenDoi = new System.Windows.Forms.ComboBox();
            this.hcsBanDau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ThucHien);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(27, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 50);
            this.panel3.TabIndex = 2;
            // 
            // ThucHien
            // 
            this.ThucHien.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThucHien.ForeColor = System.Drawing.Color.Cornsilk;
            this.ThucHien.Location = new System.Drawing.Point(156, 7);
            this.ThucHien.Name = "ThucHien";
            this.ThucHien.Size = new System.Drawing.Size(387, 40);
            this.ThucHien.TabIndex = 0;
            this.ThucHien.Text = "Thực hiện";
            this.ThucHien.UseVisualStyleBackColor = false;
            this.ThucHien.Click += new System.EventHandler(this.ThucHien_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hcsChuyenDoi);
            this.panel2.Controls.Add(this.hcsBanDau);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(27, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 50);
            this.panel2.TabIndex = 1;
            // 
            // hcsChuyenDoi
            // 
            this.hcsChuyenDoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hcsChuyenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcsChuyenDoi.FormattingEnabled = true;
            this.hcsChuyenDoi.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal"});
            this.hcsChuyenDoi.Location = new System.Drawing.Point(383, 7);
            this.hcsChuyenDoi.Name = "hcsChuyenDoi";
            this.hcsChuyenDoi.Size = new System.Drawing.Size(160, 32);
            this.hcsChuyenDoi.TabIndex = 3;
            this.hcsChuyenDoi.SelectedIndexChanged += new System.EventHandler(this.hcsChuyenDoi_SelectedIndexChanged);
            // 
            // hcsBanDau
            // 
            this.hcsBanDau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hcsBanDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hcsBanDau.FormattingEnabled = true;
            this.hcsBanDau.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexadecimal"});
            this.hcsBanDau.Location = new System.Drawing.Point(156, 7);
            this.hcsBanDau.Name = "hcsBanDau";
            this.hcsBanDau.Size = new System.Drawing.Size(160, 32);
            this.hcsBanDau.TabIndex = 2;
            this.hcsBanDau.SelectedIndexChanged += new System.EventHandler(this.hcsBanDau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn : ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(27, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 50);
            this.panel1.TabIndex = 0;
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(156, 9);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(387, 29);
            this.input.TabIndex = 1;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.Leave += new System.EventHandler(this.input_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập một số :";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Result);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(39, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 50);
            this.panel4.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(156, 10);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(387, 29);
            this.Result.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = " Kết quả :";
            // 
            // Lab01_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 293);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lab01_Bai04";
            this.Text = "Bài 04: Đổi hệ cơ số";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ThucHien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox hcsChuyenDoi;
        private System.Windows.Forms.ComboBox hcsBanDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label4;
    }
}