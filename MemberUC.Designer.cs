namespace r6
{
    partial class MemberUC
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
            System.Windows.Forms.Label memberidLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label handphoneLabel;
            this.memberDataGridView = new System.Windows.Forms.DataGridView();
            this.memberidTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.handphoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            memberidLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            handphoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // memberDataGridView
            // 
            this.memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataGridView.Location = new System.Drawing.Point(29, 36);
            this.memberDataGridView.Name = "memberDataGridView";
            this.memberDataGridView.Size = new System.Drawing.Size(750, 231);
            this.memberDataGridView.TabIndex = 1;
            this.memberDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataGridView_CellClick);
            // 
            // memberidLabel
            // 
            memberidLabel.AutoSize = true;
            memberidLabel.Location = new System.Drawing.Point(237, 285);
            memberidLabel.Name = "memberidLabel";
            memberidLabel.Size = new System.Drawing.Size(55, 13);
            memberidLabel.TabIndex = 2;
            memberidLabel.Text = "memberid:";
            // 
            // memberidTextBox
            // 
            this.memberidTextBox.Location = new System.Drawing.Point(307, 282);
            this.memberidTextBox.Name = "memberidTextBox";
            this.memberidTextBox.Size = new System.Drawing.Size(200, 20);
            this.memberidTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(237, 311);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(307, 308);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(237, 337);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(307, 334);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // handphoneLabel
            // 
            handphoneLabel.AutoSize = true;
            handphoneLabel.Location = new System.Drawing.Point(237, 363);
            handphoneLabel.Name = "handphoneLabel";
            handphoneLabel.Size = new System.Drawing.Size(64, 13);
            handphoneLabel.TabIndex = 8;
            handphoneLabel.Text = "handphone:";
            // 
            // handphoneTextBox
            // 
            this.handphoneTextBox.Location = new System.Drawing.Point(307, 360);
            this.handphoneTextBox.Name = "handphoneTextBox";
            this.handphoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.handphoneTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MemberUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(memberidLabel);
            this.Controls.Add(this.memberidTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(handphoneLabel);
            this.Controls.Add(this.handphoneTextBox);
            this.Controls.Add(this.memberDataGridView);
            this.Name = "MemberUC";
            this.Size = new System.Drawing.Size(800, 481);
            this.Load += new System.EventHandler(this.MemberUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView memberDataGridView;
        private System.Windows.Forms.TextBox memberidTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox handphoneTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
