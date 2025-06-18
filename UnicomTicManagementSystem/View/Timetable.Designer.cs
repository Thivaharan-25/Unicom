namespace UnicomTicManagementSystem.View
{
    partial class Timetable
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
            c_time = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgv_time = new DataGridView();
            label3 = new Label();
            c_subject = new ComboBox();
            label4 = new Label();
            t_hall = new TextBox();
            label5 = new Label();
            c_lecturer = new ComboBox();
            btn_add = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            pictureBox1 = new PictureBox();
            c_course = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            c_roomtype = new ComboBox();
            t_date = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_time).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // c_time
            // 
            c_time.FormattingEnabled = true;
            c_time.Items.AddRange(new object[] { "7:00 AM - 8:00 AM", "8;00 AM - 9:00 AM" });
            c_time.Location = new Point(96, 175);
            c_time.Name = "c_time";
            c_time.Size = new Size(148, 23);
            c_time.TabIndex = 6;
            c_time.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 142);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 7;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 179);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 8;
            label2.Text = "Time";
            // 
            // dgv_time
            // 
            dgv_time.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_time.Location = new Point(407, 27);
            dgv_time.Name = "dgv_time";
            dgv_time.Size = new Size(541, 423);
            dgv_time.TabIndex = 9;
            dgv_time.CellContentClick += dataGridView1_CellContentClick;
            dgv_time.SelectionChanged += dgv_time_SelectionChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 252);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 10;
            label3.Text = "Subject";
            // 
            // c_subject
            // 
            c_subject.DropDownStyle = ComboBoxStyle.DropDownList;
            c_subject.FormattingEnabled = true;
            c_subject.Location = new Point(96, 252);
            c_subject.Name = "c_subject";
            c_subject.Size = new Size(148, 23);
            c_subject.TabIndex = 11;
            c_subject.SelectedIndexChanged += c_subject_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-3, 328);
            label4.Name = "label4";
            label4.Size = new Size(93, 19);
            label4.TabIndex = 12;
            label4.Text = "Room Name";
            label4.Click += label4_Click;
            // 
            // t_hall
            // 
            t_hall.Location = new Point(96, 324);
            t_hall.Name = "t_hall";
            t_hall.Size = new Size(180, 23);
            t_hall.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 367);
            label5.Name = "label5";
            label5.Size = new Size(66, 19);
            label5.TabIndex = 14;
            label5.Text = "Lecturer";
            // 
            // c_lecturer
            // 
            c_lecturer.DropDownStyle = ComboBoxStyle.DropDownList;
            c_lecturer.FormattingEnabled = true;
            c_lecturer.Location = new Point(96, 363);
            c_lecturer.Name = "c_lecturer";
            c_lecturer.Size = new Size(148, 23);
            c_lecturer.TabIndex = 15;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaptionText;
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(25, 427);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(82, 23);
            btn_add.TabIndex = 16;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveCaptionText;
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(255, 427);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(90, 23);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveCaptionText;
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(142, 427);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(85, 23);
            btn_update.TabIndex = 18;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Clock_timer_logo_by_Mansel_Brist_23;
            pictureBox1.Location = new Point(44, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 126);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // c_course
            // 
            c_course.DropDownStyle = ComboBoxStyle.DropDownList;
            c_course.FormattingEnabled = true;
            c_course.Location = new Point(96, 210);
            c_course.Name = "c_course";
            c_course.Size = new Size(148, 23);
            c_course.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 214);
            label6.Name = "label6";
            label6.Size = new Size(55, 19);
            label6.TabIndex = 21;
            label6.Text = "Course";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 292);
            label7.Name = "label7";
            label7.Size = new Size(86, 19);
            label7.TabIndex = 22;
            label7.Text = "Room Type";
            // 
            // c_roomtype
            // 
            c_roomtype.DropDownStyle = ComboBoxStyle.DropDownList;
            c_roomtype.FormattingEnabled = true;
            c_roomtype.Items.AddRange(new object[] { "Hall", "Lab" });
            c_roomtype.Location = new Point(96, 288);
            c_roomtype.Name = "c_roomtype";
            c_roomtype.Size = new Size(148, 23);
            c_roomtype.TabIndex = 23;
            // 
            // t_date
            // 
            t_date.Location = new Point(96, 139);
            t_date.Name = "t_date";
            t_date.Size = new Size(200, 23);
            t_date.TabIndex = 24;
            // 
            // Timetable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(989, 553);
            Controls.Add(t_date);
            Controls.Add(c_roomtype);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(c_course);
            Controls.Add(pictureBox1);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(c_lecturer);
            Controls.Add(label5);
            Controls.Add(t_hall);
            Controls.Add(label4);
            Controls.Add(c_subject);
            Controls.Add(label3);
            Controls.Add(dgv_time);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(c_time);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Timetable";
            Text = "Timetable";
            Load += Timetable_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_time).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox c_time;
        private Label label1;
        private Label label2;
        private DataGridView dgv_time;
        private Label label3;
        private ComboBox c_subject;
        private Label label4;
        private TextBox t_hall;
        private Label label5;
        private ComboBox c_lecturer;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private PictureBox pictureBox1;
        private ComboBox c_course;
        private Label label6;
        private Label label7;
        private ComboBox c_roomtype;
        private DateTimePicker t_date;
    }
}