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

namespace lksDEMAK.Modul_Siswa
{
    public partial class FormIjinKeluar : Form
    {
        public int id;
        public FormIjinKeluar()
        {
            InitializeComponent();
        }

        private void FormIjinKeluar_Load(object sender, EventArgs e)
        {
            txtIDUser.Text = "S"+id.ToString();

        }

        private void btnIjin_Click(object sender, EventArgs e)
        {
            if(txtIDUser.Text == "" || txtKeterangan.Text == "")
            {
                MessageBox.Show("Isi Field terlebih dahulu");
                return;
            }
            int input= int.Parse(txtIDUser.Text.Substring(1));
            SqlConnection conn = Helper.GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into SiswaIjinKeluarTable(id_siswa, keterangan, waku_pengajuan) values ('" + input+"', '"+txtKeterangan.Text+"', '"+DateTime.Now+"')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("berhasil mengajukan ijin keluar");
            this.Close();
        }
    }
}
