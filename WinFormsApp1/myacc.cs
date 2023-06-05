using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class myacc : Form
    {
        public myacc()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data source =.\SQLEXPRESS ; Initial Catalog = DBproject; Integrated Security = true ;");



        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("user.txt");
            string str = sr.ReadToEnd();
            sr.Close();

            SqlCommand cmd = new SqlCommand("select * from users", con);
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (str.Equals(reader["username"].ToString()))
                {
                    lblusername.Text = reader["username"].ToString();
                    lblph.Text = reader["phonenumber"].ToString();
                    lblemail.Text = reader["email"].ToString();
                    lbladrees.Text = reader["adrees"].ToString();
                    break;
                }

            }
        }
    }
}
