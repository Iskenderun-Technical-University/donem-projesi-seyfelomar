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
namespace WinFormsApp1
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data source =.\SQLEXPRESS ; Initial Catalog = DBproject; Integrated Security = true ;");
        private void button1_Click(object sender, EventArgs e)
        {
            /* string id = idtextbox.Text;
             string stru = u_textbox.Text;
             string strpass = pass_textbox.Text;
             string strphone = phone_textbox.Text;
             string stre = e_textbox.Text;
             string strad = ad_textbox.Text;
            */


            string sql = "insert into users values ( @username , @password , @phonenumber , @email , @adrees)";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@username", u_textbox.Text);
            cmd.Parameters.AddWithValue("@password", pass_textbox.Text);
            cmd.Parameters.AddWithValue("@phonenumber", e_textbox.Text);
            cmd.Parameters.AddWithValue("@email", phone_textbox.Text);
            cmd.Parameters.AddWithValue("@adrees", ad_textbox.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Registered");


        }
    }
}
