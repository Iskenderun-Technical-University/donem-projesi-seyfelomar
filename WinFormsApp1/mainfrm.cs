using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace WinFormsApp1
{
    public partial class mainfrm : Form
    {
        public mainfrm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data source =.\SQLEXPRESS ; Initial Catalog = DBproject; Integrated Security = true ;");

        public void loadform(object form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();

        }
        private void homebtn_Click(object sender, EventArgs e)
        {
            loadform(new minfrm());
        }

        private void myaccbtn_Click(object sender, EventArgs e)
        {
            loadform(new myacc());


        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            mainfrm frm = new mainfrm();
            frm.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainfrm_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void mainfrm_Resize(object sender, EventArgs e)
        {
            /* int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);

            int r = (this.Width - panel2.Width) / 2;
            int q = (this.Height - panel2.Height) / 2;
            panel2.Location = new Point(r, q);

            */
        }
    }
}
