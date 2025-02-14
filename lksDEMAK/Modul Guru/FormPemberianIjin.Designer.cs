namespace lksDEMAK.Modul_Guru
{
    partial class FormPemberianIjin
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCariData = new System.Windows.Forms.Button();
            this.btnMenolak = new System.Windows.Forms.Button();
            this.btnMengijinkan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(233, 306);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(69, 22);
            this.btnKembali.TabIndex = 19;
            this.btnKembali.Text = "kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(73, 202);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(229, 98);
            this.txtKeterangan.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Keterangan";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Location = new System.Drawing.Point(76, 115);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(229, 20);
            this.txtIDUser.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID USER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "IJIN KELUAR";
            // 
            // btnCariData
            // 
            this.btnCariData.Location = new System.Drawing.Point(73, 143);
            this.btnCariData.Name = "btnCariData";
            this.btnCariData.Size = new System.Drawing.Size(229, 22);
            this.btnCariData.TabIndex = 20;
            this.btnCariData.Text = "Cari Data";
            this.btnCariData.UseVisualStyleBackColor = true;
            this.btnCariData.Click += new System.EventHandler(this.btnCariData_Click);
            // 
            // btnMenolak
            // 
            this.btnMenolak.Location = new System.Drawing.Point(158, 306);
            this.btnMenolak.Name = "btnMenolak";
            this.btnMenolak.Size = new System.Drawing.Size(69, 22);
            this.btnMenolak.TabIndex = 21;
            this.btnMenolak.Text = "Menolak";
            this.btnMenolak.UseVisualStyleBackColor = true;
            this.btnMenolak.Click += new System.EventHandler(this.btnMenolak_Click);
            // 
            // btnMengijinkan
            // 
            this.btnMengijinkan.Location = new System.Drawing.Point(76, 306);
            this.btnMengijinkan.Name = "btnMengijinkan";
            this.btnMengijinkan.Size = new System.Drawing.Size(78, 22);
            this.btnMengijinkan.TabIndex = 22;
            this.btnMengijinkan.Text = "Mengijinkan";
            this.btnMengijinkan.UseVisualStyleBackColor = true;
            this.btnMengijinkan.Click += new System.EventHandler(this.btnMengijinkan_Click);
            // 
            // FormPemberianIjin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 361);
            this.Controls.Add(this.btnMengijinkan);
            this.Controls.Add(this.btnMenolak);
            this.Controls.Add(this.btnCariData);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtKeterangan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormPemberianIjin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPemberianIjin";
            this.Load += new System.EventHandler(this.FormPemberianIjin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCariData;
        private System.Windows.Forms.Button btnMenolak;
        private System.Windows.Forms.Button btnMengijinkan;
    }
}