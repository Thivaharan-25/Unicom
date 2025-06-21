namespace UnicomTicManagementSystem.View
{
    partial class Exam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam));
            dgv_exam = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            c_subject = new ComboBox();
            t_date = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            label4 = new Label();
            t_exam = new TextBox();
            t_hall = new TextBox();
            label5 = new Label();
            d_time = new DateTimePicker();
            d_time2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_exam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_exam
            // 
            dgv_exam.BackgroundColor = SystemColors.ControlLightLight;
            dgv_exam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_exam.Location = new Point(388, 33);
            dgv_exam.Name = "dgv_exam";
            dgv_exam.Size = new Size(533, 423);
            dgv_exam.TabIndex = 0;
            dgv_exam.CellContentClick += dataGridView1_CellContentClick;
            dgv_exam.SelectionChanged += dgv_time_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 192);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 266);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 2;
            label2.Text = "Subject";
            // 
            // c_subject
            // 
            c_subject.DropDownStyle = ComboBoxStyle.DropDownList;
            c_subject.FormattingEnabled = true;
            c_subject.Location = new Point(111, 263);
            c_subject.Name = "c_subject";
            c_subject.Size = new Size(134, 23);
            c_subject.TabIndex = 3;
            c_subject.SelectedIndexChanged += c_subject_SelectedIndexChanged;
            // 
            // t_date
            // 
            t_date.Location = new Point(111, 190);
            t_date.Name = "t_date";
            t_date.Size = new Size(200, 23);
            t_date.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 183);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 311);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 27;
            label3.Text = "ExamHall ";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveCaptionText;
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(251, 417);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(90, 23);
            btn_delete.TabIndex = 28;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveCaptionText;
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(131, 417);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(90, 23);
            btn_update.TabIndex = 29;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaptionText;
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(4, 417);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 23);
            btn_add.TabIndex = 30;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 357);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 31;
            label4.Text = "Exam Type";
            // 
            // t_exam
            // 
            t_exam.Location = new Point(111, 354);
            t_exam.Name = "t_exam";
            t_exam.Size = new Size(134, 23);
            t_exam.TabIndex = 32;
            // 
            // t_hall
            // 
            t_hall.Location = new Point(111, 308);
            t_hall.Name = "t_hall";
            t_hall.Size = new Size(134, 23);
            t_hall.TabIndex = 33;
            t_hall.TextChanged += t_hall_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 227);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 34;
            label5.Text = "Time";
            // 
            // d_time
            // 
            d_time.Format = DateTimePickerFormat.Time;
            d_time.Location = new Point(111, 224);
            d_time.Name = "d_time";
            d_time.ShowUpDown = true;
            d_time.Size = new Size(95, 23);
            d_time.TabIndex = 35;
            d_time.ValueChanged += d_time_ValueChanged;
            // 
            // d_time2
            // 
            d_time2.Format = DateTimePickerFormat.Time;
            d_time2.Location = new Point(216, 224);
            d_time2.Name = "d_time2";
            d_time2.ShowUpDown = true;
            d_time2.Size = new Size(95, 23);
            d_time2.TabIndex = 36;
            // 
            // Exam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(953, 550);
            Controls.Add(d_time2);
            Controls.Add(d_time);
            Controls.Add(label5);
            Controls.Add(t_hall);
            Controls.Add(t_exam);
            Controls.Add(label4);
            Controls.Add(btn_add);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(t_date);
            Controls.Add(c_subject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_exam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Exam";
            Text = "Exam Maintenance";
            Load += Exam_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_exam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_exam;
        private Label label1;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private ComboBox c_subject;
        private DateTimePicker t_date;
        private PictureBox pictureBox1;
        private Label label3;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_add;
        private Label label4;
        private TextBox t_exam;
        private TextBox t_hall;
        private Label label5;
        private DateTimePicker d_time;
        private DateTimePicker d_time2;
    }
}