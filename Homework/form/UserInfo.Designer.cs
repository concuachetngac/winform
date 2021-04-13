
namespace WindowsFormsApp2
{
    partial class UserInfo
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
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneNumbBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.bdateLabel = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.uploadPic = new System.Windows.Forms.Button();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fnameLabel.Location = new System.Drawing.Point(46, 62);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(140, 35);
            this.fnameLabel.TabIndex = 1;
            this.fnameLabel.Text = "First Name:";
            // 
            // fnameBox
            // 
            this.fnameBox.AccessibleName = "";
            this.fnameBox.Location = new System.Drawing.Point(192, 71);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(206, 27);
            this.fnameBox.TabIndex = 3;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnameLabel.Location = new System.Drawing.Point(46, 112);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(138, 35);
            this.lnameLabel.TabIndex = 4;
            this.lnameLabel.Text = "Last Name:";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(192, 112);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(206, 27);
            this.lnameBox.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(46, 162);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(90, 35);
            this.phoneLabel.TabIndex = 6;
            this.phoneLabel.Text = "Phone:";
            // 
            // phoneNumbBox
            // 
            this.phoneNumbBox.Location = new System.Drawing.Point(192, 170);
            this.phoneNumbBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumbBox.Name = "phoneNumbBox";
            this.phoneNumbBox.Size = new System.Drawing.Size(206, 27);
            this.phoneNumbBox.TabIndex = 7;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(46, 204);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(101, 35);
            this.genderLabel.TabIndex = 8;
            this.genderLabel.Text = "Gender:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.Location = new System.Drawing.Point(46, 19);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(45, 35);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "ID:";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(192, 27);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(206, 27);
            this.IDBox.TabIndex = 10;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadio);
            this.genderGroupBox.Controls.Add(this.maleRadio);
            this.genderGroupBox.Location = new System.Drawing.Point(46, 246);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Size = new System.Drawing.Size(338, 90);
            this.genderGroupBox.TabIndex = 11;
            this.genderGroupBox.TabStop = false;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.femaleRadio.Location = new System.Drawing.Point(201, 27);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(115, 39);
            this.femaleRadio.TabIndex = 0;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maleRadio.Location = new System.Drawing.Point(19, 27);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(90, 39);
            this.maleRadio.TabIndex = 0;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // bdateLabel
            // 
            this.bdateLabel.AutoSize = true;
            this.bdateLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bdateLabel.Location = new System.Drawing.Point(46, 359);
            this.bdateLabel.Name = "bdateLabel";
            this.bdateLabel.Size = new System.Drawing.Size(123, 35);
            this.bdateLabel.TabIndex = 3;
            this.bdateLabel.Text = "BirthDate:";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(192, 367);
            this.birthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(206, 27);
            this.birthDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(192, 414);
            this.addressBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(206, 78);
            this.addressBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(46, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 35);
            this.label5.TabIndex = 15;
            this.label5.Text = "Picture:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(193, 511);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(205, 210);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 16;
            this.pictureBox.TabStop = false;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(46, 786);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(155, 42);
            this.removeButton.TabIndex = 17;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.Location = new System.Drawing.Point(242, 785);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editButton.Name = "editButton";
            this.editButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editButton.Size = new System.Drawing.Size(155, 42);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // uploadPic
            // 
            this.uploadPic.Location = new System.Drawing.Point(192, 721);
            this.uploadPic.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(205, 30);
            this.uploadPic.TabIndex = 19;
            this.uploadPic.Text = "Upload Picture";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(420, 840);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.bdateLabel);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.phoneNumbBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.fnameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "User Infomation";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.Label bdateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        public System.Windows.Forms.TextBox fnameBox;
        public System.Windows.Forms.TextBox lnameBox;
        public System.Windows.Forms.TextBox phoneNumbBox;
        public System.Windows.Forms.TextBox IDBox;
        public System.Windows.Forms.DateTimePicker birthDate;
        public System.Windows.Forms.TextBox addressBox;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.RadioButton femaleRadio;
        public System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Button uploadPic;
    }
}