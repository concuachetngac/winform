
namespace WinFormsApp1.form.ResultForm
{
    partial class StaticResult
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Static by Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(496, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Static by Result";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.passLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passLabel.Location = new System.Drawing.Point(502, 141);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(83, 31);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Pass:";
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.failLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.failLabel.Location = new System.Drawing.Point(502, 217);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(66, 31);
            this.failLabel.TabIndex = 4;
            this.failLabel.Text = "Fail:";
            // 
            // staticResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(887, 407);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "staticResult";
            this.Text = "Static Result";
            this.Load += new System.EventHandler(this.staticResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label failLabel;
    }
}