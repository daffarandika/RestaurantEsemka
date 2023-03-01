namespace r6
{
    partial class VOrderUC
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
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderidComboBox = new System.Windows.Forms.ComboBox();
            this.detailid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            orderidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailid,
            this.menuC,
            this.qtyC,
            this.actionC});
            this.orderDataGridView.Location = new System.Drawing.Point(15, 107);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(773, 354);
            this.orderDataGridView.TabIndex = 1;
            this.orderDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.orderDataGridView_EditingControlShowing);
            // 
            // orderidLabel
            // 
            orderidLabel.AutoSize = true;
            orderidLabel.Location = new System.Drawing.Point(239, 43);
            orderidLabel.Name = "orderidLabel";
            orderidLabel.Size = new System.Drawing.Size(42, 13);
            orderidLabel.TabIndex = 3;
            orderidLabel.Text = "orderid:";
            // 
            // orderidComboBox
            // 
            this.orderidComboBox.FormattingEnabled = true;
            this.orderidComboBox.Location = new System.Drawing.Point(287, 40);
            this.orderidComboBox.Name = "orderidComboBox";
            this.orderidComboBox.Size = new System.Drawing.Size(242, 21);
            this.orderidComboBox.TabIndex = 4;
            this.orderidComboBox.SelectedIndexChanged += new System.EventHandler(this.orderidComboBox_SelectedIndexChanged);
            // 
            // detailid
            // 
            this.detailid.HeaderText = "Detail ID";
            this.detailid.Name = "detailid";
            this.detailid.Visible = false;
            // 
            // menuC
            // 
            this.menuC.HeaderText = "Menu";
            this.menuC.Name = "menuC";
            // 
            // qtyC
            // 
            this.qtyC.HeaderText = "Qty";
            this.qtyC.Name = "qtyC";
            // 
            // actionC
            // 
            this.actionC.HeaderText = "Action";
            this.actionC.Name = "actionC";
            // 
            // VOrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(orderidLabel);
            this.Controls.Add(this.orderidComboBox);
            this.Controls.Add(this.orderDataGridView);
            this.Name = "VOrderUC";
            this.Size = new System.Drawing.Size(800, 481);
            this.Load += new System.EventHandler(this.VOrderUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.ComboBox orderidComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailid;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuC;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyC;
        private System.Windows.Forms.DataGridViewComboBoxColumn actionC;
    }
}
