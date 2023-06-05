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
using System.IO;
namespace WinFormsApp1
{
    public partial class signinfrm : Form
    {
        public signinfrm()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data source =.\SQLEXPRESS ; Initial Catalog = DBproject; Integrated Security = true ;");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signinfrm_Load(object sender, EventArgs e)
        {

        }


        private void signinfrm_Resize(object sender, EventArgs e)
        {
            int x = (this.Width - panel1.Width) / 2;
            int y = (this.Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);

            int r = (this.Width - panel2.Width) / 2;
            int q = (this.Height - panel2.Height) / 2;
            panel2.Location = new Point(r, q);

            int k = (this.Width - panel3.Width) / 2;
            int j = (this.Height - panel3.Height) / 2;
            panel3.Location = new Point(k, j);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            signup frm = new signup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void singinbtn_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            StreamWriter sw = new StreamWriter("user.txt");
            sw.Write(username);
            sw.Close();

            SqlCommand cmd = new SqlCommand("select * from users", con);
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();


            while (reader.Read())
            {



                if (username.Equals(reader["username"].ToString()))
                {
                    if (password.Equals(reader["password"].ToString()))
                    {
                        mainfrm frm = new mainfrm();
                        frm.ShowDialog();
                        break;
                    }
                }
                else if (!reader.Read())
                {
                    MessageBox.Show("username or password incorrect");
                }

            }
            con.Close();

        }
    }
}
