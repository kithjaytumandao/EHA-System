
namespace EHA_System
{
    partial class Loginpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpage));
            this.Login_label = new System.Windows.Forms.Label();
            this.Usernname_txtbx = new System.Windows.Forms.TextBox();
            this.Password_txtbx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.ClearField_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Login_label.ForeColor = System.Drawing.Color.Red;
            this.Login_label.Location = new System.Drawing.Point(150, 36);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(103, 22);
            this.Login_label.TabIndex = 0;
            this.Login_label.Text = "EHA Login";
            // 
            // Usernname_txtbx
            // 
            this.Usernname_txtbx.Location = new System.Drawing.Point(133, 210);
            this.Usernname_txtbx.Name = "Usernname_txtbx";
            this.Usernname_txtbx.Size = new System.Drawing.Size(134, 23);
            this.Usernname_txtbx.TabIndex = 1;
            // 
            // Password_txtbx
            // 
            this.Password_txtbx.Location = new System.Drawing.Point(133, 268);
            this.Password_txtbx.Name = "Password_txtbx";
            this.Password_txtbx.PasswordChar = '*';
            this.Password_txtbx.Size = new System.Drawing.Size(134, 23);
            this.Password_txtbx.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(133, 344);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(134, 23);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(34, 210);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(60, 15);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(34, 275);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(57, 15);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            this.password_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClearField_lbl
            // 
            this.ClearField_lbl.AutoSize = true;
            this.ClearField_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ClearField_lbl.ForeColor = System.Drawing.Color.Red;
            this.ClearField_lbl.Location = new System.Drawing.Point(200, 305);
            this.ClearField_lbl.Name = "ClearField_lbl";
            this.ClearField_lbl.Size = new System.Drawing.Size(67, 15);
            this.ClearField_lbl.TabIndex = 7;
            this.ClearField_lbl.Text = "Clear Fields";
            this.ClearField_lbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 456);
            this.Controls.Add(this.ClearField_lbl);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password_txtbx);
            this.Controls.Add(this.Usernname_txtbx);
            this.Controls.Add(this.Login_label);
            this.MaximizeBox = false;
            this.Name = "Loginpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginpage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.TextBox Usernname_txtbx;
        private System.Windows.Forms.TextBox Password_txtbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label ClearField_lbl;
    }
}