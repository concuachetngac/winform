
namespace WinFormsApp1.form
{
    partial class AddCourses
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
            this.addCourseButton = new System.Windows.Forms.Button();
            this.courseLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.courseIDBox = new System.Windows.Forms.TextBox();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.periodNumb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.periodNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // addCourseButton
            // 
            this.addCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addCourseButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.addCourseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCourseButton.Location = new System.Drawing.Point(44, 210);
            this.addCourseButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(304, 37);
            this.addCourseButton.TabIndex = 0;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = false;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.courseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseLabel.Location = new System.Drawing.Point(44, 25);
            this.courseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(108, 28);
            this.courseLabel.TabIndex = 1;
            this.courseLabel.Text = "Course ID:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.periodLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.periodLabel.Location = new System.Drawing.Point(44, 96);
            this.periodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(77, 28);
            this.periodLabel.TabIndex = 2;
            this.periodLabel.Text = "Period:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Location = new System.Drawing.Point(44, 129);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(123, 28);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Decription: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(44, 61);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 28);
            this.label.TabIndex = 4;
            this.label.Text = "Label:";
            // 
            // courseIDBox
            // 
            this.courseIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIDBox.Location = new System.Drawing.Point(170, 25);
            this.courseIDBox.Margin = new System.Windows.Forms.Padding(2);
            this.courseIDBox.Name = "courseIDBox";
            this.courseIDBox.Size = new System.Drawing.Size(179, 23);
            this.courseIDBox.TabIndex = 5;
            // 
            // labelBox
            // 
            this.labelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox.Location = new System.Drawing.Point(170, 61);
            this.labelBox.Margin = new System.Windows.Forms.Padding(2);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(179, 23);
            this.labelBox.TabIndex = 6;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(170, 135);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(179, 48);
            this.descriptionBox.TabIndex = 8;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // periodNumb
            // 
            this.periodNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodNumb.Location = new System.Drawing.Point(170, 96);
            this.periodNumb.Margin = new System.Windows.Forms.Padding(2);
            this.periodNumb.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.periodNumb.Name = "periodNumb";
            this.periodNumb.Size = new System.Drawing.Size(178, 23);
            this.periodNumb.TabIndex = 9;
            this.periodNumb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.periodNumb);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.courseIDBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.addCourseButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCourses";
            this.Text = "Add Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox courseIDBox;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.NumericUpDown periodNumb;
        public System.Windows.Forms.Button addCourseButton;
    }
}