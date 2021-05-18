
namespace WinFormsApp1.form.CustomerForm.AddEditContact
{
    partial class SelectContact
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
            this.selectContactView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.selectContactView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectContactView
            // 
            this.selectContactView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectContactView.Location = new System.Drawing.Point(25, 25);
            this.selectContactView.Name = "selectContactView";
            this.selectContactView.Size = new System.Drawing.Size(392, 375);
            this.selectContactView.TabIndex = 0;
            this.selectContactView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectContactView_CellContentClick);
            // 
            // SelectContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(444, 421);
            this.Controls.Add(this.selectContactView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectContact";
            this.Text = "SelectContact";
            this.Load += new System.EventHandler(this.SelectContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectContactView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView selectContactView;
    }
}