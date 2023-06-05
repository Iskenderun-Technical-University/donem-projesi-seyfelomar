namespace WinFormsApp1
{
    partial class minfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minfrm));
            label1 = new Label();
            clothbtn = new Button();
            pcbtn = new Button();
            wrisbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(637, 49);
            label1.TabIndex = 6;
            label1.Text = "WHAT ARE YOU LOOKING FOR";
            // 
            // clothbtn
            // 
            clothbtn.Anchor = AnchorStyles.None;
            clothbtn.FlatAppearance.BorderSize = 0;
            clothbtn.FlatStyle = FlatStyle.Flat;
            clothbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            clothbtn.Image = (Image)resources.GetObject("clothbtn.Image");
            clothbtn.Location = new Point(661, 91);
            clothbtn.Name = "clothbtn";
            clothbtn.Size = new Size(304, 237);
            clothbtn.TabIndex = 3;
            clothbtn.Text = "Clothes";
            clothbtn.TextAlign = ContentAlignment.TopCenter;
            clothbtn.UseVisualStyleBackColor = true;
            clothbtn.Click += clothbtn_Click;
            // 
            // pcbtn
            // 
            pcbtn.Anchor = AnchorStyles.None;
            pcbtn.FlatAppearance.BorderSize = 0;
            pcbtn.FlatStyle = FlatStyle.Flat;
            pcbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pcbtn.Image = (Image)resources.GetObject("pcbtn.Image");
            pcbtn.Location = new Point(377, 354);
            pcbtn.Name = "pcbtn";
            pcbtn.Size = new Size(304, 237);
            pcbtn.TabIndex = 4;
            pcbtn.Text = "PC";
            pcbtn.TextAlign = ContentAlignment.TopCenter;
            pcbtn.UseVisualStyleBackColor = true;
            pcbtn.Click += pcbtn_Click;
            // 
            // wrisbtn
            // 
            wrisbtn.Anchor = AnchorStyles.None;
            wrisbtn.FlatAppearance.BorderSize = 0;
            wrisbtn.FlatStyle = FlatStyle.Flat;
            wrisbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            wrisbtn.Image = Properties.Resources.icons8_watches_front_view_100;
            wrisbtn.Location = new Point(130, 91);
            wrisbtn.Name = "wrisbtn";
            wrisbtn.Size = new Size(304, 237);
            wrisbtn.TabIndex = 5;
            wrisbtn.Text = "Wristwatch";
            wrisbtn.TextAlign = ContentAlignment.TopCenter;
            wrisbtn.UseVisualStyleBackColor = true;
            wrisbtn.Click += wrisbtn_Click;
            // 
            // minfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 559);
            Controls.Add(label1);
            Controls.Add(clothbtn);
            Controls.Add(pcbtn);
            Controls.Add(wrisbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "minfrm";
            Text = "minfrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button clothbtn;
        private Button pcbtn;
        private Button wrisbtn;
    }
}