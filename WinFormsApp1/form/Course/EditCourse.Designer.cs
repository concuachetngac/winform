
namespace WinFormsApp1.form
{
    partial class EditCourse
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
            this.selectCourseLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.editCourseButton = new System.Windows.Forms.Button();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.periodNumb = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.periodNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // selectCourseLabel
            // 
            this.selectCourseLabel.AutoSize = true;
            this.selectCourseLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.selectCourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectCourseLabel.Location = new System.Drawing.Point(54, 27);
            this.selectCourseLabel.Name = "selectCourseLabel";
            this.selectCourseLabel.Size = new System.Drawing.Size(144, 28);
            this.selectCourseLabel.TabIndex = 2;
            this.selectCourseLabel.Text = "Select Course:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(54, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 28);
            this.label.TabIndex = 7;
            this.label.Text = "Label:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.periodLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.periodLabel.Location = new System.Drawing.Point(54, 121);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(77, 28);
            this.periodLabel.TabIndex = 8;
            this.periodLabel.Text = "Period:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Location = new System.Drawing.Point(57, 165);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(123, 28);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Decription: ";
            // 
            // labelBox
            // 
            this.labelBox.Location = new System.Drawing.Point(204, 75);
            this.labelBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(207, 29);
            this.labelBox.TabIndex = 2;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(203, 173);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(208, 55);
            this.descriptionBox.TabIndex = 5;
            // 
            // editCourseButton
            // 
            this.editCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.editCourseButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.editCourseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editCourseButton.Location = new System.Drawing.Point(57, 245);
            this.editCourseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editCourseButton.Name = "editCourseButton";
            this.editCourseButton.Size = new System.Drawing.Size(354, 44);
            this.editCourseButton.TabIndex = 13;
            this.editCourseButton.Text = "Edit";
            this.editCourseButton.UseVisualStyleBackColor = false;
            this.editCourseButton.Click += new System.EventHandler(this.editCourseButton_Click);
            // 
            // selectBox
            // 
            this.selectBox.FormattingEnabled = true;
            this.selectBox.ItemHeight = 21;
            this.selectBox.Location = new System.Drawing.Point(204, 27);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(207, 29);
            this.selectBox.TabIndex = 14;
            this.selectBox.SelectedIndexChanged += new System.EventHandler(this.selectBox_SelectedIndexChanged);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(318, 120);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(93, 29);
            this.IDBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(276, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            // 
            // periodNumb
            // 
            this.periodNumb.Location = new System.Drawing.Point(203, 121);
            this.periodNumb.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.periodNumb.Name = "periodNumb";
            this.periodNumb.Size = new System.Drawing.Size(51, 29);
            this.periodNumb.TabIndex = 3;
            this.periodNumb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(454, 311);
            this.Controls.Add(this.periodNumb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.editCourseButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectCourseLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Name = "EditCourse";
            this.Text = "Edit Course";
            this.Load += new System.EventHandler(this.EditCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectCourseLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button editCourseButton;
        private System.Windows.Forms.ComboBox selectBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown periodNumb;
    }
}