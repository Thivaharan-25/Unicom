namespace UnicomTicManagementSystem.View
{
    partial class StudentResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentResultForm));
            dgv_student = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.BackgroundColor = SystemColors.ControlLightLight;
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(50, 113);
            dgv_student.Name = "dgv_student";
            dgv_student.Size = new Size(829, 360);
            dgv_student.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(301, -52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 159);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // StudentResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(932, 518);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_student);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentResultForm";
            Text = "StudentResultForm";
            Load += StudentResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_student;
        private PictureBox pictureBox1;
    }
}