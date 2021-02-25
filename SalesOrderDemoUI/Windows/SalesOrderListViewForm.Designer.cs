
namespace SalesOrderDemoUI.Windows
{
    partial class SalesOrderListViewForm
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnAddNew = new FontAwesome.Sharp.IconButton();
            this.dgvSalesOrders = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtReferenceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tlpMain.Controls.Add(this.panelHeader, 1, 0);
            this.tlpMain.Controls.Add(this.dgvSalesOrders, 1, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMain.Size = new System.Drawing.Size(800, 450);
            this.tlpMain.TabIndex = 1;
            this.tlpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMain_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Controls.Add(this.btnAddNew);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(13, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(775, 40);
            this.panelHeader.TabIndex = 0;
            // 
            // btnAddNew
            // 
            this.btnAddNew.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            this.btnAddNew.IconColor = System.Drawing.Color.Black;
            this.btnAddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNew.IconSize = 22;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(7, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(107, 29);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvSalesOrders
            // 
            this.dgvSalesOrders.AllowUserToAddRows = false;
            this.dgvSalesOrders.AllowUserToDeleteRows = false;
            this.dgvSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtCustomerName,
            this.txtInvoiceNo,
            this.txtInvoiceDate,
            this.txtReferenceNo});
            this.dgvSalesOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrders.Location = new System.Drawing.Point(13, 49);
            this.dgvSalesOrders.MultiSelect = false;
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrders.Size = new System.Drawing.Size(775, 385);
            this.dgvSalesOrders.TabIndex = 1;
            this.dgvSalesOrders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalesOrders_CellMouseDoubleClick);
            // 
            // txtId
            // 
            this.txtId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtId.DataPropertyName = "Id";
            this.txtId.HeaderText = "Sales Order ID";
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCustomerName.DataPropertyName = "CustomerName";
            this.txtCustomerName.HeaderText = "Customer Name";
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtInvoiceNo.DataPropertyName = "InvoiceNo";
            this.txtInvoiceNo.HeaderText = "Invoice No";
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtInvoiceDate.DataPropertyName = "InvoiceDate";
            this.txtInvoiceDate.HeaderText = "Invoice Date";
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtReferenceNo.DataPropertyName = "ReferenceNo";
            this.txtReferenceNo.HeaderText = "Reference No";
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.ReadOnly = true;
            // 
            // SalesOrderListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpMain);
            this.Name = "SalesOrderListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesOrderListViewForm";
            this.Load += new System.EventHandler(this.SalesOrderListViewForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnAddNew;
        private System.Windows.Forms.DataGridView dgvSalesOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReferenceNo;
    }
}