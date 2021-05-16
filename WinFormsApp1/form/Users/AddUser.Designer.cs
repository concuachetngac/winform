
namespace WindowsFormsApp2
{
    partial class AddUser
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
            this.lnameLabel = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneNumbBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.picLabel = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPic = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lnameLabel.Location = new System.Drawing.Point(23, 73);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(107, 28);
            this.lnameLabel.TabIndex = 0;
            this.lnameLabel.Text = "Last Name:";
            this.lnameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadio);
            this.genderGroupBox.Controls.Add(this.maleRadio);
            this.genderGroupBox.Location = new System.Drawing.Point(28, 169);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.genderGroupBox.Size = new System.Drawing.Size(308, 69);
            this.genderGroupBox.TabIndex = 1;
            this.genderGroupBox.TabStop = false;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.femaleRadio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.femaleRadio.Location = new System.Drawing.Point(197, 17);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(92, 32);
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
            this.maleRadio.Location = new System.Drawing.Point(29, 17);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(2);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(73, 32);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genderLabel.Location = new System.Drawing.Point(23, 139);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(80, 28);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fnameBox
            // 
            this.fnameBox.AccessibleName = "";
            this.fnameBox.Location = new System.Drawing.Point(159, 43);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(177, 20);
            this.fnameBox.TabIndex = 2;
            this.fnameBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.birthDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthDateLabel.Location = new System.Drawing.Point(23, 246);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(98, 28);
            this.birthDateLabel.TabIndex = 0;
            this.birthDateLabel.Text = "BirthDate:";
            this.birthDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.fnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fnameLabel.Location = new System.Drawing.Point(23, 34);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(110, 28);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "First Name:";
            this.fnameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(159, 82);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(177, 20);
            this.lnameBox.TabIndex = 3;
            this.lnameBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLabel.Location = new System.Drawing.Point(23, 111);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(71, 28);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone:";
            this.phoneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneNumbBox
            // 
            this.phoneNumbBox.Location = new System.Drawing.Point(159, 119);
            this.phoneNumbBox.Margin = new System.Windows.Forms.Padding(2);
            this.phoneNumbBox.Name = "phoneNumbBox";
            this.phoneNumbBox.Size = new System.Drawing.Size(177, 20);
            this.phoneNumbBox.TabIndex = 4;
            this.phoneNumbBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addressLabel.Location = new System.Drawing.Point(23, 281);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(86, 28);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(159, 290);
            this.addressBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(177, 53);
            this.addressBox.TabIndex = 8;
            this.addressBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // picLabel
            // 
            this.picLabel.AutoSize = true;
            this.picLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.picLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLabel.Location = new System.Drawing.Point(23, 361);
            this.picLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picLabel.Name = "picLabel";
            this.picLabel.Size = new System.Drawing.Size(76, 28);
            this.picLabel.TabIndex = 0;
            this.picLabel.Text = "Picture:";
            this.picLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthDate
            // 
            this.birthDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(159, 254);
            this.birthDate.Margin = new System.Windows.Forms.Padding(2);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(177, 20);
            this.birthDate.TabIndex = 7;
            this.birthDate.Value = new System.DateTime(2021, 4, 21, 0, 0, 0, 0);
            this.birthDate.ValueChanged += new System.EventHandler(this.birthDate_ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(159, 361);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(177, 142);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // uploadPic
            // 
            this.uploadPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadPic.Location = new System.Drawing.Point(159, 503);
            this.uploadPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(177, 26);
            this.uploadPic.TabIndex = 9;
            this.uploadPic.Text = "Upload Picture";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Button);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Aqua;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.cancelButton.Location = new System.Drawing.Point(28, 558);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 48);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Lime;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(211, 558);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 48);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.IDlabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.IDlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDlabel.Location = new System.Drawing.Point(23, 3);
            this.IDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(35, 28);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID:";
            this.IDlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(159, 11);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(177, 20);
            this.IDBox.TabIndex = 1;
            this.IDBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(365, 617);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.phoneNumbBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.picLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lnameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneNumbBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label picLabel;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDBox;
        public System.Windows.Forms.RadioButton maleRadio;
        public System.Windows.Forms.RadioButton femaleRadio;
    }
}