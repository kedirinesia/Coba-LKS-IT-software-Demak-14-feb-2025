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
    public partial class FormTambahUser : Form
    {
        SqlConnection conn = Helper.GetConn();
        public FormTambahUser()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Open();
            if(comboBox1.Text == "BK")
            {
               SqlCommand cmd = new SqlCommand("select * from gurutable where id_guru = '"+input+"'",conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd.Read())
                {
                    MessageBox.Show("data sudah ada");
                    conn.Close();
                    return;
                }
                else
                {
                    rd.Close();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmdInsert = new SqlCommand("insert into GuruTable (id_guru, nama, password, role) values ('"+input+"', '"+txtNama.Text+"', '"+txtPassword.Text+"', '"+comboBox1.Text+"')", conn);
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("berhasil membuat akun BK");
                    txtIDUser.Clear();
                    txtNama.Clear();
                    txtPassword.Clear();
                    conn.Close();
                }

            }else if(comboBox1.Text == "GURU")
            {

                SqlCommand cmd = new SqlCommand("select * from gurutable where id_guru = '" + input + "'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("data sudah ada");
                    conn.Close();
                    return;
                }
                else
                {
                    rd.Close();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmdInsert = new SqlCommand("insert into GuruTable (id_guru, nama, password, role) values ('" + input + "', '" + txtNama.Text + "', '" + txtPassword.Text + "', '" + comboBox1.Text + "')", conn);
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("berhasil membuat akun GURU");
                    txtIDUser.Clear();
                    txtNama.Clear();
                    txtPassword.Clear();
                    conn.Close();
                }

            }
            else if(comboBox1.Text == "SISWA")
            {
                SqlCommand cmd = new SqlCommand("select * from siswatable where id_siswa = '" + input + "'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    MessageBox.Show("data sudah ada");
                    conn.Close();
                    return;
                }
                else
                {
                    rd.Close();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmdInsert = new SqlCommand("insert into siswatable (id_siswa, nama, password) values ('" + input + "', '" + txtNama.Text + "', '" + txtPassword.Text + "')", conn);
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("berhasil membuat akun SISWA");
                    txtIDUser.Clear();
                    txtNama.Clear();
                    txtPassword.Clear();
                    conn.Close();
                }
            }conn.Close();
        }
        
    }
}
