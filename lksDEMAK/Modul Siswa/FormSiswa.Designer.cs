namespace LKS_KABUPATEN_DEMAK.Modul_Siswa
{
    partial class FormSiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnIjinKeluar = new System.Windows.Forms.Button();
            this.btnGantiPassword = new System.Windows.Forms.Button();
            this.btnLihatPresensi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(62, 249);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnIjinKeluar
            // 
            this.btnIjinKeluar.Location = new System.Drawing.Point(62, 195);
            this.btnIjinKeluar.Name = "btnIjinKeluar";
            this.btnIjinKeluar.Size = new System.Drawing.Size(186, 37);
            this.btnIjinKeluar.TabIndex = 6;
            this.btnIjinKeluar.Text = "Ijin Keluar";
            this.btnIjinKeluar.UseVisualStyleBackColor = true;
            this.btnIjinKeluar.Click += new System.EventHandler(this.btnIjinKeluar_Click);
            // 
            // btnGantiPassword
            // 
            this.btnGantiPassword.Location = new System.Drawing.Point(61, 141);
            this.btnGantiPassword.Name = "btnGantiPassword";
            this.btnGantiPassword.Size = new System.Drawing.Size(186, 37);
            this.btnGantiPassword.TabIndex = 5;
            this.btnGantiPassword.Text = "Ganti Password";
            this.btnGantiPassword.UseVisualStyleBackColor = true;
            this.btnGantiPassword.Click += new System.EventHandler(this.btnGantiPassword_Click);
            // 
            // btnLihatPresensi
            // 
            this.btnLihatPresensi.Location = new System.Drawing.Point(61, 87);
            this.btnLihatPresensi.Name = "btnLihatPresensi";
            this.btnLihatPresensi.Size = new System.Drawing.Size(186, 37);
            this.btnLihatPresensi.TabIndex = 4;
            this.btnLihatPresensi.Text = "Lihat Presensi";
            this.btnLihatPresensi.UseVisualStyleBackColor = true;
            this.btnLihatPresensi.Click += new System.EventHandler(this.btnLihatPresensi_Click);
            // 
            // FormSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnIjinKeluar);
            this.Controls.Add(this.btnGantiPassword);
            this.Controls.Add(this.btnLihatPresensi);
            this.Name = "FormSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSiswa";
            this.Load += new System.EventHandler(this.FormSiswa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnIjinKeluar;
        private System.Windows.Forms.Button btnGantiPassword;
        private System.Windows.Forms.Button btnLihatPresensi;
    }
}