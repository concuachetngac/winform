
namespace WinFormsApp1.form.CustomerForm
{
    partial class ShowFullContact
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
            this.allContactInfo = new System.Windows.Forms.DataGridView();
            this.groupListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allContactInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // allContactInfo
            // 
            this.allContactInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allContactInfo.Location = new System.Drawing.Point(274, 55);
            this.allContactInfo.Name = "allContactInfo";
            this.allContactInfo.RowTemplate.Height = 120;
            this.allContactInfo.Size = new System.Drawing.Size(874, 291);
            this.allContactInfo.TabIndex = 0;
            // 
            // groupListBox
            // 
            this.groupListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupListBox.FormattingEnabled = true;
            this.groupListBox.ItemHeight = 20;
            this.groupListBox.Location = new System.Drawing.Point(12, 55);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.groupListBox.Size = new System.Drawing.Size(224, 284);
            this.groupListBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(269, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Show All";
            // 
            // ShowFullContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1147, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.allContactInfo);
            this.Name = "ShowFullContact";
            this.Text = "ShowFullContact";
            this.Load += new System.EventHandler(this.ShowFullContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allContactInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allContactInfo;
        private System.Windows.Forms.ListBox groupListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}