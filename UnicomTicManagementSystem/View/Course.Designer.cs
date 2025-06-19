namespace UnicomTicManagementSystem.View
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            dgv_course = new DataGridView();
            label1 = new Label();
            t_course = new TextBox();
            t_subject = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btn_add = new Button();
            btn_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_course).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_course
            // 
            dgv_course.BackgroundColor = SystemColors.ControlLightLight;
            dgv_course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_course.Location = new Point(407, 12);
            dgv_course.Name = "dgv_course";
            dgv_course.Size = new Size(340, 420);
            dgv_course.TabIndex = 0;
            dgv_course.CellContentClick += dataGridView1_CellContentClick;
            dgv_course.SelectionChanged += dgv_course_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 1;
            label1.Text = "Course Name";
            // 
            // t_course
            // 
            t_course.Location = new Point(117, 124);
            t_course.Name = "t_course";
            t_course.Size = new Size(248, 23);
            t_course.TabIndex = 2;
            // 
            // t_subject
            // 
            t_subject.Location = new Point(114, 176);
            t_subject.Name = "t_subject";
            t_subject.Size = new Size(251, 23);
            t_subject.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 176);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 4;
            label2.Text = "Subject";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 126);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaptionText;
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(143, 266);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 6;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveCaptionText;
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(267, 266);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 7;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(831, 505);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(t_subject);
            Controls.Add(t_course);
            Controls.Add(label1);
            Controls.Add(dgv_course);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Course";
            Text = "Course";
            ((System.ComponentModel.ISupportInitialize)dgv_course).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_course;
        private Label label1;
        private TextBox t_course;
        private TextBox t_subject;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btn_add;
        private Button btn_update;
    }
}