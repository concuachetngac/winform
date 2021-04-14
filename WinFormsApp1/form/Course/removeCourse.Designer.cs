
namespace WinFormsApp1.form
{
    partial class removeCourse
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
            this.removeButton = new System.Windows.Forms.Button();
            this.enterIDBox = new System.Windows.Forms.TextBox();
            this.enterCouseID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.removeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeButton.Location = new System.Drawing.Point(569, 50);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(152, 40);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // enterIDBox
            // 
            this.enterIDBox.Location = new System.Drawing.Point(293, 58);
            this.enterIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterIDBox.Multiline = true;
            this.enterIDBox.Name = "enterIDBox";
            this.enterIDBox.Size = new System.Drawing.Size(270, 28);
            this.enterIDBox.TabIndex = 1;
            this.enterIDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // enterCouseID
            // 
            this.enterCouseID.AutoSize = true;
            this.enterCouseID.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.enterCouseID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.enterCouseID.Location = new System.Drawing.Point(31, 57);
            this.enterCouseID.Name = "enterCouseID";
            this.enterCouseID.Size = new System.Drawing.Size(256, 35);
            this.enterCouseID.TabIndex = 2;
            this.enterCouseID.Text = "Enter The Course ID:";
            // 
            // removeCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 155);
            this.Controls.Add(this.enterCouseID);
            this.Controls.Add(this.enterIDBox);
            this.Controls.Add(this.removeButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "removeCourse";
            this.Text = "Remove Course";
            this.Load += new System.EventHandler(this.removeCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox enterIDBox;
        private System.Windows.Forms.Label enterCouseID;
    }
}