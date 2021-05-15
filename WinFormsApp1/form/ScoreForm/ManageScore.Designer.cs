
namespace WinFormsApp1.form.ScoreForm
{
    partial class ManageScore
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
            this.IDBox = new System.Windows.Forms.TextBox();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.selectCourseLabel = new System.Windows.Forms.Label();
            this.coursesBox = new System.Windows.Forms.ComboBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.desriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listUserDataGrid = new System.Windows.Forms.DataGridView();
            this.removeButton = new System.Windows.Forms.Button();
            this.avgScoreButton = new System.Windows.Forms.Button();
            this.showStudentButton = new System.Windows.Forms.Button();
            this.showScoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(183, 44);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(121, 26);
            this.IDBox.TabIndex = 12;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.studentIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.studentIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentIDLabel.Location = new System.Drawing.Point(35, 40);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(108, 28);
            this.studentIDLabel.TabIndex = 13;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // selectCourseLabel
            // 
            this.selectCourseLabel.AutoSize = true;
            this.selectCourseLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectCourseLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.selectCourseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectCourseLabel.Location = new System.Drawing.Point(35, 95);
            this.selectCourseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectCourseLabel.Name = "selectCourseLabel";
            this.selectCourseLabel.Size = new System.Drawing.Size(133, 28);
            this.selectCourseLabel.TabIndex = 15;
            this.selectCourseLabel.Text = "Select Course:";
            // 
            // coursesBox
            // 
            this.coursesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.coursesBox.FormattingEnabled = true;
            this.coursesBox.Location = new System.Drawing.Point(183, 100);
            this.coursesBox.Name = "coursesBox";
            this.coursesBox.Size = new System.Drawing.Size(121, 26);
            this.coursesBox.TabIndex = 21;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(35, 153);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 28);
            this.scoreLabel.TabIndex = 22;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreBox
            // 
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(183, 157);
            this.scoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(121, 26);
            this.scoreBox.TabIndex = 23;
            // 
            // desriptionLabel
            // 
            this.desriptionLabel.AutoSize = true;
            this.desriptionLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.desriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.desriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desriptionLabel.Location = new System.Drawing.Point(36, 213);
            this.desriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desriptionLabel.Name = "desriptionLabel";
            this.desriptionLabel.Size = new System.Drawing.Size(107, 28);
            this.desriptionLabel.TabIndex = 24;
            this.desriptionLabel.Text = "Desription:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(183, 217);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(170, 65);
            this.descriptionBox.TabIndex = 25;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(25, 338);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 41);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listUserDataGrid
            // 
            this.listUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUserDataGrid.Location = new System.Drawing.Point(401, 67);
            this.listUserDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.listUserDataGrid.Name = "listUserDataGrid";
            this.listUserDataGrid.RowHeadersWidth = 17;
            this.listUserDataGrid.RowTemplate.Height = 24;
            this.listUserDataGrid.Size = new System.Drawing.Size(624, 372);
            this.listUserDataGrid.TabIndex = 27;
            this.listUserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUserDataGrid_CellContentClick);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(210, 338);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(143, 41);
            this.removeButton.TabIndex = 28;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // avgScoreButton
            // 
            this.avgScoreButton.BackColor = System.Drawing.Color.Blue;
            this.avgScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgScoreButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.avgScoreButton.Location = new System.Drawing.Point(25, 398);
            this.avgScoreButton.Margin = new System.Windows.Forms.Padding(2);
            this.avgScoreButton.Name = "avgScoreButton";
            this.avgScoreButton.Size = new System.Drawing.Size(328, 41);
            this.avgScoreButton.TabIndex = 29;
            this.avgScoreButton.Text = "Avarage Score By Course";
            this.avgScoreButton.UseVisualStyleBackColor = false;
            this.avgScoreButton.Click += new System.EventHandler(this.avgScoreButton_Click);
            // 
            // showStudentButton
            // 
            this.showStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.showStudentButton.Location = new System.Drawing.Point(401, 30);
            this.showStudentButton.Name = "showStudentButton";
            this.showStudentButton.Size = new System.Drawing.Size(311, 32);
            this.showStudentButton.TabIndex = 30;
            this.showStudentButton.Text = "Show Student";
            this.showStudentButton.UseVisualStyleBackColor = true;
            this.showStudentButton.Click += new System.EventHandler(this.showStudentButton_Click);
            // 
            // showScoreButton
            // 
            this.showScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.showScoreButton.Location = new System.Drawing.Point(714, 30);
            this.showScoreButton.Name = "showScoreButton";
            this.showScoreButton.Size = new System.Drawing.Size(311, 32);
            this.showScoreButton.TabIndex = 31;
            this.showScoreButton.Text = "Show Scores";
            this.showScoreButton.UseVisualStyleBackColor = true;
            this.showScoreButton.Click += new System.EventHandler(this.showScoreButton_Click);
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1072, 477);
            this.Controls.Add(this.showScoreButton);
            this.Controls.Add(this.showStudentButton);
            this.Controls.Add(this.avgScoreButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.listUserDataGrid);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.desriptionLabel);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.coursesBox);
            this.Controls.Add(this.selectCourseLabel);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.IDBox);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label selectCourseLabel;
        private System.Windows.Forms.ComboBox coursesBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.Label desriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView listUserDataGrid;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button avgScoreButton;
        private System.Windows.Forms.Button showStudentButton;
        private System.Windows.Forms.Button showScoreButton;
    }
}