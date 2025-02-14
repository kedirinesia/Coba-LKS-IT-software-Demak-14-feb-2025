using LKS_KABUPATEN_DEMAK.Modul_Admin;
using LKS_KABUPATEN_DEMAK.Modul_Siswa;
using lksDEMAK;
using lksDEMAK.Modul_Guru;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_KABUPATEN_DEMAK
{
    public partial class FormLogin : Form
    {
        SqlConnection conn = Helper.GetConn();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id =int.Parse( txtIDUser.Text.Substring(1));
            
           conn.Open();
            SqlCommand cmdSiswa = new SqlCommand("select id_siswa from SiswaTable  where id_siswa ='"+id+"' and password = '"+txtPassword.Text+"'", conn);
            SqlDataReader rdSiswa = cmdSiswa.ExecuteReader();
            if (rdSiswa.Read())
            { 
                FormSiswa formSiswa = new FormSiswa();
                FormSiswa.Id = id;
                formSiswa.Show();
                MessageBox.Show("Berhasil Login Sebagai Siswa" );
                this.Hide();
                return;
            }
            rdSiswa.Close();
            SqlCommand cmdGuru = new SqlCommand("select id_guru from gurutable where id_guru = '"+id+"'  and password = '"+txtPassword.Text+"' ", conn);
            SqlDataReader rdGuru = cmdGuru.ExecuteReader();
            if (rdGuru.Read())
            {
                FormGuru formGuru = new FormGuru();
                formGuru.id = id;
                formGuru.Show();
                MessageBox.Show("berhasil Login Sebagai Guru");
                this.Hide();
                return;
            }
            rdGuru.Close();
            SqlCommand cmdAdmin = new SqlCommand("select id_admin from AdminTable where id_admin = '"+id +"' and password ='"+txtPassword.Text+"'  ", conn);
            SqlDataReader rdAdmin = cmdAdmin.ExecuteReader();
            if(rdAdmin.Read())
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                MessageBox.Show("Berhasil login sebagai Admin");
                this.Hide();
                rdAdmin.Close();
                return;
            }

            else
            {
                MessageBox.Show("akun tidak ditemukan");
            }
            conn.Close();

        }
    }
}
