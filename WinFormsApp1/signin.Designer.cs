namespace WinFormsApp1
{
    partial class signin
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
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 502);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(404, 418);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 6;
            label6.Text = "Create account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 416);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 5;
            label5.Text = "Don't have an account :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(274, 271);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 4;
            label4.Text = "Password :";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(274, 202);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 4;
            label3.Text = "Username :";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 27);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(274, 339);
            button1.Name = "button1";
            button1.Size = new Size(162, 28);
            button1.TabIndex = 2;
            button1.Text = "Sign in";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(244, 63);
            label2.Name = "label2";
            label2.Size = new Size(237, 43);
            label2.TabIndex = 1;
            label2.Text = "WELCOME TO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(244, 118);
            label1.Name = "label1";
            label1.Size = new Size(224, 43);
            label1.TabIndex = 0;
            label1.Text = "ISTE_STORE";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(1, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(1192, 24);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(1, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 24);
            panel2.TabIndex = 2;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 570);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "signin";
            Text = "ISTE STORE";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
    }
}