
namespace WinFormsApp1.form.CustomerForm
{
    partial class EditMyInfo
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
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passWordBox = new System.Windows.Forms.TextBox();
            this.picLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.uploadPic = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fnameBox
            // 
            this.fnameBox.AccessibleName = "";
            this.fnameBox.BackColor = System.Drawing.Color.Gray;
            this.fnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.fnameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.fnameBox.Location = new System.Drawing.Point(133, 38);
            this.fnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(177, 23);
            this.fnameBox.TabIndex = 1;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.fnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fnameLabel.Location = new System.Drawing.Point(11, 31);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(110, 28);
            this.fnameLabel.TabIndex = 6;
            this.fnameLabel.Text = "First Name:";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lnameLabel.Location = new System.Drawing.Point(14, 71);
            this.lnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(107, 28);
            this.lnameLabel.TabIndex = 7;
            this.lnameLabel.Text = "Last Name:";
            // 
            // lnameBox
            // 
            this.lnameBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.lnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lnameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.lnameBox.Location = new System.Drawing.Point(133, 76);
            this.lnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(177, 23);
            this.lnameBox.TabIndex = 2;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLabel.Location = new System.Drawing.Point(17, 112);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(103, 28);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Username:";
            // 
            // userNameBox
            // 
            this.userNameBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.userNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.userNameBox.ForeColor = System.Drawing.SystemColors.Info;
            this.userNameBox.Location = new System.Drawing.Point(133, 119);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(177, 23);
            this.userNameBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password:";
            // 
            // passWordBox
            // 
            this.passWordBox.BackColor = System.Drawing.SystemColors.GrayText;
            this.passWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.passWordBox.ForeColor = System.Drawing.SystemColors.Info;
            this.passWordBox.Location = new System.Drawing.Point(133, 159);
            this.passWordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passWordBox.Name = "passWordBox";
            this.passWordBox.PasswordChar = '*';
            this.passWordBox.Size = new System.Drawing.Size(177, 23);
            this.passWordBox.TabIndex = 4;
            // 
            // picLabel
            // 
            this.picLabel.AutoSize = true;
            this.picLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.picLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picLabel.Location = new System.Drawing.Point(45, 196);
            this.picLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.picLabel.Name = "picLabel";
            this.picLabel.Size = new System.Drawing.Size(76, 28);
            this.picLabel.TabIndex = 13;
            this.picLabel.Text = "Picture:";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(133, 206);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(177, 142);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // uploadPic
            // 
            this.uploadPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadPic.Location = new System.Drawing.Point(133, 348);
            this.uploadPic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.uploadPic.Name = "uploadPic";
            this.uploadPic.Size = new System.Drawing.Size(177, 26);
            this.uploadPic.TabIndex = 5;
            this.uploadPic.Text = "Upload Picture";
            this.uploadPic.UseVisualStyleBackColor = true;
            this.uploadPic.Click += new System.EventHandler(this.uploadPic_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.editButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editButton.Location = new System.Drawing.Point(50, 422);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(238, 49);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // EditMyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(342, 511);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.uploadPic);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.picLabel);
            this.Controls.Add(this.passWordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.fnameBox);
            this.Name = "EditMyInfo";
            this.Text = "Edit My Info";
            this.Load += new System.EventHandler(this.EditMyInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passWordBox;
        private System.Windows.Forms.Label picLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button uploadPic;
        private System.Windows.Forms.Button editButton;
    }
}