namespace Lab6vle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSoDong = new TextBox();
            txtSoCot = new TextBox();
            label2 = new Label();
            btnKhoiTao = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Số dòng";
            label1.Click += label1_Click;
            // 
            // txtSoDong
            // 
            txtSoDong.Location = new Point(100, 30);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.Size = new Size(100, 23);
            txtSoDong.TabIndex = 1;
            txtSoDong.TextChanged += textBox1_TextChanged;
            // 
            // txtSoCot
            // 
            txtSoCot.Location = new Point(100, 69);
            txtSoCot.Name = "txtSoCot";
            txtSoCot.Size = new Size(100, 23);
            txtSoCot.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Số cột";
            label2.Click += label2_Click;
            // 
            // btnKhoiTao
            // 
            btnKhoiTao.Location = new Point(228, 30);
            btnKhoiTao.Name = "btnKhoiTao";
            btnKhoiTao.Size = new Size(132, 62);
            btnKhoiTao.TabIndex = 4;
            btnKhoiTao.Text = "Khởi tạo form";
            btnKhoiTao.UseVisualStyleBackColor = true;
            btnKhoiTao.Click += btnKhoiTao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(btnKhoiTao);
            Controls.Add(label2);
            Controls.Add(txtSoCot);
            Controls.Add(txtSoDong);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSoDong;
        private TextBox txtSoCot;
        private Label label2;
        private Button btnKhoiTao;
    }
}
