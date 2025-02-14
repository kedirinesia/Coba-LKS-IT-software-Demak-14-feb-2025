using lksDEMAK;
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
    public partial class FormLihatPresensi : Form
    {
        
        // 1 adalah siswa, 2 adalah guru
        public int status;
        public FormLihatPresensi()
        {
            InitializeComponent();
        }

        private void FormLihatPresensi_Load(object sender, EventArgs e)
        {
            if (status == 1)
            {
                label1.Text = "Presensi Siswa";
                DataTable dt =(DataTable) Helper.GetQuery("SELECT nama, masuk FROM SiswaTable WHERE masuk IS NOT NULL");
                dataGridView1.DataSource = dt;
               // MessageBox.Show("siswa");
            }else if(status == 2)
            {
                label1.Text = "Presensi Guru";
                DataTable dt = (DataTable)Helper.GetQuery("select nama, masuk from gurutable where masuk is not null");
                dataGridView1.DataSource= dt;

            }
        }
    }
}
