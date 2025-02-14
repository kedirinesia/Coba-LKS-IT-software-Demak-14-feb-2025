namespace lksDEMAK.Modul_Siswa
{
    partial class FormIjinKeluar
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
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIjin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(98, 225);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(229, 98);
            this.txtKeterangan.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Keterangan";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Enabled = false;
            this.txtIDUser.Location = new System.Drawing.Point(98, 164);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(229, 20);
            this.txtIDUser.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "IJIN KELUAR";
            // 
            // btnIjin
            // 
            this.btnIjin.Location = new System.Drawing.Point(98, 340);
            this.btnIjin.Name = "btnIjin";
            this.btnIjin.Size = new System.Drawing.Size(229, 22);
            this.btnIjin.TabIndex = 13;
            this.btnIjin.Text = "Mengajukan Ijin Keluar";
            this.btnIjin.UseVisualStyleBackColor = true;
            this.btnIjin.Click += new System.EventHandler(this.btnIjin_Click);
            // 
            // FormIjinKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 422);
            this.Controls.Add(this.btnIjin);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormIjinKeluar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIjinKeluar";
            this.Load += new System.EventHandler(this.FormIjinKeluar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIjin;
    }
}