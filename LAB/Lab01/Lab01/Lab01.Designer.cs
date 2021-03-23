
namespace Lab01
{
    partial class Lab01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bai02 = new System.Windows.Forms.Button();
            this.Bai01 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bai04 = new System.Windows.Forms.Button();
            this.Bai03 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bai05 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.Bai02);
            this.panel1.Controls.Add(this.Bai01);
            this.panel1.Name = "panel1";
            // 
            // Bai02
            // 
            resources.ApplyResources(this.Bai02, "Bai02");
            this.Bai02.Name = "Bai02";
            this.Bai02.UseVisualStyleBackColor = true;
            this.Bai02.Click += new System.EventHandler(this.Bai02_Click);
            // 
            // Bai01
            // 
            resources.ApplyResources(this.Bai01, "Bai01");
            this.Bai01.Name = "Bai01";
            this.Bai01.UseVisualStyleBackColor = true;
            this.Bai01.Click += new System.EventHandler(this.Bai01_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.Bai04);
            this.panel2.Controls.Add(this.Bai03);
            this.panel2.Name = "panel2";
            // 
            // Bai04
            // 
            resources.ApplyResources(this.Bai04, "Bai04");
            this.Bai04.Name = "Bai04";
            this.Bai04.UseVisualStyleBackColor = true;
            this.Bai04.Click += new System.EventHandler(this.Bai04_Click);
            // 
            // Bai03
            // 
            resources.ApplyResources(this.Bai03, "Bai03");
            this.Bai03.Name = "Bai03";
            this.Bai03.UseVisualStyleBackColor = true;
            this.Bai03.Click += new System.EventHandler(this.Bai03_Click_1);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.Bai05);
            this.panel3.Name = "panel3";
            // 
            // Bai05
            // 
            resources.ApplyResources(this.Bai05, "Bai05");
            this.Bai05.Name = "Bai05";
            this.Bai05.UseVisualStyleBackColor = true;
            this.Bai05.Click += new System.EventHandler(this.Bai05_Click);
            // 
            // Lab01
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Lab01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bai02;
        private System.Windows.Forms.Button Bai01;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bai04;
        private System.Windows.Forms.Button Bai03;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Bai05;
    }
}

