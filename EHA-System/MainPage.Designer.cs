
namespace EHA_System
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.Reports_btn = new System.Windows.Forms.Button();
            this.Aider_reg = new System.Windows.Forms.Button();
            this.Ambulance_btn = new System.Windows.Forms.Button();
            this.Home_btn = new System.Windows.Forms.Button();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.EHA_Title = new System.Windows.Forms.Label();
            this.Title_admin = new System.Windows.Forms.Label();
            this.Notification_btn = new System.Windows.Forms.Button();
            this.circle_btn1 = new EHA_System.Circle_btn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Logout_btn);
            this.panel1.Controls.Add(this.Reports_btn);
            this.panel1.Controls.Add(this.Aider_reg);
            this.panel1.Controls.Add(this.Ambulance_btn);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 465);
            this.panel1.TabIndex = 0;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_btn.FlatAppearance.BorderSize = 0;
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Image = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Image")));
            this.Logout_btn.Location = new System.Drawing.Point(0, 252);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(155, 63);
            this.Logout_btn.TabIndex = 4;
            this.Logout_btn.UseVisualStyleBackColor = true;
            // 
            // Reports_btn
            // 
            this.Reports_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Reports_btn.FlatAppearance.BorderSize = 0;
            this.Reports_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reports_btn.Image = ((System.Drawing.Image)(resources.GetObject("Reports_btn.Image")));
            this.Reports_btn.Location = new System.Drawing.Point(0, 189);
            this.Reports_btn.Name = "Reports_btn";
            this.Reports_btn.Size = new System.Drawing.Size(155, 63);
            this.Reports_btn.TabIndex = 3;
            this.Reports_btn.UseVisualStyleBackColor = true;
            this.Reports_btn.Click += new System.EventHandler(this.Reports_btn_click);
            // 
            // Aider_reg
            // 
            this.Aider_reg.Dock = System.Windows.Forms.DockStyle.Top;
            this.Aider_reg.FlatAppearance.BorderSize = 0;
            this.Aider_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aider_reg.Image = ((System.Drawing.Image)(resources.GetObject("Aider_reg.Image")));
            this.Aider_reg.Location = new System.Drawing.Point(0, 126);
            this.Aider_reg.Name = "Aider_reg";
            this.Aider_reg.Size = new System.Drawing.Size(155, 63);
            this.Aider_reg.TabIndex = 2;
            this.Aider_reg.UseVisualStyleBackColor = true;
            this.Aider_reg.Click += new System.EventHandler(this.FirstAider_btn_click);
            // 
            // Ambulance_btn
            // 
            this.Ambulance_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ambulance_btn.FlatAppearance.BorderSize = 0;
            this.Ambulance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ambulance_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ambulance_btn.Image")));
            this.Ambulance_btn.Location = new System.Drawing.Point(0, 63);
            this.Ambulance_btn.Name = "Ambulance_btn";
            this.Ambulance_btn.Size = new System.Drawing.Size(155, 63);
            this.Ambulance_btn.TabIndex = 1;
            this.Ambulance_btn.UseVisualStyleBackColor = true;
            this.Ambulance_btn.Click += new System.EventHandler(this.Ambulance_btn_Click);
            // 
            // Home_btn
            // 
            this.Home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_btn.FlatAppearance.BorderSize = 0;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Image = ((System.Drawing.Image)(resources.GetObject("Home_btn.Image")));
            this.Home_btn.Location = new System.Drawing.Point(0, 0);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(155, 63);
            this.Home_btn.TabIndex = 0;
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Location = new System.Drawing.Point(165, 97);
            this.panelFormLoader.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(972, 465);
            this.panelFormLoader.TabIndex = 1;
            this.panelFormLoader.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // EHA_Title
            // 
            this.EHA_Title.AutoSize = true;
            this.EHA_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EHA_Title.Location = new System.Drawing.Point(12, 4);
            this.EHA_Title.Name = "EHA_Title";
            this.EHA_Title.Size = new System.Drawing.Size(322, 26);
            this.EHA_Title.TabIndex = 2;
            this.EHA_Title.Text = "EMERGENCY HEALTH AID";
            this.EHA_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title_admin
            // 
            this.Title_admin.AutoSize = true;
            this.Title_admin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title_admin.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Title_admin.Location = new System.Drawing.Point(12, 30);
            this.Title_admin.Name = "Title_admin";
            this.Title_admin.Size = new System.Drawing.Size(71, 21);
            this.Title_admin.TabIndex = 3;
            this.Title_admin.Text = "ADMIN";
            // 
            // Notification_btn
            // 
            this.Notification_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Notification_btn.FlatAppearance.BorderSize = 0;
            this.Notification_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notification_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Notification_btn.Image = ((System.Drawing.Image)(resources.GetObject("Notification_btn.Image")));
            this.Notification_btn.Location = new System.Drawing.Point(881, 12);
            this.Notification_btn.Name = "Notification_btn";
            this.Notification_btn.Size = new System.Drawing.Size(77, 66);
            this.Notification_btn.TabIndex = 4;
            this.Notification_btn.UseVisualStyleBackColor = false;
            this.Notification_btn.Click += new System.EventHandler(this.Notification_btn_Click);
            // 
            // circle_btn1
            // 
            this.circle_btn1.BackColor = System.Drawing.Color.LightSlateGray;
            this.circle_btn1.FlatAppearance.BorderSize = 0;
            this.circle_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle_btn1.Image = ((System.Drawing.Image)(resources.GetObject("circle_btn1.Image")));
            this.circle_btn1.Location = new System.Drawing.Point(992, 12);
            this.circle_btn1.Name = "circle_btn1";
            this.circle_btn1.Size = new System.Drawing.Size(77, 66);
            this.circle_btn1.TabIndex = 5;
            this.circle_btn1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(9, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 63);
            this.panel3.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 576);
            this.Controls.Add(this.circle_btn1);
            this.Controls.Add(this.Notification_btn);
            this.Controls.Add(this.Title_admin);
            this.Controls.Add(this.EHA_Title);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Label EHA_Title;
        private System.Windows.Forms.Label Title_admin;
        private System.Windows.Forms.Button Notification_btn;
        private Circle_btn circle_btn1;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Button Reports_btn;
        private System.Windows.Forms.Button Aider_reg;
        private System.Windows.Forms.Button Ambulance_btn;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Panel panel3;
    }
}