
namespace WinFormsApp1.form.Users
{
    partial class ManageUser
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.picLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.phoneNumbBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPic = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.listUserDataGrid = new System.Windows.Forms.DataGridView();
            this.totalUserLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.enterIDBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.IDlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDlabel.Location = new System.Drawing.Point(60, 31);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(45, 35);
            this.IDlabel.TabIndex = 1;
            this.IDlabel.Text = "ID:";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.fnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fnameLabel.Location = new System.Drawing.Point(60, 84);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(140, 35);
            this.fnameLabel.TabIndex = 2;
            this.fnameLabel.Text = "First Name:";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lnameLabel.Location = new System.Drawing.Point(60, 145);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(138, 35);
            this.lnameLabel.TabIndex = 3;
            this.lnameLabel.Text = "Last Name:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLabel.Location = new System.Drawing.Point(60, 210);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(90, 35);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Phone:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genderLabel.Location = new System.Drawing.Point(60, 266);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(101, 35);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender:";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadio);
            this.genderGroupBox.Controls.Add(this.maleRadio);
            this.genderGroupBox.Location = new System.Drawing.Point(67, 327);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderGroupBox.Size = new System.Drawing.Size(385, 85);
            this.genderGroupBox.TabIndex = 6;
            this.genderGroupBox.TabStop = false;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.femaleRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.femaleRadio.Location = new System.Drawing.Point(257, 21);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(115, 39);
            this.femaleRadio.TabIndex = 6;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.maleRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maleRadio.Location = new System.Drawing.Point(39, 21);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(90, 39);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.birthDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthDateLabel.Location = new System.Drawing.Point(60, 442);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(123, 35);
            this.birthDateLabel.TabIndex = 7;
            this.birthDateLabel.Text = "BirthDate:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressLabel.Location = new System.Drawing.Point(60, 505);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(110, 35);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address:";
            // 
            // picLabel
            // 
            this.picLabel.AutoSize = true;
            this.picLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.picLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLabel.Location = new System.Drawing.Point(60, 604);
            this.picLabel.Name = "picLabel";
            this.picLabel.Size = new System.Drawing.Size(96, 35);
            this.picLabel.TabIndex = 9;
            this.picLabel.Text = "Picture:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(216, 41);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(235, 22);
            this.IDBox.TabIndex = 10;
            // 
            // fnameBox
            // 
            this.fnameBox.AccessibleName = "";
            this.fnameBox.Location = new System.Drawing.Point(216, 95);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(235, 22);
            this.fnameBox.TabIndex = 11;
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(216, 156);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(235, 22);
            this.lnameBox.TabIndex = 12;
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(216, 449);
            this.birthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(235, 22);
            this.birthDate.TabIndex = 13;
            // 
            // phoneNumbBox
            // 
            this.phoneNumbBox.Location = new System.Drawing.Point(216, 222);
            this.phoneNumbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNumbBox.Name = "phoneNumbBox";
            this.phoneNumbBox.Size = new System.Drawing.Size(235, 22);
            this.phoneNumbBox.TabIndex = 14;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(216, 516);
            this.addressBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(235, 64);
            this.addressBox.TabIndex = 15;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(216, 604);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(236, 208);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // uploadPic
            // 
            this.uploadPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadPic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadPic.Location = new System.Drawing.Point(216, 812);
            this.uploadPic.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(117, 32);
            this.uploadPic.TabIndex = 17;
            this.uploadPic.Text = "Upload Picture";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Cyan;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(65, 887);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 49);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Lime;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(253, 887);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(137, 49);
            this.editButton.TabIndex = 19;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.removeButton.Location = new System.Drawing.Point(439, 887);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(137, 49);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.DarkOrange;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(633, 887);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(137, 49);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadButton.Location = new System.Drawing.Point(335, 812);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(117, 32);
            this.downloadButton.TabIndex = 22;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // listUserDataGrid
            // 
            this.listUserDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUserDataGrid.Location = new System.Drawing.Point(501, 84);
            this.listUserDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.listUserDataGrid.Name = "listUserDataGrid";
            this.listUserDataGrid.RowHeadersWidth = 51;
            this.listUserDataGrid.RowTemplate.Height = 100;
            this.listUserDataGrid.Size = new System.Drawing.Size(1257, 761);
            this.listUserDataGrid.TabIndex = 23;
            this.listUserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listUserDataGrid_CellContentClick);
            // 
            // totalUserLabel
            // 
            this.totalUserLabel.AutoSize = true;
            this.totalUserLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalUserLabel.Location = new System.Drawing.Point(1543, 844);
            this.totalUserLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalUserLabel.Name = "totalUserLabel";
            this.totalUserLabel.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.totalUserLabel.Size = new System.Drawing.Size(220, 49);
            this.totalUserLabel.TabIndex = 24;
            this.totalUserLabel.Text = "Total Users: 1";
            this.totalUserLabel.Click += new System.EventHandler(this.totalUserLabel_Click);
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.enterLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.enterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterLabel.Location = new System.Drawing.Point(801, 30);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(223, 35);
            this.enterLabel.TabIndex = 25;
            this.enterLabel.Text = "Enter ID To Search:";
            // 
            // enterIDBox
            // 
            this.enterIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.enterIDBox.Location = new System.Drawing.Point(1056, 32);
            this.enterIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterIDBox.Name = "enterIDBox";
            this.enterIDBox.Size = new System.Drawing.Size(308, 32);
            this.enterIDBox.TabIndex = 26;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(1357, 32);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(137, 34);
            this.searchButton.TabIndex = 27;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1780, 961);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.enterIDBox);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.totalUserLabel);
            this.Controls.Add(this.listUserDataGrid);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.phoneNumbBox);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.picLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.IDlabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageUser";
            this.Text = "Manage User";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listUserDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.GroupBox genderGroupBox;
        public System.Windows.Forms.RadioButton femaleRadio;
        public System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label picLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.TextBox phoneNumbBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.DataGridView listUserDataGrid;
        private System.Windows.Forms.Label totalUserLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox enterIDBox;
        private System.Windows.Forms.Button searchButton;
    }
}