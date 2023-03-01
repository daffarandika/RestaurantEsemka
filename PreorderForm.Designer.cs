namespace r6
{
    partial class PreorderForm
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
            System.Windows.Forms.Label memberidLabel;
            this.memberidComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            memberidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberidLabel
            // 
            memberidLabel.AutoSize = true;
            memberidLabel.Location = new System.Drawing.Point(86, 43);
            memberidLabel.Name = "memberidLabel";
            memberidLabel.Size = new System.Drawing.Size(55, 13);
            memberidLabel.TabIndex = 1;
            memberidLabel.Text = "memberid:";
            // 
            // memberidComboBox
            // 
            this.memberidComboBox.FormattingEnabled = true;
            this.memberidComboBox.Location = new System.Drawing.Point(147, 40);
            this.memberidComboBox.Name = "memberidComboBox";
            this.memberidComboBox.Size = new System.Drawing.Size(213, 21);
            this.memberidComboBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 179);
            this.Controls.Add(this.button1);
            this.Controls.Add(memberidLabel);
            this.Controls.Add(this.memberidComboBox);
            this.Name = "PreorderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreorderForm";
            this.Load += new System.EventHandler(this.PreorderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox memberidComboBox;
        private System.Windows.Forms.Button button1;
    }
}