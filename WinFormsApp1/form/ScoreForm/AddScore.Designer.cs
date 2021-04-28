
namespace WinFormsApp1.form.ScoreForm
{
    partial class AddScore
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
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.desriptionLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.selectCourseBox = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listUserDataGrid = new System.Windows.Forms.DataGridView();
            this.coursesBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.studentIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.studentIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentIDLabel.Location = new System.Drawing.Point(40, 32);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(108, 28);
            this.studentIDLabel.TabIndex = 2;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(178, 36);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(121, 26);
            this.IDBox.TabIndex = 11;
            this.IDBox.TextChanged += new System.EventHandler(this.IDBox_TextChanged);
            // 
            // desriptionLabel
            // 
            this.desriptionLabel.AutoSize = true;
            this.desriptionLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.desriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.desriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desriptionLabel.Location = new System.Drawing.Point(40, 197);
            this.desriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desriptionLabel.Name = "desriptionLabel";
            this.desriptionLabel.Size = new System.Drawing.Size(107, 28);
            this.desriptionLabel.TabIndex = 12;
            this.desriptionLabel.Text = "Desription:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(40, 136);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 28);
            this.scoreLabel.TabIndex = 13;
            this.scoreLabel.Text = "Score:";
            // 
            // selectCourseBox
            // 
            this.selectCourseBox.AutoSize = true;
            this.selectCourseBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectCourseBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.selectCourseBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectCourseBox.Location = new System.Drawing.Point(40, 82);
            this.selectCourseBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectCourseBox.Name = "selectCourseBox";
            this.selectCourseBox.Size = new System.Drawing.Size(133, 28);
            this.selectCourseBox.TabIndex = 14;
            this.selectCourseBox.Text = "Select Course:";
            // 
            // scoreBox
            // 
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.Location = new System.Drawing.Point(178, 140);
            this.scoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(121, 26);
            this.scoreBox.TabIndex = 16;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionBox.Location = new System.Drawing.Point(178, 201);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(170, 65);
            this.descriptionBox.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(122, 294);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 41);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add Score";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listUserDataGrid
            // 
            this.listUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUserDataGrid.Location = new System.Drawing.Point(374, 32);
            this.listUserDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.listUserDataGrid.Name = "listUserDataGrid";
            this.listUserDataGrid.RowHeadersWidth = 17;
            this.listUserDataGrid.RowTemplate.Height = 24;
            this.listUserDataGrid.Size = new System.Drawing.Size(309, 303);
            this.listUserDataGrid.TabIndex = 19;
            // 
            // coursesBox
            // 
            this.coursesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.coursesBox.FormattingEnabled = true;
            this.coursesBox.Location = new System.Drawing.Point(178, 87);
            this.coursesBox.Name = "coursesBox";
            this.coursesBox.Size = new System.Drawing.Size(121, 26);
            this.coursesBox.TabIndex = 20;
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.coursesBox);
            this.Controls.Add(this.listUserDataGrid);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.selectCourseBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.desriptionLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.studentIDLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddScore";
            this.Text = "AddScore";
            this.Load += new System.EventHandler(this.AddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label desriptionLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label selectCourseBox;
        private System.Windows.Forms.TextBox scoreBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView listUserDataGrid;
        private System.Windows.Forms.ComboBox coursesBox;
    }
}