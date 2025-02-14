using LKS_KABUPATEN_DEMAK;
using LKS_KABUPATEN_DEMAK.Modul_Siswa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lksDEMAK.Modul_Guru
{
    public partial class FormGuru : Form
    {
        public int id;
        public FormGuru()
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
            formLihatPresensi.status = 2;
            formLihatPresensi.Show();
        }

        private void FormGuru_Load(object sender, EventArgs e)
        {

        }

        private void btnGantiPassword_Click(object sender, EventArgs e)
        {
            FormGantiPassword formGantiPassword = new FormGantiPassword();
            formGantiPassword.status = 2;
            formGantiPassword.id = id;
            formGantiPassword.Show();
        }

        private void btnIjinKeluar_Click(object sender, EventArgs e)
        {
            FormPemberianIjin formPemberianIjin = new FormPemberianIjin();
            formPemberianIjin.id = id;
            formPemberianIjin.Show();

        }
    }
}
