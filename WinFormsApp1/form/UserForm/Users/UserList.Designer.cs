
namespace WindowsFormsApp2
{
    partial class UserList
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
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataGridViewUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.refreshButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.refreshButton.Location = new System.Drawing.Point(448, 475);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(216, 50);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataGridViewUserList
            // 
            this.dataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserList.Location = new System.Drawing.Point(33, 26);
            this.dataGridViewUserList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUserList.Name = "dataGridViewUserList";
            this.dataGridViewUserList.RowHeadersWidth = 53;
            this.dataGridViewUserList.RowTemplate.Height = 150;
            this.dataGridViewUserList.Size = new System.Drawing.Size(970, 418);
            this.dataGridViewUserList.TabIndex = 2;
            this.dataGridViewUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 536);
            this.Controls.Add(this.dataGridViewUserList);
            this.Controls.Add(this.refreshButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserList";
            this.Text = "User List";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView dataGridViewUserList;
    }
}