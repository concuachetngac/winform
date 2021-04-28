
namespace WinFormsApp1.form.CourseForm
{
    partial class Print
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
            this.courseListGrid = new System.Windows.Forms.DataGridView();
            this.saveToTextFileButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // courseListGrid
            // 
            this.courseListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseListGrid.Location = new System.Drawing.Point(12, 12);
            this.courseListGrid.Name = "courseListGrid";
            this.courseListGrid.Size = new System.Drawing.Size(995, 374);
            this.courseListGrid.TabIndex = 0;
            // 
            // saveToTextFileButton
            // 
            this.saveToTextFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveToTextFileButton.FlatAppearance.BorderSize = 0;
            this.saveToTextFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToTextFileButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.saveToTextFileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToTextFileButton.Location = new System.Drawing.Point(92, 414);
            this.saveToTextFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveToTextFileButton.Name = "saveToTextFileButton";
            this.saveToTextFileButton.Size = new System.Drawing.Size(238, 49);
            this.saveToTextFileButton.TabIndex = 9;
            this.saveToTextFileButton.Text = "Save To Text File";
            this.saveToTextFileButton.UseVisualStyleBackColor = false;
            this.saveToTextFileButton.Click += new System.EventHandler(this.saveToTextFileButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printButton.Location = new System.Drawing.Point(644, 414);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(238, 49);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "To Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1019, 494);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.saveToTextFileButton);
            this.Controls.Add(this.courseListGrid);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView courseListGrid;
        private System.Windows.Forms.Button saveToTextFileButton;
        private System.Windows.Forms.Button printButton;
    }
}