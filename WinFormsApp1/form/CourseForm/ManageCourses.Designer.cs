
namespace WinFormsApp1.form.CourseForm
{
    partial class ManageCourses
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.hoursNumbLab = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.labelBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.periodNumb = new System.Windows.Forms.NumericUpDown();
            this.firstButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.totalCourselLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.periodNumb)).BeginInit();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDLabel.Location = new System.Drawing.Point(152, 36);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(44, 29);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID:";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(219, 37);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(188, 30);
            this.IDBox.TabIndex = 1;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionLabel.Location = new System.Drawing.Point(49, 237);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(147, 29);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // hoursNumbLab
            // 
            this.hoursNumbLab.AutoSize = true;
            this.hoursNumbLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursNumbLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hoursNumbLab.Location = new System.Drawing.Point(12, 169);
            this.hoursNumbLab.Name = "hoursNumbLab";
            this.hoursNumbLab.Size = new System.Drawing.Size(184, 29);
            this.hoursNumbLab.TabIndex = 4;
            this.hoursNumbLab.Text = "Hours Number:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(114, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(82, 29);
            this.label.TabIndex = 5;
            this.label.Text = "Label:";
            // 
            // labelBox
            // 
            this.labelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBox.Location = new System.Drawing.Point(219, 100);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(286, 30);
            this.labelBox.TabIndex = 6;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(219, 238);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(286, 90);
            this.descriptionBox.TabIndex = 7;
            // 
            // periodNumb
            // 
            this.periodNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodNumb.Location = new System.Drawing.Point(219, 176);
            this.periodNumb.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.periodNumb.Name = "periodNumb";
            this.periodNumb.Size = new System.Drawing.Size(286, 32);
            this.periodNumb.TabIndex = 8;
            this.periodNumb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // firstButton
            // 
            this.firstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstButton.Location = new System.Drawing.Point(17, 399);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(137, 49);
            this.firstButton.TabIndex = 9;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextButton.Location = new System.Drawing.Point(182, 399);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(137, 49);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousButton.Location = new System.Drawing.Point(339, 399);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(137, 49);
            this.previousButton.TabIndex = 11;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastButton.Location = new System.Drawing.Point(503, 399);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(137, 49);
            this.lastButton.TabIndex = 12;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = false;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Cyan;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(93, 479);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 70);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(259, 479);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 70);
            this.button6.TabIndex = 14;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeButton.Location = new System.Drawing.Point(430, 479);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(137, 70);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // courseListBox
            // 
            this.courseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 38;
            this.courseListBox.Location = new System.Drawing.Point(693, 36);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(495, 498);
            this.courseListBox.TabIndex = 18;
            this.courseListBox.SelectedIndexChanged += new System.EventHandler(this.courseListBox_SelectedIndexChanged);
            // 
            // totalCourselLabel
            // 
            this.totalCourselLabel.AutoSize = true;
            this.totalCourselLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalCourselLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCourselLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalCourselLabel.Location = new System.Drawing.Point(942, 500);
            this.totalCourselLabel.Name = "totalCourselLabel";
            this.totalCourselLabel.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.totalCourselLabel.Size = new System.Drawing.Size(227, 49);
            this.totalCourselLabel.TabIndex = 19;
            this.totalCourselLabel.Text = "Total Courses:";
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1225, 583);
            this.Controls.Add(this.totalCourselLabel);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.periodNumb);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.hoursNumbLab);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDLabel);
            this.Name = "ManageCourses";
            this.Text = "ManageCourses";
            this.Load += new System.EventHandler(this.ManageCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.periodNumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label hoursNumbLab;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox labelBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.NumericUpDown periodNumb;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox courseListBox;
        private System.Windows.Forms.Label totalCourselLabel;
    }
}