
namespace WinFormsApp1.form.ResultForm
{
    partial class AvgResult
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.listUserDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.studentIDLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.studentIDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentIDLabel.Location = new System.Drawing.Point(51, 76);
            this.studentIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(108, 28);
            this.studentIDLabel.TabIndex = 14;
            this.studentIDLabel.Text = "Student ID:";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(165, 80);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(121, 26);
            this.IDBox.TabIndex = 15;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.fnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fnameLabel.Location = new System.Drawing.Point(51, 128);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(110, 28);
            this.fnameLabel.TabIndex = 16;
            this.fnameLabel.Text = "First Name:";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lname.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lname.Location = new System.Drawing.Point(51, 179);
            this.lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(107, 28);
            this.lname.TabIndex = 23;
            this.lname.Text = "Last Name:";
            // 
            // lnameBox
            // 
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameBox.Location = new System.Drawing.Point(165, 183);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(121, 26);
            this.lnameBox.TabIndex = 24;
            // 
            // fnameBox
            // 
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameBox.Location = new System.Drawing.Point(165, 132);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(121, 26);
            this.fnameBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search By ID, First Name";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.searchButton.Location = new System.Drawing.Point(56, 294);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 36);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(165, 299);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 26);
            this.searchBox.TabIndex = 28;
            // 
            // listUserDataGrid
            // 
            this.listUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUserDataGrid.Location = new System.Drawing.Point(443, 76);
            this.listUserDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.listUserDataGrid.Name = "listUserDataGrid";
            this.listUserDataGrid.RowHeadersWidth = 17;
            this.listUserDataGrid.RowTemplate.Height = 24;
            this.listUserDataGrid.Size = new System.Drawing.Size(875, 249);
            this.listUserDataGrid.TabIndex = 29;
            this.listUserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUserDataGrid_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(438, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 43);
            this.label2.TabIndex = 30;
            this.label2.Text = "Student Result";
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.printButton.Location = new System.Drawing.Point(446, 345);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 36);
            this.printButton.TabIndex = 31;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cancelButton.Location = new System.Drawing.Point(612, 345);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 36);
            this.cancelButton.TabIndex = 32;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1382, 393);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUserDataGrid);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.studentIDLabel);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView listUserDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button cancelButton;
    }
}