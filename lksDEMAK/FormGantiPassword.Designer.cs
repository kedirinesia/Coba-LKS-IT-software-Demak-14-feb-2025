namespace lksDEMAK
{
    partial class FormGantiPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordlama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordBaru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ganti Password";
            // 
            // txtPasswordlama
            // 
            this.txtPasswordlama.Location = new System.Drawing.Point(82, 187);
            this.txtPasswordlama.Name = "txtPasswordlama";
            this.txtPasswordlama.Size = new System.Drawing.Size(198, 20);
            this.txtPasswordlama.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD Lama";
            // 
            // txtIDUser
            // 
            this.txtIDUser.Enabled = false;
            this.txtIDUser.Location = new System.Drawing.Point(82, 126);
            this.txtIDUser.Name = "txtIDUser";
            this.txtIDUser.Size = new System.Drawing.Size(198, 20);
            this.txtIDUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID USER";
            // 
            // txtPasswordBaru
            // 
            this.txtPasswordBaru.Location = new System.Drawing.Point(82, 245);
            this.txtPasswordBaru.Name = "txtPasswordBaru";
            this.txtPasswordBaru.Size = new System.Drawing.Size(198, 20);
            this.txtPasswordBaru.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD Baru";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(82, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(198, 38);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Ganti Password";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormGantiPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 369);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordBaru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordlama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormGantiPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGantiPassword";
            this.Load += new System.EventHandler(this.FormGantiPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordlama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPasswordBaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
    }
}