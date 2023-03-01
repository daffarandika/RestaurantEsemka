namespace r6
{
    partial class PaymentUC
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
            System.Windows.Forms.Label orderidLabel;
            System.Windows.Forms.Label paymentLabel;
            this.orderidComboBox = new System.Windows.Forms.ComboBox();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            orderidLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderidLabel
            // 
            orderidLabel.AutoSize = true;
            orderidLabel.Location = new System.Drawing.Point(230, 52);
            orderidLabel.Name = "orderidLabel";
            orderidLabel.Size = new System.Drawing.Size(42, 13);
            orderidLabel.TabIndex = 1;
            orderidLabel.Text = "orderid:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(37, 315);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(50, 13);
            paymentLabel.TabIndex = 4;
            paymentLabel.Text = "payment:";
            // 
            // orderidComboBox
            // 
            this.orderidComboBox.FormattingEnabled = true;
            this.orderidComboBox.Location = new System.Drawing.Point(278, 49);
            this.orderidComboBox.Name = "orderidComboBox";
            this.orderidComboBox.Size = new System.Drawing.Size(242, 21);
            this.orderidComboBox.TabIndex = 2;
            this.orderidComboBox.SelectedIndexChanged += new System.EventHandler(this.orderidComboBox_SelectedIndexChanged);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(42, 76);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(686, 230);
            this.orderDataGridView.TabIndex = 3;
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(113, 312);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(260, 21);
            this.paymentComboBox.TabIndex = 5;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.paymentComboBox_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 339);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(339, 131);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(537, 339);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 20);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total: 0";
            // 
            // PaymentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(paymentLabel);
            this.Controls.Add(this.paymentComboBox);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(orderidLabel);
            this.Controls.Add(this.orderidComboBox);
            this.Name = "PaymentUC";
            this.Size = new System.Drawing.Size(800, 481);
            this.Load += new System.EventHandler(this.PaymentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderidComboBox;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
    }
}
