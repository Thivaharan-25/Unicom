namespace UnicomTicManagementSystem.View
{
    partial class student
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
            T_uname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            T_password = new TextBox();
            label3 = new Label();
            Course = new ComboBox();
            btn_register = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            User_dgv = new DataGridView();
            Subject1 = new ComboBox();
            subject2 = new ComboBox();
            subject3 = new ComboBox();
            textBox1 = new TextBox();
            comboBox4 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            label9 = new Label();
            role = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)User_dgv).BeginInit();
            SuspendLayout();
            // 
            // T_uname
            // 
            T_uname.Location = new Point(123, 24);
            T_uname.Name = "T_uname";
            T_uname.Size = new Size(185, 23);
            T_uname.TabIndex = 0;
            T_uname.TextChanged += T_uname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(76, 14);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(72, 14);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // T_password
            // 
            T_password.Location = new Point(123, 61);
            T_password.Name = "T_password";
            T_password.Size = new Size(185, 23);
            T_password.TabIndex = 3;
            T_password.TextChanged += T_password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 242);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 4;
            label3.Text = "Course";
            // 
            // Course
            // 
            Course.FormattingEnabled = true;
            Course.Items.AddRange(new object[] { "Mathematics", "Biology", "Arts", "Commerce", "Engineering Technology ", "Bio-system technology" });
            Course.Location = new Point(123, 239);
            Course.Name = "Course";
            Course.Size = new Size(145, 23);
            Course.TabIndex = 5;
            Course.SelectedIndexChanged += Course_SelectedIndexChanged;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.DeepSkyBlue;
            btn_register.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.Location = new Point(283, 421);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(193, 421);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(105, 421);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 421);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // User_dgv
            // 
            User_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            User_dgv.Location = new Point(383, 38);
            User_dgv.Name = "User_dgv";
            User_dgv.Size = new Size(630, 406);
            User_dgv.TabIndex = 11;
            User_dgv.CellContentClick += dataGridView1_CellContentClick;
            User_dgv.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // Subject1
            // 
            Subject1.FormattingEnabled = true;
            Subject1.Items.AddRange(new object[] { "Accounting", "BusinessStudies", "Finance", "Marketing", "Taxation", "Auditing", "Entrepreneurship", "Statistics", "Commercial Law", "History", "Geography", "Political Science", "Sociology", "Psychology", "Philosophy", "English Literature ", "Economics", "Arts", "Anthropology" });
            Subject1.Location = new Point(123, 280);
            Subject1.Name = "Subject1";
            Subject1.Size = new Size(145, 23);
            Subject1.TabIndex = 12;
            Subject1.SelectedIndexChanged += Subject1_SelectedIndexChanged_1;
            // 
            // subject2
            // 
            subject2.FormattingEnabled = true;
            subject2.Location = new Point(123, 324);
            subject2.Name = "subject2";
            subject2.Size = new Size(145, 23);
            subject2.TabIndex = 13;
            // 
            // subject3
            // 
            subject3.FormattingEnabled = true;
            subject3.Location = new Point(123, 365);
            subject3.Name = "subject3";
            subject3.Size = new Size(145, 23);
            subject3.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Male", "Female" });
            comboBox4.Location = new Point(123, 204);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(145, 23);
            comboBox4.TabIndex = 17;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 200);
            label5.Name = "label5";
            label5.Size = new Size(55, 14);
            label5.TabIndex = 18;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 283);
            label6.Name = "label6";
            label6.Size = new Size(89, 14);
            label6.TabIndex = 19;
            label6.Text = "Subject - 01";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 368);
            label7.Name = "label7";
            label7.Size = new Size(89, 14);
            label7.TabIndex = 20;
            label7.Text = "Subject - 03";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 327);
            label8.Name = "label8";
            label8.Size = new Size(89, 14);
            label8.TabIndex = 21;
            label8.Text = "Subject - 02";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 103);
            label4.Name = "label4";
            label4.Size = new Size(60, 14);
            label4.TabIndex = 22;
            label4.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 152);
            label9.Name = "label9";
            label9.Size = new Size(36, 14);
            label9.TabIndex = 23;
            label9.Text = "Role";
            // 
            // role
            // 
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Admin", "Lecturer", "Staff", "Student" });
            role.Location = new Point(123, 152);
            role.Name = "role";
            role.Size = new Size(145, 23);
            role.TabIndex = 24;
            role.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 518);
            Controls.Add(role);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(textBox1);
            Controls.Add(subject3);
            Controls.Add(subject2);
            Controls.Add(Subject1);
            Controls.Add(User_dgv);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_register);
            Controls.Add(Course);
            Controls.Add(label3);
            Controls.Add(T_password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(T_uname);
            FormBorderStyle = FormBorderStyle.None;
            Name = "student";
            Text = "ad_StudentMenu";
            Load += AddUsers_Load;
            ((System.ComponentModel.ISupportInitialize)User_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox T_uname;
        private Label label1;
        private Label label2;
        private TextBox T_password;
        private Label label3;
        private ComboBox Course;
        private DataGridView User_dgv;
        private Button btn_register;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox Subject1;
        private ComboBox subject2;
        private ComboBox subject3;
        private TextBox textBox1;
        private ComboBox comboBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label9;
        private ComboBox role;
    }
}