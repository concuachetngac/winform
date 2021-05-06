
namespace WinFormsApp1.form.ScoreForm
{
    partial class AverageGrade
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
            this.avgGradeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.avgGradeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // avgGradeGrid
            // 
            this.avgGradeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avgGradeGrid.Location = new System.Drawing.Point(0, 0);
            this.avgGradeGrid.Name = "avgGradeGrid";
            this.avgGradeGrid.Size = new System.Drawing.Size(389, 335);
            this.avgGradeGrid.TabIndex = 0;
            // 
            // AverageGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 333);
            this.Controls.Add(this.avgGradeGrid);
            this.Name = "AverageGrade";
            this.Text = "AverageGrade";
            this.Load += new System.EventHandler(this.AverageGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avgGradeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView avgGradeGrid;
    }
}