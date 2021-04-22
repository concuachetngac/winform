
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
            this.courseIDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listUserDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.studentIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.studentIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentIDLabel.Location = new System.Drawing.Point(54, 39);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(136, 35);
            this.studentIDLabel.TabIndex = 2;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(214, 44);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(139, 30);
            this.IDBox.TabIndex = 11;
            // 
            // desriptionLabel
            // 
            this.desriptionLabel.AutoSize = true;
            this.desriptionLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.desriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.desriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desriptionLabel.Location = new System.Drawing.Point(54, 242);
            this.desriptionLabel.Name = "desriptionLabel";
            this.desriptionLabel.Size = new System.Drawing.Size(135, 35);
            this.desriptionLabel.TabIndex = 12;
            this.desriptionLabel.Text = "Desription:";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(54, 168);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(82, 35);
            this.scoreLabel.TabIndex = 13;
            this.scoreLabel.Text = "Score:";
            // 
            // courseIDLabel
            // 
            this.courseIDLabel.AutoSize = true;
            this.courseIDLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.courseIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.courseIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.courseIDLabel.Location = new System.Drawing.Point(54, 101);
            this.courseIDLabel.Name = "courseIDLabel";
            this.courseIDLabel.Size = new System.Drawing.Size(129, 35);
            this.courseIDLabel.TabIndex = 14;
            this.courseIDLabel.Text = "Course ID:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(214, 113);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 30);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(214, 173);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 30);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(214, 247);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(226, 79);
            this.textBox3.TabIndex = 17;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(163, 362);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 50);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // listUserDataGrid
            // 
            this.listUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUserDataGrid.Location = new System.Drawing.Point(499, 39);
            this.listUserDataGrid.Name = "listUserDataGrid";
            this.listUserDataGrid.RowHeadersWidth = 17;
            this.listUserDataGrid.RowTemplate.Height = 24;
            this.listUserDataGrid.Size = new System.Drawing.Size(412, 373);
            this.listUserDataGrid.TabIndex = 19;
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(938, 444);
            this.Controls.Add(this.listUserDataGrid);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.courseIDLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.desriptionLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.studentIDLabel);
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
        private System.Windows.Forms.Label courseIDLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView listUserDataGrid;
    }
}