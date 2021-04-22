
namespace WinFormsApp1.form.Users
{
    partial class AddCourse
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.userIDLabel = new System.Windows.Forms.Label();
            this.selectSemesterLabel = new System.Windows.Forms.Label();
            this.semesterBox = new System.Windows.Forms.NumericUpDown();
            this.availableCourseListBox = new System.Windows.Forms.ListBox();
            this.selectedCourseListBox = new System.Windows.Forms.ListBox();
            this.availableCourseLabel = new System.Windows.Forms.Label();
            this.selectedCourseLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.semesterBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.idBox.Location = new System.Drawing.Point(192, 48);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(132, 32);
            this.idBox.TabIndex = 1;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.userIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userIDLabel.Location = new System.Drawing.Point(80, 43);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(102, 35);
            this.userIDLabel.TabIndex = 2;
            this.userIDLabel.Text = "User ID:";
            // 
            // selectSemesterLabel
            // 
            this.selectSemesterLabel.AutoSize = true;
            this.selectSemesterLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.selectSemesterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectSemesterLabel.Location = new System.Drawing.Point(521, 43);
            this.selectSemesterLabel.Name = "selectSemesterLabel";
            this.selectSemesterLabel.Size = new System.Drawing.Size(194, 35);
            this.selectSemesterLabel.TabIndex = 3;
            this.selectSemesterLabel.Text = "Select Semester:";
            // 
            // semesterBox
            // 
            this.semesterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterBox.Location = new System.Drawing.Point(743, 48);
            this.semesterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.semesterBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.semesterBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.semesterBox.Name = "semesterBox";
            this.semesterBox.Size = new System.Drawing.Size(125, 32);
            this.semesterBox.TabIndex = 11;
            this.semesterBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.semesterBox.ValueChanged += new System.EventHandler(this.semesterBox_ValueChanged);
            // 
            // availableCourseListBox
            // 
            this.availableCourseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.availableCourseListBox.FormattingEnabled = true;
            this.availableCourseListBox.ItemHeight = 26;
            this.availableCourseListBox.Location = new System.Drawing.Point(87, 186);
            this.availableCourseListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.availableCourseListBox.Name = "availableCourseListBox";
            this.availableCourseListBox.Size = new System.Drawing.Size(297, 212);
            this.availableCourseListBox.TabIndex = 12;
            // 
            // selectedCourseListBox
            // 
            this.selectedCourseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.selectedCourseListBox.FormattingEnabled = true;
            this.selectedCourseListBox.ItemHeight = 26;
            this.selectedCourseListBox.Location = new System.Drawing.Point(569, 186);
            this.selectedCourseListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectedCourseListBox.Name = "selectedCourseListBox";
            this.selectedCourseListBox.Size = new System.Drawing.Size(297, 212);
            this.selectedCourseListBox.TabIndex = 13;
            // 
            // availableCourseLabel
            // 
            this.availableCourseLabel.AutoSize = true;
            this.availableCourseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.availableCourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.availableCourseLabel.Location = new System.Drawing.Point(80, 148);
            this.availableCourseLabel.Name = "availableCourseLabel";
            this.availableCourseLabel.Size = new System.Drawing.Size(211, 35);
            this.availableCourseLabel.TabIndex = 14;
            this.availableCourseLabel.Text = "Available Course";
            // 
            // selectedCourseLabel
            // 
            this.selectedCourseLabel.AutoSize = true;
            this.selectedCourseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.selectedCourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectedCourseLabel.Location = new System.Drawing.Point(563, 148);
            this.selectedCourseLabel.Name = "selectedCourseLabel";
            this.selectedCourseLabel.Size = new System.Drawing.Size(203, 35);
            this.selectedCourseLabel.TabIndex = 15;
            this.selectedCourseLabel.Text = "Selected Course";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Cyan;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(409, 210);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 70);
            this.addButton.TabIndex = 16;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Cyan;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(409, 316);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 70);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(933, 448);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.selectedCourseLabel);
            this.Controls.Add(this.availableCourseLabel);
            this.Controls.Add(this.selectedCourseListBox);
            this.Controls.Add(this.availableCourseListBox);
            this.Controls.Add(this.semesterBox);
            this.Controls.Add(this.selectSemesterLabel);
            this.Controls.Add(this.userIDLabel);
            this.Controls.Add(this.idBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddCourse";
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semesterBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label selectSemesterLabel;
        private System.Windows.Forms.NumericUpDown semesterBox;
        private System.Windows.Forms.ListBox availableCourseListBox;
        private System.Windows.Forms.ListBox selectedCourseListBox;
        private System.Windows.Forms.Label availableCourseLabel;
        private System.Windows.Forms.Label selectedCourseLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button saveButton;
    }
}