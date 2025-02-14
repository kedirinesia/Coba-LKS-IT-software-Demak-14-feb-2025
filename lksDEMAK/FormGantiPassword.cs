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

namespace lksDEMAK
{
    public partial class FormGantiPassword : Form
    {
       public  int id;
        public int status;
        SqlConnection conn = Helper.GetConn();
        public FormGantiPassword()
        {
            InitializeComponent();
        }

        private void FormGantiPassword_Load(object sender, EventArgs e)
        {
            if (status == 1)
            {
                txtIDUser.Text ="S"+ id.ToString();
            }
            if(status == 2)
            {
                txtIDUser.Text ="G"+ id.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtIDUser.Text == "" || txtPasswordlama.Text == "" || txtPasswordBaru.Text == "")
            {
                MessageBox.Show("isi semua field terlebih dahulu");
                return;
            }
            int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Open();
            if(status == 1)
            {
                SqlCommand cmd = new SqlCommand("select * from siswatable where id_siswa = '"+input+"' and password ='"+txtPasswordlama.Text+"' ",conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand update = new SqlCommand("update siswatable set password = '"+txtPasswordBaru.Text+"'  where id_siswa= '"+input+"'",conn);
                    update.ExecuteNonQuery();
                    MessageBox.Show("berhasil merubah password");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password lama salah !!!");
                }
            }
           else if(status == 2)
            {
                SqlCommand cmd = new SqlCommand("select * from gurutable where id_guru ='"+input+"' and password ='"+txtPasswordlama.Text+"'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    conn.Close();
                    conn.Open();
                    SqlCommand update = new SqlCommand("update gurutable set password ='" + txtPasswordBaru.Text + "' where id_guru = '" + id + "'", conn);
                    update.ExecuteNonQuery();
                    MessageBox.Show("berhasil merubah password");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Password Lama salah");
            }
        }
    }
}
