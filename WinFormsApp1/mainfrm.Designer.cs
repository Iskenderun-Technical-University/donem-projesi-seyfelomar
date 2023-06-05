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
            panel1 = new Panel();
            myaccbtn = new Button();
            homebtn = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(myaccbtn);
            panel1.Controls.Add(homebtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 656);
            panel1.TabIndex = 0;
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
            myaccbtn.Location = new Point(0, 190);
            myaccbtn.Name = "myaccbtn";
            myaccbtn.Size = new Size(130, 102);
            myaccbtn.TabIndex = 1;
            myaccbtn.Text = "       My account";
            myaccbtn.UseVisualStyleBackColor = false;
            myaccbtn.Click += myaccbtn_Click;
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
            homebtn.Size = new Size(127, 102);
            homebtn.TabIndex = 1;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(127, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1037, 656);
            panel2.TabIndex = 1;
            // 
            // mainfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 656);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "mainfrm";
            Text = "mainfrm";
            Load += mainfrm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button myaccbtn;
        private Button homebtn;
        private Panel panel2;
    }
}