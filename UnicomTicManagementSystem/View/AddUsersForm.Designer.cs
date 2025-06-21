namespace UnicomTicManagementSystem.View
{
    partial class AddUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsersForm));
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
            textBox1 = new TextBox();
            comboBox4 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            role = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)User_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // T_uname
            // 
            T_uname.Location = new Point(123, 162);
            T_uname.Name = "T_uname";
            T_uname.Size = new Size(185, 23);
            T_uname.TabIndex = 0;
            T_uname.TextChanged += T_uname_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 165);
            label1.Name = "label1";
            label1.Size = new Size(76, 14);
            label1.TabIndex = 1;
            label1.Text = "UserName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 203);
            label2.Name = "label2";
            label2.Size = new Size(72, 14);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // T_password
            // 
            T_password.Location = new Point(123, 200);
            T_password.Name = "T_password";
            T_password.Size = new Size(185, 23);
            T_password.TabIndex = 3;
            T_password.TextChanged += T_password_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 362);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 4;
            label3.Text = "Course";
            // 
            // Course
            // 
            Course.DropDownStyle = ComboBoxStyle.DropDownList;
            Course.FormattingEnabled = true;
            Course.Location = new Point(123, 359);
            Course.Name = "Course";
            Course.Size = new Size(145, 23);
            Course.TabIndex = 5;
            Course.SelectedIndexChanged += Course_SelectedIndexChanged;
            // 
            // btn_register
            // 
            btn_register.BackColor = SystemColors.ActiveCaptionText;
            btn_register.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_register.ForeColor = SystemColors.ControlLightLight;
            btn_register.Location = new Point(25, 454);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(75, 23);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(193, 454);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(285, 454);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(112, 454);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // User_dgv
            // 
            User_dgv.BackgroundColor = SystemColors.ControlLightLight;
            User_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            User_dgv.Location = new Point(383, 38);
            User_dgv.Name = "User_dgv";
            User_dgv.Size = new Size(630, 419);
            User_dgv.TabIndex = 11;
            User_dgv.CellContentClick += dataGridView1_CellContentClick;
            User_dgv.SelectionChanged += dgvStudents_SelectionChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Male", "Female" });
            comboBox4.Location = new Point(123, 314);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(145, 23);
            comboBox4.TabIndex = 17;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 323);
            label5.Name = "label5";
            label5.Size = new Size(55, 14);
            label5.TabIndex = 18;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 240);
            label4.Name = "label4";
            label4.Size = new Size(60, 14);
            label4.TabIndex = 22;
            label4.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 281);
            label9.Name = "label9";
            label9.Size = new Size(36, 14);
            label9.TabIndex = 23;
            label9.Text = "Role";
            // 
            // role
            // 
            role.DropDownStyle = ComboBoxStyle.DropDownList;
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Admin", "Lecturer", "Staff", "Student" });
            role.Location = new Point(123, 272);
            role.Name = "role";
            role.Size = new Size(145, 23);
            role.TabIndex = 24;
            role.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 145);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1058, 518);
            Controls.Add(pictureBox1);
            Controls.Add(role);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private TextBox textBox1;
        private ComboBox comboBox4;
        private Label label5;
        private Label label4;
        private Label label9;
        private ComboBox role;
        private PictureBox pictureBox1;
    }
}