namespace UnicomTicManagementSystem
{
    partial class Unicom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            t_uname = new TextBox();
            t_password = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // t_uname
            // 
            t_uname.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_uname.Location = new Point(665, 139);
            t_uname.Name = "t_uname";
            t_uname.Size = new Size(159, 22);
            t_uname.TabIndex = 0;
            t_uname.TextChanged += t_uname_TextChanged;
            // 
            // t_password
            // 
            t_password.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_password.Location = new Point(665, 193);
            t_password.Name = "t_password";
            t_password.Size = new Size(159, 22);
            t_password.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.ActiveCaptionText;
            btn_login.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.ControlLightLight;
            btn_login.Location = new Point(738, 263);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(86, 25);
            btn_login.TabIndex = 2;
            btn_login.Text = "LOG-IN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(576, 142);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(576, 196);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(615, 61);
            label3.Name = "label3";
            label3.Size = new Size(149, 38);
            label3.TabIndex = 5;
            label3.Text = "LOG-IN";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.tic;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-7, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 490);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Unicom
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(914, 480);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(t_password);
            Controls.Add(t_uname);
            Font = new Font("Elephant", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Unicom";
            Text = "Unicom Tic Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox t_uname;
        private TextBox t_password;
        private Button btn_login;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
