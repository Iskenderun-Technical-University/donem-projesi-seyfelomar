namespace WinFormsApp1
{
    partial class myacc
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblusername = new Label();
            lblph = new Label();
            lblemail = new Label();
            lbladrees = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(47, 129);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 0;
            label2.Text = "User name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(47, 186);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 0;
            label3.Text = "Phone number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(47, 238);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 0;
            label4.Text = "E-mail :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(47, 292);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 0;
            label5.Text = "Adrees :";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblusername.Location = new Point(171, 129);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(0, 28);
            lblusername.TabIndex = 1;
            // 
            // lblph
            // 
            lblph.AutoSize = true;
            lblph.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblph.Location = new Point(208, 186);
            lblph.Name = "lblph";
            lblph.Size = new Size(0, 28);
            lblph.TabIndex = 1;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblemail.Location = new Point(144, 238);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(0, 28);
            lblemail.TabIndex = 1;
            // 
            // lbladrees
            // 
            lbladrees.AutoSize = true;
            lbladrees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbladrees.Location = new Point(135, 292);
            lbladrees.Name = "lbladrees";
            lbladrees.Size = new Size(0, 28);
            lbladrees.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(606, 377);
            button1.Name = "button1";
            button1.Size = new Size(160, 51);
            button1.TabIndex = 2;
            button1.Text = "Show my data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // myacc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lbladrees);
            Controls.Add(lblemail);
            Controls.Add(lblph);
            Controls.Add(lblusername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "myacc";
            Text = "myacc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblusername;
        private Label lblph;
        private Label lblemail;
        private Label lbladrees;
        private Button button1;
    }
}