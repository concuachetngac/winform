
namespace WinFormsApp1
{
    partial class printSave
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
            this.dataGridViewCheckUser.Location = new System.Drawing.Point(67, 258);
            this.dataGridViewCheckUser.Name = "dataGridViewCheckUser";
            this.dataGridViewCheckUser.RowHeadersWidth = 202;
            this.dataGridViewCheckUser.RowTemplate.Height = 150;
            this.dataGridViewCheckUser.Size = new System.Drawing.Size(1204, 562);
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
            this.groupBox1.Location = new System.Drawing.Point(326, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(544, 133);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(192, 27);
            this.dateTo.TabIndex = 8;
            // 
            // and
            // 
            this.and.AutoSize = true;
            this.and.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.and.Location = new System.Drawing.Point(469, 125);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(60, 35);
            this.and.TabIndex = 7;
            this.and.Text = "And";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(261, 133);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(192, 27);
            this.dateFrom.TabIndex = 6;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(32, 125);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(223, 35);
            this.date.TabIndex = 5;
            this.date.Text = "BirthDate Between:";
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noRadio.Location = new System.Drawing.Point(559, 33);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(70, 39);
            this.noRadio.TabIndex = 4;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // useDateRange
            // 
            this.useDateRange.AutoSize = true;
            this.useDateRange.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.useDateRange.Location = new System.Drawing.Point(32, 33);
            this.useDateRange.Name = "useDateRange";
            this.useDateRange.Size = new System.Drawing.Size(197, 35);
            this.useDateRange.TabIndex = 3;
            this.useDateRange.Text = "Use Date Range:";
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yesRadio.Location = new System.Drawing.Point(285, 33);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(72, 39);
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
            this.checkButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkButton.Location = new System.Drawing.Point(1126, 104);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(145, 74);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = false;
            // 
            // allRadio
            // 
            this.allRadio.AutoSize = true;
            this.allRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allRadio.Location = new System.Drawing.Point(105, 58);
            this.allRadio.Name = "allRadio";
            this.allRadio.Size = new System.Drawing.Size(64, 39);
            this.allRadio.TabIndex = 4;
            this.allRadio.TabStop = true;
            this.allRadio.Text = "All";
            this.allRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maleRadio.Location = new System.Drawing.Point(105, 109);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(90, 39);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.femaleRadio.Location = new System.Drawing.Point(105, 154);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(115, 39);
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
            this.toPrinterButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toPrinterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toPrinterButton.Location = new System.Drawing.Point(820, 853);
            this.toPrinterButton.Name = "toPrinterButton";
            this.toPrinterButton.Size = new System.Drawing.Size(318, 74);
            this.toPrinterButton.TabIndex = 7;
            this.toPrinterButton.Text = "To Printer";
            this.toPrinterButton.UseVisualStyleBackColor = false;
            // 
            // saveToTextFileButton
            // 
            this.saveToTextFileButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.saveToTextFileButton.FlatAppearance.BorderSize = 0;
            this.saveToTextFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToTextFileButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveToTextFileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveToTextFileButton.Location = new System.Drawing.Point(212, 853);
            this.saveToTextFileButton.Name = "saveToTextFileButton";
            this.saveToTextFileButton.Size = new System.Drawing.Size(318, 74);
            this.saveToTextFileButton.TabIndex = 8;
            this.saveToTextFileButton.Text = "Save To Text File";
            this.saveToTextFileButton.UseVisualStyleBackColor = false;
            // 
            // printSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 955);
            this.Controls.Add(this.saveToTextFileButton);
            this.Controls.Add(this.toPrinterButton);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.allRadio);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewCheckUser);
            this.Name = "printSave";
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