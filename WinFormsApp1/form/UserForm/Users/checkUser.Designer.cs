
namespace WinFormsApp1
{
    partial class CheckUser
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
            this.dataGridViewCheckUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.and = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.useDateRange = new System.Windows.Forms.Label();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.allRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.toPrinterButton = new System.Windows.Forms.Button();
            this.saveToTextFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCheckUser
            // 
            this.dataGridViewCheckUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckUser.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewCheckUser.Location = new System.Drawing.Point(51, 168);
            this.dataGridViewCheckUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCheckUser.Name = "dataGridViewCheckUser";
            this.dataGridViewCheckUser.RowHeadersWidth = 101;
            this.dataGridViewCheckUser.RowTemplate.Height = 200;
            this.dataGridViewCheckUser.Size = new System.Drawing.Size(1021, 366);
            this.dataGridViewCheckUser.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.and);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.noRadio);
            this.groupBox1.Controls.Add(this.useDateRange);
            this.groupBox1.Controls.Add(this.yesRadio);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(324, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(571, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(408, 87);
            this.dateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(145, 20);
            this.dateTo.TabIndex = 8;
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.and.Location = new System.Drawing.Point(351, 81);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(48, 28);
            this.and.TabIndex = 7;
            this.and.Text = "And";
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(195, 87);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(145, 20);
            this.dateFrom.TabIndex = 6;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.date.Location = new System.Drawing.Point(24, 81);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(176, 28);
            this.date.TabIndex = 5;
            this.date.Text = "BirthDate Between:";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.noRadio.Location = new System.Drawing.Point(419, 22);
            this.noRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(57, 32);
            this.noRadio.TabIndex = 4;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // useDateRange
            // 
            this.useDateRange.AutoSize = true;
            this.useDateRange.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.useDateRange.Location = new System.Drawing.Point(24, 22);
            this.useDateRange.Name = "useDateRange";
            this.useDateRange.Size = new System.Drawing.Size(154, 28);
            this.useDateRange.TabIndex = 3;
            this.useDateRange.Text = "Use Date Range:";
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.yesRadio.Location = new System.Drawing.Point(213, 22);
            this.yesRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(57, 32);
            this.yesRadio.TabIndex = 2;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.checkButton.FlatAppearance.BorderSize = 0;
            this.checkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.checkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkButton.Location = new System.Drawing.Point(929, 63);
            this.checkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(109, 49);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            // 
            // allRadio
            // 
            this.allRadio.AutoSize = true;
            this.allRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.allRadio.Location = new System.Drawing.Point(79, 38);
            this.allRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(53, 32);
            this.allRadio.TabIndex = 4;
            this.allRadio.TabStop = true;
            this.allRadio.Text = "All";
            this.allRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.maleRadio.Location = new System.Drawing.Point(205, 98);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(73, 32);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.femaleRadio.Location = new System.Drawing.Point(79, 98);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(92, 32);
            this.femaleRadio.TabIndex = 6;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // toPrinterButton
            // 
            this.toPrinterButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.toPrinterButton.FlatAppearance.BorderSize = 0;
            this.toPrinterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toPrinterButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toPrinterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toPrinterButton.Location = new System.Drawing.Point(615, 555);
            this.toPrinterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toPrinterButton.Name = "toPrinterButton";
            this.toPrinterButton.Size = new System.Drawing.Size(238, 49);
            this.toPrinterButton.TabIndex = 7;
            this.toPrinterButton.Text = "To Printer";
            this.toPrinterButton.UseVisualStyleBackColor = false;
            this.toPrinterButton.Click += new System.EventHandler(this.toPrinterButton_Click);
            // 
            // saveToTextFileButton
            // 
            this.saveToTextFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveToTextFileButton.FlatAppearance.BorderSize = 0;
            this.saveToTextFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToTextFileButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.saveToTextFileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToTextFileButton.Location = new System.Drawing.Point(159, 555);
            this.saveToTextFileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveToTextFileButton.Name = "saveToTextFileButton";
            this.saveToTextFileButton.Size = new System.Drawing.Size(238, 49);
            this.saveToTextFileButton.TabIndex = 8;
            this.saveToTextFileButton.Text = "Save To Text File";
            this.saveToTextFileButton.UseVisualStyleBackColor = false;
            this.saveToTextFileButton.Click += new System.EventHandler(this.saveToTextFileButton_Click_1);
            // 
            // CheckUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 621);
            this.Controls.Add(this.saveToTextFileButton);
            this.Controls.Add(this.toPrinterButton);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.allRadio);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCheckUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckUser";
            this.Text = "Print & Save";
            this.Load += new System.EventHandler(this.printSave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCheckUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.Label useDateRange;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label and;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton allRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.Button toPrinterButton;
        private System.Windows.Forms.Button saveToTextFileButton;
    }
}