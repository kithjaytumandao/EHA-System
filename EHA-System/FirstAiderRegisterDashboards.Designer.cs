
namespace EHA_System
{
    partial class FirstAiderRegisterDashboards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstAiderRegisterDashboards));
            this.FirstAider_regist_label = new System.Windows.Forms.Label();
            this.Registration_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Create_acc_btn = new System.Windows.Forms.Button();
            this.Clear_field_FirstAider_label = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ContactNo_txtbx = new System.Windows.Forms.TextBox();
            this.Emailadd_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Age_txtbx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lastname_txtbx = new System.Windows.Forms.TextBox();
            this.Middlename_txtbx = new System.Windows.Forms.TextBox();
            this.Firstname_txtbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Show_Details_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Name_dash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Search_txtbx = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstAider_regist_label
            // 
            this.FirstAider_regist_label.AutoSize = true;
            this.FirstAider_regist_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstAider_regist_label.Location = new System.Drawing.Point(44, 28);
            this.FirstAider_regist_label.Name = "FirstAider_regist_label";
            this.FirstAider_regist_label.Size = new System.Drawing.Size(114, 27);
            this.FirstAider_regist_label.TabIndex = 0;
            this.FirstAider_regist_label.Text = "First Aider";
            this.FirstAider_regist_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Registration_label
            // 
            this.Registration_label.AutoSize = true;
            this.Registration_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Registration_label.Location = new System.Drawing.Point(164, 37);
            this.Registration_label.Name = "Registration_label";
            this.Registration_label.Size = new System.Drawing.Size(70, 15);
            this.Registration_label.TabIndex = 1;
            this.Registration_label.Text = "Registration";
            this.Registration_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Create_acc_btn);
            this.panel1.Controls.Add(this.Clear_field_FirstAider_label);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.ContactNo_txtbx);
            this.panel1.Controls.Add(this.Emailadd_txtbx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Age_txtbx);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Lastname_txtbx);
            this.panel1.Controls.Add(this.Middlename_txtbx);
            this.panel1.Controls.Add(this.Firstname_txtbx);
            this.panel1.Controls.Add(this.Registration_label);
            this.panel1.Controls.Add(this.FirstAider_regist_label);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 459);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Create_acc_btn
            // 
            this.Create_acc_btn.Image = ((System.Drawing.Image)(resources.GetObject("Create_acc_btn.Image")));
            this.Create_acc_btn.Location = new System.Drawing.Point(303, 381);
            this.Create_acc_btn.Name = "Create_acc_btn";
            this.Create_acc_btn.Size = new System.Drawing.Size(133, 31);
            this.Create_acc_btn.TabIndex = 15;
            this.Create_acc_btn.Text = "Create Account";
            this.Create_acc_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Create_acc_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Create_acc_btn.UseVisualStyleBackColor = true;
            this.Create_acc_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clear_field_FirstAider_label
            // 
            this.Clear_field_FirstAider_label.AutoSize = true;
            this.Clear_field_FirstAider_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Clear_field_FirstAider_label.ForeColor = System.Drawing.Color.Red;
            this.Clear_field_FirstAider_label.Location = new System.Drawing.Point(199, 389);
            this.Clear_field_FirstAider_label.Name = "Clear_field_FirstAider_label";
            this.Clear_field_FirstAider_label.Size = new System.Drawing.Size(67, 15);
            this.Clear_field_FirstAider_label.TabIndex = 14;
            this.Clear_field_FirstAider_label.Text = "Clear Fields";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(230, 335);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 23);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "Has a Certificate?";
            // 
            // ContactNo_txtbx
            // 
            this.ContactNo_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.ContactNo_txtbx.Location = new System.Drawing.Point(44, 335);
            this.ContactNo_txtbx.Name = "ContactNo_txtbx";
            this.ContactNo_txtbx.Size = new System.Drawing.Size(149, 23);
            this.ContactNo_txtbx.TabIndex = 12;
            this.ContactNo_txtbx.Text = "Contact Number";
            this.ContactNo_txtbx.TextChanged += new System.EventHandler(this.ContactNo_txtbx_TextChanged);
            this.ContactNo_txtbx.Enter += new System.EventHandler(this.ContactNo_txtbx_Enter);
            this.ContactNo_txtbx.Leave += new System.EventHandler(this.ContactNo_txtbx_Leave);
            // 
            // Emailadd_txtbx
            // 
            this.Emailadd_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.Emailadd_txtbx.Location = new System.Drawing.Point(44, 287);
            this.Emailadd_txtbx.Name = "Emailadd_txtbx";
            this.Emailadd_txtbx.Size = new System.Drawing.Size(149, 23);
            this.Emailadd_txtbx.TabIndex = 11;
            this.Emailadd_txtbx.Text = "Email Address";
            this.Emailadd_txtbx.Enter += new System.EventHandler(this.Emailadd_txtbx_Enter);
            this.Emailadd_txtbx.Leave += new System.EventHandler(this.Emailadd_txtbx_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(44, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Additional ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Basic Information";
            // 
            // Age_txtbx
            // 
            this.Age_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.Age_txtbx.Location = new System.Drawing.Point(403, 158);
            this.Age_txtbx.Name = "Age_txtbx";
            this.Age_txtbx.Size = new System.Drawing.Size(100, 23);
            this.Age_txtbx.TabIndex = 7;
            this.Age_txtbx.Text = "Age";
            this.Age_txtbx.Enter += new System.EventHandler(this.Age_txtbx_Enter);
            this.Age_txtbx.Leave += new System.EventHandler(this.Age_txtbx_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(230, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(86, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Gender";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Silver;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 159);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 8, 2, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 8, 2, 0, 0, 0, 0);
            // 
            // Lastname_txtbx
            // 
            this.Lastname_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.Lastname_txtbx.Location = new System.Drawing.Point(403, 115);
            this.Lastname_txtbx.Name = "Lastname_txtbx";
            this.Lastname_txtbx.Size = new System.Drawing.Size(149, 23);
            this.Lastname_txtbx.TabIndex = 4;
            this.Lastname_txtbx.Text = "Last Name";
            this.Lastname_txtbx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Lastname_txtbx.Enter += new System.EventHandler(this.Lastname_txtbx_Enter);
            this.Lastname_txtbx.Leave += new System.EventHandler(this.Lastname_txtbx_Leave);
            // 
            // Middlename_txtbx
            // 
            this.Middlename_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.Middlename_txtbx.Location = new System.Drawing.Point(230, 115);
            this.Middlename_txtbx.Name = "Middlename_txtbx";
            this.Middlename_txtbx.Size = new System.Drawing.Size(149, 23);
            this.Middlename_txtbx.TabIndex = 3;
            this.Middlename_txtbx.Text = "Middle Name";
            this.Middlename_txtbx.Enter += new System.EventHandler(this.Middlename_txtbx_Enter);
            this.Middlename_txtbx.Leave += new System.EventHandler(this.Middlename_txtbx_Leave);
            // 
            // Firstname_txtbx
            // 
            this.Firstname_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.Firstname_txtbx.Location = new System.Drawing.Point(44, 115);
            this.Firstname_txtbx.Name = "Firstname_txtbx";
            this.Firstname_txtbx.Size = new System.Drawing.Size(149, 23);
            this.Firstname_txtbx.TabIndex = 2;
            this.Firstname_txtbx.Text = "First Name";
            this.Firstname_txtbx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Firstname_txtbx.Enter += new System.EventHandler(this.FirstName_enter);
            this.Firstname_txtbx.Leave += new System.EventHandler(this.Firstname_txtbx_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Show_Details_btn);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.Search_txtbx);
            this.panel2.Location = new System.Drawing.Point(697, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 459);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Show_Details_btn
            // 
            this.Show_Details_btn.Location = new System.Drawing.Point(98, 407);
            this.Show_Details_btn.Name = "Show_Details_btn";
            this.Show_Details_btn.Size = new System.Drawing.Size(107, 23);
            this.Show_Details_btn.TabIndex = 4;
            this.Show_Details_btn.Text = "Show Details";
            this.Show_Details_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Name_dash,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(16, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(247, 254);
            this.dataGridView1.TabIndex = 3;
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // Name_dash
            // 
            this.Name_dash.HeaderText = "Name";
            this.Name_dash.Name = "Name_dash";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(35, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Accounts";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Search_txtbx
            // 
            this.Search_txtbx.ForeColor = System.Drawing.Color.Silver;
            this.Search_txtbx.Location = new System.Drawing.Point(71, 37);
            this.Search_txtbx.Name = "Search_txtbx";
            this.Search_txtbx.Size = new System.Drawing.Size(192, 23);
            this.Search_txtbx.TabIndex = 0;
            this.Search_txtbx.Text = "Search....";
            this.Search_txtbx.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.Search_txtbx.Enter += new System.EventHandler(this.Search_txtbx_Enter);
            this.Search_txtbx.Leave += new System.EventHandler(this.Search_txtbx_Leave);
            // 
            // FirstAiderRegisterDashboards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstAiderRegisterDashboards";
            this.Text = "FirstAiderRegisterDashboard";
            this.Load += new System.EventHandler(this.FirstAiderRegisterDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FirstAider_regist_label;
        private System.Windows.Forms.Label Registration_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Lastname_txtbx;
        private System.Windows.Forms.TextBox Middlename_txtbx;
        private System.Windows.Forms.TextBox Firstname_txtbx;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox ContactNo_txtbx;
        private System.Windows.Forms.TextBox Emailadd_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Age_txtbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Clear_field_FirstAider_label;
        private System.Windows.Forms.Button Create_acc_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Search_txtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Show_Details_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_dash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}