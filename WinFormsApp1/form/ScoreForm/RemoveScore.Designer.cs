
namespace WinFormsApp1.form.ScoreForm
{
    partial class RemoveScore
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
            this.listUserDataGrid = new System.Windows.Forms.DataGridView();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.selectCourseLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.coursesBox = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listUserDataGrid
            // 
            this.listUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUserDataGrid.Location = new System.Drawing.Point(355, 47);
            this.listUserDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.listUserDataGrid.Name = "listUserDataGrid";
            this.listUserDataGrid.RowHeadersWidth = 17;
            this.listUserDataGrid.RowTemplate.Height = 24;
            this.listUserDataGrid.Size = new System.Drawing.Size(624, 372);
            this.listUserDataGrid.TabIndex = 28;
            this.listUserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUserDataGrid_CellContentClick);
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.studentIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.studentIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentIDLabel.Location = new System.Drawing.Point(31, 62);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(108, 28);
            this.studentIDLabel.TabIndex = 29;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // selectCourseLabel
            // 
            this.selectCourseLabel.AutoSize = true;
            this.selectCourseLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectCourseLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.selectCourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectCourseLabel.Location = new System.Drawing.Point(31, 132);
            this.selectCourseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectCourseLabel.Name = "selectCourseLabel";
            this.selectCourseLabel.Size = new System.Drawing.Size(133, 28);
            this.selectCourseLabel.TabIndex = 30;
            this.selectCourseLabel.Text = "Select Course:";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(190, 64);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(121, 26);
            this.IDBox.TabIndex = 31;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // coursesBox
            // 
            this.coursesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.coursesBox.FormattingEnabled = true;
            this.coursesBox.Location = new System.Drawing.Point(190, 137);
            this.coursesBox.Name = "coursesBox";
            this.coursesBox.Size = new System.Drawing.Size(121, 26);
            this.coursesBox.TabIndex = 32;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(36, 378);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(275, 41);
            this.removeButton.TabIndex = 33;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1031, 453);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.coursesBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.selectCourseLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.listUserDataGrid);
            this.Name = "RemoveScore";
            this.Text = "RemoveScore";
            this.Load += new System.EventHandler(this.RemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listUserDataGrid;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label selectCourseLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.ComboBox coursesBox;
        private System.Windows.Forms.Button removeButton;
    }
}