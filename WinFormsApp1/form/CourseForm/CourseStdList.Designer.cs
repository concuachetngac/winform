
namespace WinFormsApp1.form.CourseForm
{
    partial class CourseStdList
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
            this.label1 = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.listStudentView = new System.Windows.Forms.DataGridView();
            this.toPrinterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listStudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.semesterLabel.Location = new System.Drawing.Point(510, 52);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(123, 29);
            this.semesterLabel.TabIndex = 1;
            this.semesterLabel.Text = "Semester:";
            // 
            // courseNameBox
            // 
            this.courseNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.courseNameBox.Location = new System.Drawing.Point(201, 52);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(266, 27);
            this.courseNameBox.TabIndex = 2;
            // 
            // listStudentView
            // 
            this.listStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listStudentView.Location = new System.Drawing.Point(38, 107);
            this.listStudentView.Name = "listStudentView";
            this.listStudentView.Size = new System.Drawing.Size(633, 229);
            this.listStudentView.TabIndex = 3;
            this.listStudentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toPrinterButton
            // 
            this.toPrinterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toPrinterButton.FlatAppearance.BorderSize = 0;
            this.toPrinterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toPrinterButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toPrinterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toPrinterButton.Location = new System.Drawing.Point(229, 361);
            this.toPrinterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toPrinterButton.Name = "toPrinterButton";
            this.toPrinterButton.Size = new System.Drawing.Size(238, 49);
            this.toPrinterButton.TabIndex = 8;
            this.toPrinterButton.Text = "To Printer";
            this.toPrinterButton.UseVisualStyleBackColor = false;
            this.toPrinterButton.Click += new System.EventHandler(this.toPrinterButton_Click);
            // 
            // CourseStdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 421);
            this.Controls.Add(this.toPrinterButton);
            this.Controls.Add(this.listStudentView);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.label1);
            this.Name = "CourseStdList";
            this.Text = "CourseStdList";
            this.Load += new System.EventHandler(this.courseStdList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listStudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.DataGridView listStudentView;
        private System.Windows.Forms.Button toPrinterButton;
    }
}