
namespace Lab01
{
    partial class Lab01_Bai01
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            System.Windows.Forms.Panel panel3;
            this.label1 = new System.Windows.Forms.Label();
            this.intNumber1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intNumber2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.intResult = new System.Windows.Forms.TextBox();
            this.Tinh = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.label1);
            panel1.Controls.Add(this.intNumber1);
            panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel1.Location = new System.Drawing.Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(604, 54);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ nhất";
            // 
            // intNumber1
            // 
            this.intNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNumber1.Location = new System.Drawing.Point(233, 11);
            this.intNumber1.Name = "intNumber1";
            this.intNumber1.Size = new System.Drawing.Size(266, 31);
            this.intNumber1.TabIndex = 0;
            this.intNumber1.TextChanged += new System.EventHandler(this.intNumber1_TextChanged);
            this.intNumber1.Leave += new System.EventHandler(this.intNumber1_Leave);
            // 
            // panel2
            // 
            panel2.Controls.Add(this.label2);
            panel2.Controls.Add(this.intNumber2);
            panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel2.Location = new System.Drawing.Point(12, 103);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(604, 54);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai";
            // 
            // intNumber2
            // 
            this.intNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intNumber2.Location = new System.Drawing.Point(233, 11);
            this.intNumber2.Name = "intNumber2";
            this.intNumber2.Size = new System.Drawing.Size(266, 31);
            this.intNumber2.TabIndex = 0;
            this.intNumber2.TextChanged += new System.EventHandler(this.intNumber2_TextChanged);
            this.intNumber2.Leave += new System.EventHandler(this.intNumber2_Leave);
            // 
            // panel3
            // 
            panel3.Controls.Add(this.Result);
            panel3.Controls.Add(this.intResult);
            panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panel3.Location = new System.Drawing.Point(12, 163);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(604, 54);
            panel3.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(84, 14);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(86, 25);
            this.Result.TabIndex = 1;
            this.Result.Text = "Kết quả";
            // 
            // intResult
            // 
            this.intResult.Enabled = false;
            this.intResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intResult.Location = new System.Drawing.Point(233, 11);
            this.intResult.Name = "intResult";
            this.intResult.Size = new System.Drawing.Size(266, 31);
            this.intResult.TabIndex = 0;
            // 
            // Tinh
            // 
            this.Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tinh.Location = new System.Drawing.Point(203, 237);
            this.Tinh.Name = "Tinh";
            this.Tinh.Size = new System.Drawing.Size(223, 48);
            this.Tinh.TabIndex = 3;
            this.Tinh.Text = "Tính";
            this.Tinh.UseVisualStyleBackColor = true;
            this.Tinh.Click += new System.EventHandler(this.Tinh_Click);
            // 
            // Lab01_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 297);
            this.Controls.Add(this.Tinh);
            this.Controls.Add(panel3);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.Name = "Lab01_Bai01";
            this.Text = "Bài 01: Tính tổng 2 số nguyên (Có điều kiện)";
            this.Load += new System.EventHandler(this.Lab01_Bai01_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intNumber2;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox intResult;
        private System.Windows.Forms.Button Tinh;
    }
}