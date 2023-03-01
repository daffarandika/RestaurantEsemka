namespace r6
{
    partial class CashUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label bankLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.tbCash = new System.Windows.Forms.TextBox();
            this.tbChange = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            bankLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 13);
            label1.TabIndex = 9;
            label1.Text = "Change :";
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(16, 7);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(37, 13);
            bankLabel.TabIndex = 7;
            bankLabel.Text = "Cash :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCash
            // 
            this.tbCash.Location = new System.Drawing.Point(70, 3);
            this.tbCash.Name = "tbCash";
            this.tbCash.Size = new System.Drawing.Size(250, 20);
            this.tbCash.TabIndex = 10;
            // 
            // tbChange
            // 
            this.tbChange.Location = new System.Drawing.Point(70, 31);
            this.tbChange.Name = "tbChange";
            this.tbChange.Size = new System.Drawing.Size(250, 20);
            this.tbChange.TabIndex = 12;
            // 
            // CashUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCash);
            this.Controls.Add(label1);
            this.Controls.Add(bankLabel);
            this.Name = "CashUC";
            this.Size = new System.Drawing.Size(339, 131);
            this.Load += new System.EventHandler(this.CashUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCash;
        private System.Windows.Forms.TextBox tbChange;
    }
}
