namespace LKS_KABUPATEN_DEMAK.Modul_Admin
{
    partial class RemoveUser
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
            this.btnCariUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHapusUser = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCariUser
            // 
            this.btnCariUser.Location = new System.Drawing.Point(37, 233);
            this.btnCariUser.Name = "btnCariUser";
            this.btnCariUser.Size = new System.Drawing.Size(95, 38);
            this.btnCariUser.TabIndex = 31;
            this.btnCariUser.Text = "Cari User";
            this.btnCariUser.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "JENIS";
            // 
            // btnHapusUser
            // 
            this.btnHapusUser.Location = new System.Drawing.Point(138, 233);
            this.btnHapusUser.Name = "btnHapusUser";
            this.btnHapusUser.Size = new System.Drawing.Size(97, 38);
            this.btnHapusUser.TabIndex = 28;
            this.btnHapusUser.Text = "Hapus User";
            this.btnHapusUser.UseVisualStyleBackColor = true;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(37, 114);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(198, 20);
            this.txtNama.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "NAMA";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Location = new System.Drawing.Point(37, 63);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(198, 20);
            this.txtIDUser.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID USER";
            // 
            // txtJenis
            // 
            this.txtJenis.Location = new System.Drawing.Point(37, 182);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(198, 20);
            this.txtJenis.TabIndex = 32;
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 319);
            this.Controls.Add(this.txtJenis);
            this.Controls.Add(this.btnCariUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHapusUser);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.label1);
            this.Name = "RemoveUser";
            this.Text = "RemoveUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCariUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnHapusUser;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJenis;
    }
}