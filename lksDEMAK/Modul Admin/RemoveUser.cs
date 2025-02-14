using lksDEMAK;
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

namespace LKS_KABUPATEN_DEMAK.Modul_Admin
{
    public partial class RemoveUser : Form
    { SqlConnection conn = Helper.GetConn();
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void btnCariUser_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("",conn);
        }
    }
}
