
namespace WindowsFormsApp2.formFile
{
    partial class Register
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
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.userNameLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(283, 147);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(271, 31);
            this.textBoxUser.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(283, 208);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPass.Size = new System.Drawing.Size(271, 31);
            this.textBoxPass.TabIndex = 3;
            // 
            // userNameLab
            // 
            this.userNameLab.AutoSize = true;
            this.userNameLab.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameLab.ForeColor = System.Drawing.SystemColors.Desktop;
            this.userNameLab.Location = new System.Drawing.Point(60, 138);
            this.userNameLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLab.Name = "userNameLab";
            this.userNameLab.Size = new System.Drawing.Size(159, 41);
            this.userNameLab.TabIndex = 4;
            this.userNameLab.Text = "Username:";
            this.userNameLab.Click += new System.EventHandler(this.userNameLab_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(60, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.ForestGreen;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.SystemColors.Control;
            this.signUpButton.Location = new System.Drawing.Point(354, 287);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(273, 62);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(60, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 41);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(60, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ID.Location = new System.Drawing.Point(60, 58);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(54, 41);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID:";
            this.ID.Click += new System.EventHandler(this.userNameLab_Click);
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(283, 67);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(271, 31);
            this.IDBox.TabIndex = 2;
            this.IDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(656, 392);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.userNameLab);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label userNameLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDBox;
    }
}