namespace lksDEMAK.Modul_Guru
{
    partial class FormGuru
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
            this.btnLogout.Location = new System.Drawing.Point(57, 224);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 37);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnIjinKeluar
            // 
            this.btnIjinKeluar.Location = new System.Drawing.Point(57, 170);
            this.btnIjinKeluar.Name = "btnIjinKeluar";
            this.btnIjinKeluar.Size = new System.Drawing.Size(186, 37);
            this.btnIjinKeluar.TabIndex = 10;
            this.btnIjinKeluar.Text = "Memberi ijin ke Siswa";
            this.btnIjinKeluar.UseVisualStyleBackColor = true;
            this.btnIjinKeluar.Click += new System.EventHandler(this.btnIjinKeluar_Click);
            // 
            // btnGantiPassword
            // 
            this.btnGantiPassword.Location = new System.Drawing.Point(56, 116);
            this.btnGantiPassword.Name = "btnGantiPassword";
            this.btnGantiPassword.Size = new System.Drawing.Size(186, 37);
            this.btnGantiPassword.TabIndex = 9;
            this.btnGantiPassword.Text = "Ganti Password";
            this.btnGantiPassword.UseVisualStyleBackColor = true;
            this.btnGantiPassword.Click += new System.EventHandler(this.btnGantiPassword_Click);
            // 
            // btnLihatPresensi
            // 
            this.btnLihatPresensi.Location = new System.Drawing.Point(56, 62);
            this.btnLihatPresensi.Name = "btnLihatPresensi";
            this.btnLihatPresensi.Size = new System.Drawing.Size(186, 37);
            this.btnLihatPresensi.TabIndex = 8;
            this.btnLihatPresensi.Text = "Lihat Presensi";
            this.btnLihatPresensi.UseVisualStyleBackColor = true;
            this.btnLihatPresensi.Click += new System.EventHandler(this.btnLihatPresensi_Click);
            // 
            // FormGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 322);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnIjinKeluar);
            this.Controls.Add(this.btnGantiPassword);
            this.Controls.Add(this.btnLihatPresensi);
            this.Name = "FormGuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGuru";
            this.Load += new System.EventHandler(this.FormGuru_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnIjinKeluar;
        private System.Windows.Forms.Button btnGantiPassword;
        private System.Windows.Forms.Button btnLihatPresensi;
    }
}