
namespace EHA_System
{
    partial class HomeDashBoard
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IncidentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeIncident = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Distress_Signal_ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Location_home = new System.Windows.Forms.Label();
            this.Event_info = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Ambulance_req = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.First_Aider_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Incident_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Incident_2label = new System.Windows.Forms.Label();
            this.day_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportID,
            this.Time,
            this.Type});
            this.dataGridView1.Location = new System.Drawing.Point(3, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReportID
            // 
            this.ReportID.HeaderText = "Report ID";
            this.ReportID.Name = "ReportID";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.day_label);
            this.panel2.Controls.Add(this.Incident_2label);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 462);
            this.panel2.TabIndex = 5;
            // 
            // IncidentID
            // 
            this.IncidentID.AutoSize = true;
            this.IncidentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncidentID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IncidentID.Location = new System.Drawing.Point(13, 69);
            this.IncidentID.Name = "IncidentID";
            this.IncidentID.Size = new System.Drawing.Size(77, 19);
            this.IncidentID.TabIndex = 0;
            this.IncidentID.Text = "Incident ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // TimeIncident
            // 
            this.TimeIncident.AutoSize = true;
            this.TimeIncident.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeIncident.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TimeIncident.Location = new System.Drawing.Point(254, 69);
            this.TimeIncident.Name = "TimeIncident";
            this.TimeIncident.Size = new System.Drawing.Size(38, 19);
            this.TimeIncident.TabIndex = 2;
            this.TimeIncident.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // Distress_Signal_ID
            // 
            this.Distress_Signal_ID.AutoSize = true;
            this.Distress_Signal_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Distress_Signal_ID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Distress_Signal_ID.Location = new System.Drawing.Point(13, 123);
            this.Distress_Signal_ID.Name = "Distress_Signal_ID";
            this.Distress_Signal_ID.Size = new System.Drawing.Size(117, 19);
            this.Distress_Signal_ID.TabIndex = 4;
            this.Distress_Signal_ID.Text = "Distress Signal ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // Location_home
            // 
            this.Location_home.AutoSize = true;
            this.Location_home.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Location_home.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Location_home.Location = new System.Drawing.Point(13, 177);
            this.Location_home.Name = "Location_home";
            this.Location_home.Size = new System.Drawing.Size(62, 19);
            this.Location_home.TabIndex = 7;
            this.Location_home.Text = "Location";
            this.Location_home.Click += new System.EventHandler(this.Location_Click);
            // 
            // Event_info
            // 
            this.Event_info.AutoSize = true;
            this.Event_info.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Event_info.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Event_info.Location = new System.Drawing.Point(13, 231);
            this.Event_info.Name = "Event_info";
            this.Event_info.Size = new System.Drawing.Size(43, 19);
            this.Event_info.TabIndex = 8;
            this.Event_info.Text = "Event";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // Ambulance_req
            // 
            this.Ambulance_req.AutoSize = true;
            this.Ambulance_req.BackColor = System.Drawing.SystemColors.Control;
            this.Ambulance_req.CausesValidation = false;
            this.Ambulance_req.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ambulance_req.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Ambulance_req.Location = new System.Drawing.Point(13, 285);
            this.Ambulance_req.Name = "Ambulance_req";
            this.Ambulance_req.Size = new System.Drawing.Size(130, 19);
            this.Ambulance_req.TabIndex = 10;
            this.Ambulance_req.Text = "Ambulance Request";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 304);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "label12";
            // 
            // First_Aider_name
            // 
            this.First_Aider_name.AutoSize = true;
            this.First_Aider_name.BackColor = System.Drawing.SystemColors.Control;
            this.First_Aider_name.CausesValidation = false;
            this.First_Aider_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.First_Aider_name.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.First_Aider_name.Location = new System.Drawing.Point(13, 360);
            this.First_Aider_name.Name = "First_Aider_name";
            this.First_Aider_name.Size = new System.Drawing.Size(73, 19);
            this.First_Aider_name.TabIndex = 12;
            this.First_Aider_name.Text = "First Aider";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // Incident_label
            // 
            this.Incident_label.AutoSize = true;
            this.Incident_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Incident_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Incident_label.Location = new System.Drawing.Point(13, 16);
            this.Incident_label.Name = "Incident_label";
            this.Incident_label.Size = new System.Drawing.Size(130, 19);
            this.Incident_label.TabIndex = 14;
            this.Incident_label.Text = "Incident Information";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Incident_label);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.First_Aider_name);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.Ambulance_req);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.Event_info);
            this.panel3.Controls.Add(this.Location_home);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Distress_Signal_ID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TimeIncident);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.IncidentID);
            this.panel3.Location = new System.Drawing.Point(622, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 462);
            this.panel3.TabIndex = 6;
            // 
            // Incident_2label
            // 
            this.Incident_2label.AutoSize = true;
            this.Incident_2label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Incident_2label.Location = new System.Drawing.Point(10, 8);
            this.Incident_2label.Name = "Incident_2label";
            this.Incident_2label.Size = new System.Drawing.Size(146, 22);
            this.Incident_2label.TabIndex = 1;
            this.Incident_2label.Text = "Incident Reports";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.day_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.day_label.Location = new System.Drawing.Point(22, 34);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(41, 15);
            this.day_label.TabIndex = 2;
            this.day_label.Text = "Today";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(269, 16);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 7, 15, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 15, 0, 0, 0, 0);
            // 
            // HomeDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeDashBoard";
            this.Text = "HomeDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label IncidentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeIncident;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Distress_Signal_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Location_home;
        private System.Windows.Forms.Label Event_info;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Ambulance_req;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label First_Aider_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Incident_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Label Incident_2label;
    }
}