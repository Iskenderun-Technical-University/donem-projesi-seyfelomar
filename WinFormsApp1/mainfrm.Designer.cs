namespace WinFormsApp1
{
    partial class mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            panel1 = new Panel();
            logoutbtn = new Button();
            orderbtn = new Button();
            myaccbtn = new Button();
            homebtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            wrisbtn = new Button();
            pcbtn = new Button();
            phonebtn = new Button();
            clothbtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(logoutbtn);
            panel1.Controls.Add(orderbtn);
            panel1.Controls.Add(myaccbtn);
            panel1.Controls.Add(homebtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 505);
            panel1.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Firebrick;
            logoutbtn.Cursor = Cursors.Hand;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.ForeColor = SystemColors.ButtonHighlight;
            logoutbtn.Image = Properties.Resources.icons8_sort_left_30;
            logoutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutbtn.Location = new Point(0, 445);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(140, 54);
            logoutbtn.TabIndex = 1;
            logoutbtn.Text = "Log out";
            logoutbtn.UseVisualStyleBackColor = false;
            // 
            // orderbtn
            // 
            orderbtn.BackColor = Color.Firebrick;
            orderbtn.Cursor = Cursors.Hand;
            orderbtn.FlatAppearance.BorderSize = 0;
            orderbtn.FlatStyle = FlatStyle.Flat;
            orderbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderbtn.ForeColor = SystemColors.ButtonHighlight;
            orderbtn.Image = Properties.Resources.icons8_shopping_bag_30;
            orderbtn.ImageAlign = ContentAlignment.MiddleLeft;
            orderbtn.Location = new Point(0, 121);
            orderbtn.Name = "orderbtn";
            orderbtn.Size = new Size(137, 53);
            orderbtn.TabIndex = 1;
            orderbtn.Text = " My order";
            orderbtn.UseVisualStyleBackColor = false;
            // 
            // myaccbtn
            // 
            myaccbtn.BackColor = Color.Firebrick;
            myaccbtn.Cursor = Cursors.Hand;
            myaccbtn.FlatAppearance.BorderSize = 0;
            myaccbtn.FlatStyle = FlatStyle.Flat;
            myaccbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            myaccbtn.ForeColor = SystemColors.ButtonHighlight;
            myaccbtn.Image = Properties.Resources.icons8_account_30;
            myaccbtn.ImageAlign = ContentAlignment.MiddleLeft;
            myaccbtn.Location = new Point(-3, 62);
            myaccbtn.Name = "myaccbtn";
            myaccbtn.Size = new Size(137, 53);
            myaccbtn.TabIndex = 1;
            myaccbtn.Text = "       My account";
            myaccbtn.UseVisualStyleBackColor = false;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.Firebrick;
            homebtn.Cursor = Cursors.Hand;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            homebtn.ForeColor = SystemColors.ButtonHighlight;
            homebtn.Image = Properties.Resources.icons8_home_30;
            homebtn.ImageAlign = ContentAlignment.MiddleLeft;
            homebtn.Location = new Point(0, 3);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(137, 53);
            homebtn.TabIndex = 1;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(phonebtn);
            panel2.Controls.Add(clothbtn);
            panel2.Controls.Add(pcbtn);
            panel2.Controls.Add(wrisbtn);
            panel2.Location = new Point(137, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 490);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 10);
            label1.Name = "label1";
            label1.Size = new Size(637, 49);
            label1.TabIndex = 1;
            label1.Text = "WHAT ARE YOU LOOKING FOR";
            // 
            // wrisbtn
            // 
            wrisbtn.FlatAppearance.BorderSize = 0;
            wrisbtn.FlatStyle = FlatStyle.Flat;
            wrisbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            wrisbtn.Image = Properties.Resources.icons8_watches_front_view_100;
            wrisbtn.Location = new Point(57, 96);
            wrisbtn.Name = "wrisbtn";
            wrisbtn.Size = new Size(192, 160);
            wrisbtn.TabIndex = 0;
            wrisbtn.Text = "Wristwatch";
            wrisbtn.TextAlign = ContentAlignment.TopCenter;
            wrisbtn.UseVisualStyleBackColor = true;
            // 
            // pcbtn
            // 
            pcbtn.FlatAppearance.BorderSize = 0;
            pcbtn.FlatStyle = FlatStyle.Flat;
            pcbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pcbtn.Image = (Image)resources.GetObject("pcbtn.Image");
            pcbtn.Location = new Point(429, 301);
            pcbtn.Name = "pcbtn";
            pcbtn.Size = new Size(192, 160);
            pcbtn.TabIndex = 0;
            pcbtn.Text = "PC";
            pcbtn.TextAlign = ContentAlignment.TopCenter;
            pcbtn.UseVisualStyleBackColor = true;
            // 
            // phonebtn
            // 
            phonebtn.FlatAppearance.BorderSize = 0;
            phonebtn.FlatStyle = FlatStyle.Flat;
            phonebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phonebtn.Image = (Image)resources.GetObject("phonebtn.Image");
            phonebtn.Location = new Point(68, 301);
            phonebtn.Name = "phonebtn";
            phonebtn.Size = new Size(192, 160);
            phonebtn.TabIndex = 0;
            phonebtn.Text = "Phones";
            phonebtn.TextAlign = ContentAlignment.TopCenter;
            phonebtn.UseVisualStyleBackColor = true;
            // 
            // clothbtn
            // 
            clothbtn.FlatAppearance.BorderSize = 0;
            clothbtn.FlatStyle = FlatStyle.Flat;
            clothbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clothbtn.Image = (Image)resources.GetObject("clothbtn.Image");
            clothbtn.Location = new Point(429, 96);
            clothbtn.Name = "clothbtn";
            clothbtn.Size = new Size(192, 160);
            clothbtn.TabIndex = 0;
            clothbtn.Text = "Clothes";
            clothbtn.TextAlign = ContentAlignment.TopCenter;
            clothbtn.UseVisualStyleBackColor = true;
            // 
            // mainfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 494);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "mainfrm";
            Text = "mainfrm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button logoutbtn;
        private Button orderbtn;
        private Button myaccbtn;
        private Button homebtn;
        private Panel panel2;
        private Label label1;
        private Button wrisbtn;
        private Button phonebtn;
        private Button clothbtn;
        private Button pcbtn;
    }
}