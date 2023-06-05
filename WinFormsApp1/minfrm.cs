using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class minfrm : Form
    {
        public minfrm()
        {
            InitializeComponent();
        }

        private void pcbtn_Click(object sender, EventArgs e)
        {
            pcfrm pcfrm = new pcfrm();
            pcfrm.Show();   
        }

        private void wrisbtn_Click(object sender, EventArgs e)
        {
            whatcfrm frm = new whatcfrm();

            frm.Show();
        }

        private void clothbtn_Click(object sender, EventArgs e)
        {
            clofrm frm = new clofrm();
            frm.Show();
        }
    }
}
