
namespace EHA_System
{
    partial class AmbulanceDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbulanceDashboard));
            this.panel3 = new System.Windows.Forms.Panel();
            this.Accpt_rqst_btn = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.First_Aider_name_amb = new System.Windows.Forms.Label();
            this.Location_amb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Request_ID_amb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TimeIncident_amb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Completed_req_btn = new System.Windows.Forms.Button();
            this.Pending_req_btn = new System.Windows.Forms.Button();
            this.All_req_btn = new System.Windows.Forms.Button();
            this.Amb_req_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_Requester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Accpt_rqst_btn);
            this.panel3.Controls.Add(this.gMapControl1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.First_Aider_name_amb);
            this.panel3.Controls.Add(this.Location_amb);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.Request_ID_amb);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TimeIncident_amb);
            this.panel3.Location = new System.Drawing.Point(623, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 462);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Accpt_rqst_btn
            // 
            this.Accpt_rqst_btn.BackColor = System.Drawing.Color.LightCoral;
            this.Accpt_rqst_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Accpt_rqst_btn.Image = ((System.Drawing.Image)(resources.GetObject("Accpt_rqst_btn.Image")));
            this.Accpt_rqst_btn.Location = new System.Drawing.Point(23, 394);
            this.Accpt_rqst_btn.Name = "Accpt_rqst_btn";
            this.Accpt_rqst_btn.Size = new System.Drawing.Size(304, 42);
            this.Accpt_rqst_btn.TabIndex = 14;
            this.Accpt_rqst_btn.Text = "Accept Request";
            this.Accpt_rqst_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Accpt_rqst_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Accpt_rqst_btn.UseVisualStyleBackColor = false;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(334, 181);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // First_Aider_name_amb
            // 
            this.First_Aider_name_amb.AutoSize = true;
            this.First_Aider_name_amb.BackColor = System.Drawing.SystemColors.Control;
            this.First_Aider_name_amb.CausesValidation = false;
            this.First_Aider_name_amb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.First_Aider_name_amb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.First_Aider_name_amb.Location = new System.Drawing.Point(33, 327);
            this.First_Aider_name_amb.Name = "First_Aider_name_amb";
            this.First_Aider_name_amb.Size = new System.Drawing.Size(73, 19);
            this.First_Aider_name_amb.TabIndex = 12;
            this.First_Aider_name_amb.Text = "First Aider";
            this.First_Aider_name_amb.Click += new System.EventHandler(this.First_Aider_name_Click);
            // 
            // Location_amb
            // 
            this.Location_amb.AutoSize = true;
            this.Location_amb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Location_amb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Location_amb.Location = new System.Drawing.Point(33, 274);
            this.Location_amb.Name = "Location_amb";
            this.Location_amb.Size = new System.Drawing.Size(62, 19);
            this.Location_amb.TabIndex = 7;
            this.Location_amb.Text = "Location";
            this.Location_amb.Click += new System.EventHandler(this.Location_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Request_ID_amb
            // 
            this.Request_ID_amb.AutoSize = true;
            this.Request_ID_amb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Request_ID_amb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Request_ID_amb.Location = new System.Drawing.Point(33, 222);
            this.Request_ID_amb.Name = "Request_ID_amb";
            this.Request_ID_amb.Size = new System.Drawing.Size(78, 19);
            this.Request_ID_amb.TabIndex = 4;
            this.Request_ID_amb.Text = "Request ID";
            this.Request_ID_amb.Click += new System.EventHandler(this.Distress_Signal_ID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // TimeIncident_amb
            // 
            this.TimeIncident_amb.AutoSize = true;
            this.TimeIncident_amb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeIncident_amb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TimeIncident_amb.Location = new System.Drawing.Point(274, 222);
            this.TimeIncident_amb.Name = "TimeIncident_amb";
            this.TimeIncident_amb.Size = new System.Drawing.Size(38, 19);
            this.TimeIncident_amb.TabIndex = 2;
            this.TimeIncident_amb.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.Amb_req_label);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 462);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Completed_req_btn);
            this.panel1.Controls.Add(this.Pending_req_btn);
            this.panel1.Controls.Add(this.All_req_btn);
            this.panel1.Location = new System.Drawing.Point(35, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 37);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(75, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 5);
            this.panel4.TabIndex = 11;
            // 
            // Completed_req_btn
            // 
            this.Completed_req_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Completed_req_btn.FlatAppearance.BorderSize = 0;
            this.Completed_req_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completed_req_btn.Location = new System.Drawing.Point(150, 0);
            this.Completed_req_btn.Name = "Completed_req_btn";
            this.Completed_req_btn.Size = new System.Drawing.Size(75, 37);
            this.Completed_req_btn.TabIndex = 2;
            this.Completed_req_btn.Text = "Completed";
            this.Completed_req_btn.UseVisualStyleBackColor = true;
            this.Completed_req_btn.Click += new System.EventHandler(this.Completed_req_Click);
            // 
            // Pending_req_btn
            // 
            this.Pending_req_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pending_req_btn.FlatAppearance.BorderSize = 0;
            this.Pending_req_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pending_req_btn.Location = new System.Drawing.Point(75, 0);
            this.Pending_req_btn.Name = "Pending_req_btn";
            this.Pending_req_btn.Size = new System.Drawing.Size(75, 37);
            this.Pending_req_btn.TabIndex = 1;
            this.Pending_req_btn.Text = "Pending";
            this.Pending_req_btn.UseVisualStyleBackColor = true;
            this.Pending_req_btn.Click += new System.EventHandler(this.Pending_req_btn_Click);
            // 
            // All_req_btn
            // 
            this.All_req_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.All_req_btn.FlatAppearance.BorderSize = 0;
            this.All_req_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All_req_btn.Location = new System.Drawing.Point(0, 0);
            this.All_req_btn.Name = "All_req_btn";
            this.All_req_btn.Size = new System.Drawing.Size(75, 37);
            this.All_req_btn.TabIndex = 0;
            this.All_req_btn.Text = "All";
            this.All_req_btn.UseVisualStyleBackColor = true;
            this.All_req_btn.Click += new System.EventHandler(this.All_req_btn_Click);
            // 
            // Amb_req_label
            // 
            this.Amb_req_label.AutoSize = true;
            this.Amb_req_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Amb_req_label.Location = new System.Drawing.Point(9, 8);
            this.Amb_req_label.Name = "Amb_req_label";
            this.Amb_req_label.Size = new System.Drawing.Size(225, 26);
            this.Amb_req_label.TabIndex = 9;
            this.Amb_req_label.Text = "Ambulance Requests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Requester,
            this.ID_num,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(3, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(608, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name_Requester
            // 
            this.Name_Requester.HeaderText = "Name";
            this.Name_Requester.Name = "Name_Requester";
            this.Name_Requester.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ID_num
            // 
            this.ID_num.HeaderText = "ID #";
            this.ID_num.Name = "ID_num";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // AmbulanceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmbulanceDashboard";
            this.Text = "AmbulanceDashboard";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label First_Aider_name_amb;
        private System.Windows.Forms.Label Location_amb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Request_ID_amb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TimeIncident_amb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Requester;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button Accpt_rqst_btn;
        private System.Windows.Forms.Label Amb_req_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Completed_req_btn;
        private System.Windows.Forms.Button Pending_req_btn;
        private System.Windows.Forms.Button All_req_btn;
        private System.Windows.Forms.Panel panel4;
    }
}