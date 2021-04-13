
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.sexLabel = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumbBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPic = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.genderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(34, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(138, 35);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Last Name:";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadio);
            this.genderGroupBox.Controls.Add(this.maleRadio);
            this.genderGroupBox.Location = new System.Drawing.Point(37, 229);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderGroupBox.Size = new System.Drawing.Size(338, 86);
            this.genderGroupBox.TabIndex = 1;
            this.genderGroupBox.TabStop = false;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.femaleRadio.Location = new System.Drawing.Point(203, 27);
            this.femaleRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.maleRadio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maleRadio.Location = new System.Drawing.Point(22, 27);
            this.maleRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(90, 39);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexLabel.Location = new System.Drawing.Point(34, 192);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(101, 35);
            this.sexLabel.TabIndex = 0;
            this.sexLabel.Text = "Gender:";
            this.sexLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // fnameBox
            // 
            this.fnameBox.AccessibleName = "";
            this.fnameBox.Location = new System.Drawing.Point(167, 64);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(209, 27);
            this.fnameBox.TabIndex = 1;
            this.fnameBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BirthDate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(167, 106);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(209, 27);
            this.lnameBox.TabIndex = 2;
            this.lnameBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneNumbBox
            // 
            this.phoneNumbBox.Location = new System.Drawing.Point(167, 150);
            this.phoneNumbBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumbBox.Name = "phoneNumbBox";
            this.phoneNumbBox.Size = new System.Drawing.Size(209, 27);
            this.phoneNumbBox.TabIndex = 3;
            this.phoneNumbBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(167, 394);
            this.addressBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(209, 78);
            this.addressBox.TabIndex = 8;
            this.addressBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Picture:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(167, 346);
            this.birthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(209, 27);
            this.birthDate.TabIndex = 7;
            this.birthDate.ValueChanged += new System.EventHandler(this.birthDate_ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(167, 499);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(208, 219);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // uploadPic
            // 
            this.uploadPic.Location = new System.Drawing.Point(167, 718);
            this.uploadPic.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(208, 30);
            this.uploadPic.TabIndex = 5;
            this.uploadPic.Text = "Upload Picture";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Button);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(10, 770);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 42);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(224, 770);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(155, 42);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Add";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(167, 11);
            this.IDBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(209, 27);
            this.IDBox.TabIndex = 4;
            this.IDBox.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 840);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.phoneNumbBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNumbBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDBox;
        public System.Windows.Forms.RadioButton maleRadio;
        public System.Windows.Forms.RadioButton femaleRadio;
    }
}