using lksDEMAK;
using lksDEMAK.Modul_Siswa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_KABUPATEN_DEMAK.Modul_Siswa
{
    public partial class FormSiswa : Form
    {
        public static int Id {  get; set; }
        public FormSiswa()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 Presensi = new Form1();
            Presensi.Show();
            this.Close();
        }

        private void btnLihatPresensi_Click(object sender, EventArgs e)
        {
            FormLihatPresensi formLihatPresensi = new FormLihatPresensi();
            formLihatPresensi.status = 1;
            formLihatPresensi.Show();

        }

        private void btnGantiPassword_Click(object sender, EventArgs e)
        {
            FormGantiPassword formGantiPassword = new FormGantiPassword();
            formGantiPassword.status = 1;
            formGantiPassword.id = Id;

            formGantiPassword.Show();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(Id.ToString());
        }

        private void btnIjinKeluar_Click(object sender, EventArgs e)
        {
            FormIjinKeluar formIjinKeluar = new FormIjinKeluar();
            formIjinKeluar.id = Id;
            formIjinKeluar.Show();
        }
    }
}
