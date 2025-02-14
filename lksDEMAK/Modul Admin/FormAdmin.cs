using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS_KABUPATEN_DEMAK.Modul_Admin
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Presensi = new Form1();
            Presensi.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahUser formTambahUser = new FormTambahUser();
            formTambahUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new FormEditUser(); 
            formEditUser.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveUser removeUser
                = new RemoveUser();
            removeUser.Show();
        }
    }
}
