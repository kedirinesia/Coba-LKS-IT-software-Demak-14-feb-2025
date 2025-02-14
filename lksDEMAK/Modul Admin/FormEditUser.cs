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
    public partial class FormEditUser : Form
    {SqlConnection conn = Helper.GetConn();
        public FormEditUser()
        {
            InitializeComponent();
        }

        private void btnCariUser_Click(object sender, EventArgs e)
        {
            if(txtIDUser.Text ==""|| txtIDUser.Text == "")
            {
                MessageBox.Show("Isi Field dulu");
                return;
            }
            int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Close();
            conn.Open();
            if(comboBox1.Text == "Siswa")
            {
               SqlCommand cmd = new SqlCommand("select * from siswatable where id_siswa = '"+input+"'",conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                { 
                
                    txtNama.Text = rd["nama"].ToString();
                    txtNama.Enabled = true;

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("data tidak ditemukan ");
                    txtNama.Enabled = false;
                    conn.Close();
                }

            }else if(comboBox1.Text == "Guru")
            {
                SqlCommand cmd = new SqlCommand("select * from gurutable where id_guru = '" + input + "'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                  
                    txtNama.Text = rd["nama"].ToString();
                    txtNama.Enabled = true;
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("data tidak ditemukan ");
                    txtNama.Enabled = false;
                    conn.Close();
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (txtIDUser.Text == "" || txtIDUser.Text == "")
            {
                MessageBox.Show("Isi Field dulu");
                return;
            }
            int input = int.Parse(txtIDUser.Text.Substring(1));
          
            if (comboBox1.Text == "Siswa")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update siswatable set nama = '"+txtNama.Text+"' where id_siswa = '"+input+"'", conn);
               cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil melakukan edit");
                txtIDUser.Clear();
                txtNama.Clear();
                comboBox1.Text = "";
                conn.Close();
            }else if(comboBox1.Text == "Guru")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update gurutable set nama = '" + txtNama.Text + "' where id_guru = '" + input + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil melakukan edit");
                txtIDUser.Clear();
                txtNama.Clear();
                comboBox1.Text = "";
                conn.Close();
                 
            }
        }
    }
}
