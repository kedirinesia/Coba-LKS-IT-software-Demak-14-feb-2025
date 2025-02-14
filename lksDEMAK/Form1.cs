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

namespace LKS_KABUPATEN_DEMAK
{
    public partial class Form1 : Form
    {
        int IdGuru;
        int IdSiswa;
        int? input = null;
        SqlConnection conn = Helper.GetConn();
        int TotalSiswa;
        int TotalSiswaHadir;
        int TotalSiswaBelumhadir ;
        int ijinKeluar;
        int siswaReal;
        public Form1()
        {
            InitializeComponent();
        }
        void DaftarPresensi()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS jumlah FROM SiswaTable", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                TotalSiswa = int.Parse(rd["jumlah"].ToString());
            }
            rd.Close();  

            SqlCommand cmdHadir = new SqlCommand("SELECT COUNT(masuk) AS hadir FROM SiswaTable", conn);
            SqlDataReader rdHadir = cmdHadir.ExecuteReader();
            if (rdHadir.Read())
            {
                TotalSiswaHadir = int.Parse(rdHadir["hadir"].ToString());
            }
            rdHadir.Close();

            SqlCommand cmdijinKeluar = new SqlCommand("SELECT COUNT(keluar) AS ijinKeluar FROM SiswaTable", conn);
            SqlDataReader rdijiKeluar = cmdijinKeluar.ExecuteReader();
            if (rdijiKeluar.Read())
            {
                ijinKeluar = int.Parse(rdijiKeluar["ijinKeluar"].ToString());
            }
            rdijiKeluar.Close();
            conn.Close(); 

            TotalSiswaBelumhadir = TotalSiswa - TotalSiswaHadir;
            siswaReal = TotalSiswaHadir - ijinKeluar;

            lblIzinKeluar.Text = ijinKeluar.ToString();
            lblSiswaReal.Text = siswaReal.ToString();
            lblTotalSiswa.Text = TotalSiswa.ToString();
            lblHadir.Text = TotalSiswaHadir.ToString();
            lblBelumHadir.Text = TotalSiswaBelumhadir.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUserID.MaxLength = 5;

            DaftarPresensi();



 
          

        }
        void absenguru()
        {
            input = int.Parse( txtUserID.Text.Substring(1));
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from gurutable where id_guru = '"+input+"'", conn);
           SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                IdGuru =int.Parse( rd["id_guru"].ToString());
                conn.Close();
                rd.Close();
            }
            else
            {
                IdGuru = 0;
                conn.Close();
            }
            rd.Close();
            conn.Close();
        }
        void absensiswa()
        {
            input = int.Parse(txtUserID.Text.Substring(1));
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from siswatable where id_siswa= '" + input + "' ", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                IdSiswa = int.Parse(rd["id_siswa"].ToString());
             
                conn.Close();
                rd.Close();
            }
            else
            {
                IdSiswa = 0;
                conn.Close();
            }
            conn.Close();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Close();

            DateTime jam = DateTime.Now;

            if(txtUserID.Text.Length == 5)
            {
             
                
                absenguru();
                absensiswa();
                conn.Open();

                bool sudahAbsen = true;
           
                SqlCommand cmdCekAbsen = new SqlCommand("SELECT masuk FROM SiswaTable WHERE id_siswa = '"+IdSiswa+"'UNION ALL SELECT masuk FROM GuruTable WHERE id_guru = '"+IdGuru+"'", conn);
                SqlDataReader rdCekAbsen = cmdCekAbsen.ExecuteReader();
                while (rdCekAbsen.Read())
                {
                    if (rdCekAbsen.IsDBNull(0))
                    {
                        rdCekAbsen.Close();
                      
                        if (IdSiswa != 0)
                        {
                            sudahAbsen = false;
                            // MessageBox.Show(IdSiswa.ToString());
                            SqlCommand cmd = new SqlCommand("update siswatable set masuk ='" + jam + "' where id_siswa = '" + IdSiswa + "'", conn);
                            cmd.ExecuteNonQuery();
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                            MessageBox.Show("berhasil absen");

                            return;
                        }
                         if (IdGuru != 0)
                          {
                            sudahAbsen=false;
                            SqlCommand cmd = new SqlCommand("update gurutable set masuk ='" + jam + "' where id_guru = '" + IdGuru + "' ", conn);
                            cmd.ExecuteNonQuery();
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                            MessageBox.Show("berhasil absen");
                            // MessageBox.Show(IdGuru.ToString());
                            return;
                        }
                        

                    }
                    else if(sudahAbsen)
                    {
                        MessageBox.Show("ANDA HARI INI SUDAH ABSEN.~");
                        return;
                    }
                     
                }
                /* MessageBox.Show(IdSiswa.ToString());
                 MessageBox.Show(IdGuru.ToString());*/
               
                if(IdGuru == 0 || IdSiswa == 0) 
                {
                    MessageBox.Show("Data Tidak Ditemukan!~");
                    return;
                }

              //  MessageBox.Show(id);
            }
        }
    }
}
