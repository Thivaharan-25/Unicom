namespace UnicomTicManagementSystem.View
{
    partial class Select
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
            btn_timetable = new Button();
            admin_panel = new Panel();
            btn_exammain = new Button();
            btn_usermain = new Button();
            admin_panel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_timetable
            // 
            btn_timetable.FlatStyle = FlatStyle.Flat;
            btn_timetable.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_timetable.ForeColor = Color.White;
            btn_timetable.Location = new Point(7, 178);
            btn_timetable.Name = "btn_timetable";
            btn_timetable.Size = new Size(113, 32);
            btn_timetable.TabIndex = 2;
            btn_timetable.Text = "TimeTable";
            btn_timetable.UseVisualStyleBackColor = true;
            btn_timetable.Click += btn_timetable_Click;
            // 
            // admin_panel
            // 
            admin_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            admin_panel.BackColor = SystemColors.ActiveCaption;
            admin_panel.BorderStyle = BorderStyle.FixedSingle;
            admin_panel.Controls.Add(btn_exammain);
            admin_panel.Controls.Add(btn_usermain);
            admin_panel.Controls.Add(btn_timetable);
            admin_panel.Location = new Point(0, 0);
            admin_panel.Name = "admin_panel";
            admin_panel.Size = new Size(131, 452);
            admin_panel.TabIndex = 4;
            admin_panel.Paint += panel1_Paint;
            // 
            // btn_exammain
            // 
            btn_exammain.FlatStyle = FlatStyle.Flat;
            btn_exammain.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exammain.ForeColor = Color.White;
            btn_exammain.Location = new Point(7, 243);
            btn_exammain.Name = "btn_exammain";
            btn_exammain.Size = new Size(113, 32);
            btn_exammain.TabIndex = 7;
            btn_exammain.Text = "Exam Maintenance";
            btn_exammain.UseVisualStyleBackColor = true;
            // 
            // btn_usermain
            // 
            btn_usermain.FlatStyle = FlatStyle.Flat;
            btn_usermain.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_usermain.ForeColor = Color.White;
            btn_usermain.Location = new Point(7, 108);
            btn_usermain.Name = "btn_usermain";
            btn_usermain.Size = new Size(113, 32);
            btn_usermain.TabIndex = 5;
            btn_usermain.Text = "User Maintenance";
            btn_usermain.UseVisualStyleBackColor = true;
            btn_usermain.Click += btn_usermain_Click;
            // 
            // Select
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(927, 450);
            Controls.Add(admin_panel);
            Name = "Select";
            Text = "Select";
            admin_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_timetable;
        private Panel admin_panel;
        private Button btn_usermain;
        private Button btn_exammain;
    }
}