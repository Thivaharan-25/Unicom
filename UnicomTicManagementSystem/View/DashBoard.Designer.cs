namespace UnicomTicManagementSystem.View
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            admin_panel = new Panel();
            button1 = new Button();
            btn_course = new Button();
            btn_usermain = new Button();
            btn_timetable = new Button();
            btn_exammain = new Button();
            mainpanel = new Panel();
            btn_result = new Button();
            admin_panel.SuspendLayout();
            SuspendLayout();
            // 
            // admin_panel
            // 
            admin_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            admin_panel.BackColor = SystemColors.ActiveCaption;
            admin_panel.BackgroundImage = (Image)resources.GetObject("admin_panel.BackgroundImage");
            admin_panel.BorderStyle = BorderStyle.FixedSingle;
            admin_panel.Controls.Add(btn_result);
            admin_panel.Controls.Add(button1);
            admin_panel.Controls.Add(btn_course);
            admin_panel.Controls.Add(btn_usermain);
            admin_panel.Controls.Add(btn_timetable);
            admin_panel.Controls.Add(btn_exammain);
            admin_panel.Location = new Point(0, 0);
            admin_panel.Name = "admin_panel";
            admin_panel.Size = new Size(129, 490);
            admin_panel.TabIndex = 4;
            admin_panel.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(5, 300);
            button1.Name = "button1";
            button1.Size = new Size(115, 42);
            button1.TabIndex = 4;
            button1.Text = "Score Maintenance\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // btn_course
            // 
            btn_course.BackColor = SystemColors.Control;
            btn_course.BackgroundImage = (Image)resources.GetObject("btn_course.BackgroundImage");
            btn_course.BackgroundImageLayout = ImageLayout.Stretch;
            btn_course.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_course.Location = new Point(5, 363);
            btn_course.Name = "btn_course";
            btn_course.Size = new Size(115, 42);
            btn_course.TabIndex = 3;
            btn_course.Text = "Course Maintenance";
            btn_course.UseVisualStyleBackColor = false;
            btn_course.Click += btn_course_Click;
            // 
            // btn_usermain
            // 
            btn_usermain.BackColor = SystemColors.ButtonHighlight;
            btn_usermain.BackgroundImage = (Image)resources.GetObject("btn_usermain.BackgroundImage");
            btn_usermain.BackgroundImageLayout = ImageLayout.Stretch;
            btn_usermain.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_usermain.ForeColor = SystemColors.ControlText;
            btn_usermain.Location = new Point(5, 125);
            btn_usermain.Name = "btn_usermain";
            btn_usermain.Size = new Size(115, 35);
            btn_usermain.TabIndex = 0;
            btn_usermain.Text = "User Maintenance";
            btn_usermain.UseVisualStyleBackColor = false;
            btn_usermain.Click += btn_usermain_Click_1;
            // 
            // btn_timetable
            // 
            btn_timetable.BackColor = SystemColors.Control;
            btn_timetable.BackgroundImage = (Image)resources.GetObject("btn_timetable.BackgroundImage");
            btn_timetable.BackgroundImageLayout = ImageLayout.Stretch;
            btn_timetable.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_timetable.Location = new Point(5, 244);
            btn_timetable.Name = "btn_timetable";
            btn_timetable.Size = new Size(115, 36);
            btn_timetable.TabIndex = 2;
            btn_timetable.Text = "TimeTable";
            btn_timetable.UseVisualStyleBackColor = false;
            btn_timetable.Click += btn_timetable_Click_1;
            // 
            // btn_exammain
            // 
            btn_exammain.BackColor = SystemColors.Control;
            btn_exammain.BackgroundImage = (Image)resources.GetObject("btn_exammain.BackgroundImage");
            btn_exammain.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exammain.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exammain.Location = new Point(5, 183);
            btn_exammain.Name = "btn_exammain";
            btn_exammain.Size = new Size(115, 41);
            btn_exammain.TabIndex = 1;
            btn_exammain.Text = "Exam Maintenance";
            btn_exammain.UseVisualStyleBackColor = false;
            btn_exammain.Click += btn_exammain_Click;
            // 
            // mainpanel
            // 
            mainpanel.Location = new Point(127, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1021, 488);
            mainpanel.TabIndex = 5;
            mainpanel.Paint += mainpanel_Paint;
            // 
            // btn_result
            // 
            btn_result.BackColor = SystemColors.ButtonHighlight;
            btn_result.BackgroundImage = (Image)resources.GetObject("btn_result.BackgroundImage");
            btn_result.BackgroundImageLayout = ImageLayout.Stretch;
            btn_result.Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_result.Location = new Point(5, 80);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(115, 28);
            btn_result.TabIndex = 5;
            btn_result.Text = "Results\r\n";
            btn_result.UseVisualStyleBackColor = false;
            btn_result.Click += btn_result_Click;
            // 
            // Select
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1149, 488);
            Controls.Add(mainpanel);
            Controls.Add(admin_panel);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Select";
            Text = "Select";
            Load += Select_Load;
            admin_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel admin_panel;
        private Panel mainpanel;
        private Button btn_usermain;
        private Button btn_course;
        private Button btn_timetable;
        private Button btn_exammain;
        private Button button1;
        private Button btn_result;
    }
}