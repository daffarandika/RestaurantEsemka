namespace r6
{
    partial class NonCash
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
            System.Windows.Forms.Label bankLabel;
            System.Windows.Forms.Label label1;
            this.bankComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            bankLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bankLabel
            // 
            bankLabel.AutoSize = true;
            bankLabel.Location = new System.Drawing.Point(60, 10);
            bankLabel.Name = "bankLabel";
            bankLabel.Size = new System.Drawing.Size(35, 13);
            bankLabel.TabIndex = 1;
            bankLabel.Text = "Bank:";
            // 
            // bankComboBox
            // 
            this.bankComboBox.FormattingEnabled = true;
            this.bankComboBox.Location = new System.Drawing.Point(101, 7);
            this.bankComboBox.Name = "bankComboBox";
            this.bankComboBox.Size = new System.Drawing.Size(224, 21);
            this.bankComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 3;
            label1.Text = "Card Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NonCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(bankLabel);
            this.Controls.Add(this.bankComboBox);
            this.Name = "NonCash";
            this.Size = new System.Drawing.Size(339, 131);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox bankComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
