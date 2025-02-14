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

namespace lksDEMAK.Modul_Guru
{
    public partial class FormPemberianIjin : Form
    {
        public int id;
        SqlConnection conn = Helper.GetConn();
        public FormPemberianIjin()
        {
            InitializeComponent();
        }

        private void btnCariData_Click(object sender, EventArgs e)
        {
          
            int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Open();
            SqlCommand cmd = new SqlCommand("select keterangan from SiswaIjinKeluarTable where id_siswa = '"+input+"'", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtKeterangan.Text = rd["keterangan"].ToString();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Data Tidak Ditemukan!");
            }
            conn.Close();
        }
       
        private void FormPemberianIjin_Load(object sender, EventArgs e)
        {
         
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from gurutable where role = 'BK' and id_guru ='"+id+"' ", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {

            }
            else
            {
                MessageBox.Show("anda bukan guru BK, Anda tidak memiliki akses ke Form Ini !!");
                this.Close();
            }
            conn.Close();
        }

        private void btnMengijinkan_Click(object sender, EventArgs e)
        {
            if (txtIDUser.Text == "" || txtKeterangan.Text == "")
            {
                MessageBox.Show("Isi Field Terlebih dahulu");
                return;
            }
            int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Open();
            SqlCommand cmd = new SqlCommand("update siswaijinkeluartable set acc = '1' where id_siswa = '"+input+"'", conn);
            SqlCommand cmdd = new SqlCommand("update siswatable set keluar = '"+DateTime.Now+"' where id_siswa = '" + input + "'", conn);
            cmd.ExecuteNonQuery();
            cmdd.ExecuteNonQuery();
            MessageBox.Show("memberi ijin ke siswa");
            txtIDUser.Clear();
        }

        private void btnMenolak_Click(object sender, EventArgs e)
        {

            if (txtIDUser.Text == "" || txtKeterangan.Text == "")
            {
                MessageBox.Show("Isi Field Terlebih dahulu");
                return;
            }
            txtKeterangan.Clear(); int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Open();
            SqlCommand cmd = new SqlCommand("update siswaijinkeluartable set acc = '0' where id_siswa = '"+input+"'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("tidak memberi ijin ke siswa");
            txtIDUser.Clear();
            txtKeterangan.Clear();

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            if (txtIDUser.Text == "" || txtKeterangan.Text == "")
            {
                MessageBox.Show("Isi Field Terlebih dahulu");
                return;
            }
            int input = int.Parse(txtIDUser.Text.Substring(1));
            conn.Open();
          
            SqlCommand cmd = new SqlCommand("update siswatable set keluar = NULL where id_siswa = '" + input + "'", conn);
            SqlCommand cmdd = new SqlCommand("delete from siswaijinkeluartable where id_siswa = '" + input + "'", conn);
            cmd.ExecuteNonQuery();
            cmdd.ExecuteNonQuery();
           
            MessageBox.Show("Berhasil Memperbarui data");
            txtIDUser.Clear();
            txtKeterangan.Clear();
        }
    }
}
