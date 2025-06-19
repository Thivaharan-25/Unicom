namespace UnicomTicManagementSystem.View
{
    partial class MarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkForm));
            btn_update = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            t_code = new TextBox();
            t_mark = new TextBox();
            c_subject = new ComboBox();
            dgv_result = new DataGridView();
            btn_delete = new Button();
            btn_add = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_result).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.ActiveCaptionText;
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(103, 354);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(85, 23);
            btn_update.TabIndex = 19;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 241);
            label1.Name = "label1";
            label1.Size = new Size(102, 19);
            label1.TabIndex = 20;
            label1.Text = "Subject Score";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 206);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 21;
            label2.Text = "Subject Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(102, 19);
            label3.TabIndex = 22;
            label3.Text = "Student Code";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, -43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 171);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // t_code
            // 
            t_code.Location = new Point(120, 164);
            t_code.Name = "t_code";
            t_code.Size = new Size(135, 23);
            t_code.TabIndex = 24;
            // 
            // t_mark
            // 
            t_mark.Location = new Point(120, 237);
            t_mark.Name = "t_mark";
            t_mark.Size = new Size(135, 23);
            t_mark.TabIndex = 25;
            // 
            // c_subject
            // 
            c_subject.DropDownStyle = ComboBoxStyle.DropDownList;
            c_subject.FormattingEnabled = true;
            c_subject.Location = new Point(120, 202);
            c_subject.Name = "c_subject";
            c_subject.Size = new Size(135, 23);
            c_subject.TabIndex = 26;
            // 
            // dgv_result
            // 
            dgv_result.BackgroundColor = SystemColors.ControlLightLight;
            dgv_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_result.Location = new Point(288, 34);
            dgv_result.Name = "dgv_result";
            dgv_result.Size = new Size(483, 357);
            dgv_result.TabIndex = 27;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.ActiveCaptionText;
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(197, 354);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(85, 23);
            btn_delete.TabIndex = 28;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += button1_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.ActiveCaptionText;
            btn_add.ForeColor = SystemColors.ControlLightLight;
            btn_add.Location = new Point(12, 354);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(85, 23);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(dgv_result);
            Controls.Add(c_subject);
            Controls.Add(t_mark);
            Controls.Add(t_code);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_update);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_result).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox t_code;
        private TextBox t_mark;
        private ComboBox c_subject;
        private DataGridView dgv_result;
        private Button btn_delete;
        private Button btn_add;
    }
}