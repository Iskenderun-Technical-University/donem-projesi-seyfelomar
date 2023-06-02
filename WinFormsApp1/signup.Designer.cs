namespace WinFormsApp1
{
    partial class signup
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
            label1 = new Label();
            u_textbox = new TextBox();
            pass_textbox = new TextBox();
            phone_textbox = new TextBox();
            e_textbox = new TextBox();
            ad_textbox = new TextBox();
            u = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(267, 63);
            label1.Name = "label1";
            label1.Size = new Size(224, 43);
            label1.TabIndex = 1;
            label1.Text = "ISTE_STORE";
            // 
            // u_textbox
            // 
            u_textbox.Location = new Point(174, 162);
            u_textbox.Name = "u_textbox";
            u_textbox.Size = new Size(176, 27);
            u_textbox.TabIndex = 2;
            // 
            // pass_textbox
            // 
            pass_textbox.Location = new Point(174, 210);
            pass_textbox.Name = "pass_textbox";
            pass_textbox.Size = new Size(176, 27);
            pass_textbox.TabIndex = 2;
            // 
            // phone_textbox
            // 
            phone_textbox.Location = new Point(174, 252);
            phone_textbox.Name = "phone_textbox";
            phone_textbox.Size = new Size(176, 27);
            phone_textbox.TabIndex = 2;
            // 
            // e_textbox
            // 
            e_textbox.Location = new Point(174, 294);
            e_textbox.Name = "e_textbox";
            e_textbox.Size = new Size(176, 27);
            e_textbox.TabIndex = 2;
            // 
            // ad_textbox
            // 
            ad_textbox.Location = new Point(174, 341);
            ad_textbox.Name = "ad_textbox";
            ad_textbox.Size = new Size(176, 27);
            ad_textbox.TabIndex = 2;
            // 
            // u
            // 
            u.AutoSize = true;
            u.Location = new Point(32, 169);
            u.Name = "u";
            u.Size = new Size(86, 20);
            u.TabIndex = 3;
            u.Text = "User name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 217);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 259);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone number :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 301);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 3;
            label5.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 348);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 3;
            label6.Text = "Adrees :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 24);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(2, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 24);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(571, 371);
            button1.Name = "button1";
            button1.Size = new Size(150, 37);
            button1.TabIndex = 6;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(u);
            Controls.Add(ad_textbox);
            Controls.Add(e_textbox);
            Controls.Add(phone_textbox);
            Controls.Add(pass_textbox);
            Controls.Add(u_textbox);
            Controls.Add(label1);
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox u_textbox;
        private TextBox pass_textbox;
        private TextBox phone_textbox;
        private TextBox e_textbox;
        private TextBox ad_textbox;
        private Label u;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
    }
}