
namespace QuanLySoTietKiem
{
    partial class flogin
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
            this.DangNhap = new System.Windows.Forms.Panel();
            this.DNbutton3 = new System.Windows.Forms.Button();
            this.DNbutton1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DNbutton2 = new System.Windows.Forms.Button();
            this.DangNhap.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DangNhap
            // 
            this.DangNhap.Controls.Add(this.DNbutton2);
            this.DangNhap.Controls.Add(this.DNbutton3);
            this.DangNhap.Controls.Add(this.DNbutton1);
            this.DangNhap.Controls.Add(this.panel3);
            this.DangNhap.Controls.Add(this.panel2);
            this.DangNhap.Location = new System.Drawing.Point(38, 39);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(600, 380);
            this.DangNhap.TabIndex = 0;
            // 
            // DNbutton3
            // 
            this.DNbutton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNbutton3.Location = new System.Drawing.Point(413, 292);
            this.DNbutton3.Name = "DNbutton3";
            this.DNbutton3.Size = new System.Drawing.Size(131, 37);
            this.DNbutton3.TabIndex = 4;
            this.DNbutton3.Text = "Thoát";
            this.DNbutton3.UseVisualStyleBackColor = true;
            this.DNbutton3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DNbutton1
            // 
            this.DNbutton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNbutton1.Location = new System.Drawing.Point(59, 292);
            this.DNbutton1.Name = "DNbutton1";
            this.DNbutton1.Size = new System.Drawing.Size(131, 37);
            this.DNbutton1.TabIndex = 2;
            this.DNbutton1.Text = "Đăng Nhập";
            this.DNbutton1.UseVisualStyleBackColor = true;
            this.DNbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(8, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 75);
            this.panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 75);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập: ";
            // 
            // DNbutton2
            // 
            this.DNbutton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNbutton2.Location = new System.Drawing.Point(241, 292);
            this.DNbutton2.Name = "DNbutton2";
            this.DNbutton2.Size = new System.Drawing.Size(131, 37);
            this.DNbutton2.TabIndex = 5;
            this.DNbutton2.Text = "Đăng Ký";
            this.DNbutton2.UseVisualStyleBackColor = true;
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 456);
            this.Controls.Add(this.DangNhap);
            this.Name = "flogin";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DangNhap.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DNbutton3;
        private System.Windows.Forms.Button DNbutton1;
        private System.Windows.Forms.Button DNbutton2;
    }
}

