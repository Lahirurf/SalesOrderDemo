
namespace SalesOrderDemoUI.Windows
{
    partial class SalesOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnPrint = new FontAwesome.Sharp.IconButton();
            this.btnNew = new FontAwesome.Sharp.IconButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSaveOrder = new FontAwesome.Sharp.IconButton();
            this.lblId = new System.Windows.Forms.Label();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeaderMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSubRightHeader = new System.Windows.Forms.TableLayoutPanel();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.richTxtNote = new System.Windows.Forms.RichTextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.tlpSubLeftHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.dgvItemDetails = new System.Windows.Forms.DataGridView();
            this.cmbItemcode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbDescription = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInclAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.txtTotalIncl = new System.Windows.Forms.TextBox();
            this.lblTotalIncl = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.txtTotalExcl = new System.Windows.Forms.TextBox();
            this.lblTotalExcl = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpHeaderMain.SuspendLayout();
            this.tlpSubRightHeader.SuspendLayout();
            this.tlpSubLeftHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetails)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Gainsboro;
            this.panelHeader.Controls.Add(this.btnPrint);
            this.panelHeader.Controls.Add(this.btnNew);
            this.panelHeader.Controls.Add(this.txtId);
            this.panelHeader.Controls.Add(this.btnSaveOrder);
            this.panelHeader.Controls.Add(this.lblId);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.Location = new System.Drawing.Point(11, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(778, 32);
            this.panelHeader.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnPrint.IconColor = System.Drawing.Color.Black;
            this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrint.IconSize = 18;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(197, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNew.IconColor = System.Drawing.Color.Black;
            this.btnNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNew.IconSize = 18;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(103, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(625, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(139, 20);
            this.txtId.TabIndex = 17;
            this.txtId.Text = "0";
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveOrder.IconColor = System.Drawing.Color.Black;
            this.btnSaveOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveOrder.IconSize = 18;
            this.btnSaveOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOrder.Location = new System.Drawing.Point(9, 5);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(88, 23);
            this.btnSaveOrder.TabIndex = 3;
            this.btnSaveOrder.Text = "Save Order";
            this.btnSaveOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(529, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(94, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "HeaderId (Hidden)";
            this.lblId.Visible = false;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpMain.Controls.Add(this.panelHeader, 1, 0);
            this.tlpMain.Controls.Add(this.tlpHeaderMain, 1, 1);
            this.tlpMain.Controls.Add(this.dgvItemDetails, 1, 2);
            this.tlpMain.Controls.Add(this.panelFooter, 1, 3);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlpMain.Size = new System.Drawing.Size(800, 487);
            this.tlpMain.TabIndex = 25;
            // 
            // tlpHeaderMain
            // 
            this.tlpHeaderMain.ColumnCount = 5;
            this.tlpHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.19878F));
            this.tlpHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.0552F));
            this.tlpHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.74602F));
            this.tlpHeaderMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpHeaderMain.Controls.Add(this.tlpSubRightHeader, 3, 1);
            this.tlpHeaderMain.Controls.Add(this.tlpSubLeftHeader, 1, 1);
            this.tlpHeaderMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeaderMain.Location = new System.Drawing.Point(11, 41);
            this.tlpHeaderMain.Name = "tlpHeaderMain";
            this.tlpHeaderMain.RowCount = 2;
            this.tlpHeaderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tlpHeaderMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeaderMain.Size = new System.Drawing.Size(778, 169);
            this.tlpHeaderMain.TabIndex = 25;
            // 
            // tlpSubRightHeader
            // 
            this.tlpSubRightHeader.ColumnCount = 2;
            this.tlpSubRightHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpSubRightHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSubRightHeader.Controls.Add(this.txtInvoiceNo, 1, 0);
            this.tlpSubRightHeader.Controls.Add(this.lblInvoiceNo, 0, 0);
            this.tlpSubRightHeader.Controls.Add(this.lblInvoiceDate, 0, 2);
            this.tlpSubRightHeader.Controls.Add(this.lblReference, 0, 4);
            this.tlpSubRightHeader.Controls.Add(this.lblNote, 0, 6);
            this.tlpSubRightHeader.Controls.Add(this.txtReferenceNo, 1, 4);
            this.tlpSubRightHeader.Controls.Add(this.richTxtNote, 1, 6);
            this.tlpSubRightHeader.Controls.Add(this.dtpInvoiceDate, 1, 2);
            this.tlpSubRightHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubRightHeader.Location = new System.Drawing.Point(440, 3);
            this.tlpSubRightHeader.Name = "tlpSubRightHeader";
            this.tlpSubRightHeader.RowCount = 7;
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpSubRightHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubRightHeader.Size = new System.Drawing.Size(243, 163);
            this.tlpSubRightHeader.TabIndex = 15;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoiceNo.Location = new System.Drawing.Point(89, 3);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(151, 20);
            this.txtInvoiceNo.TabIndex = 16;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceNo.Location = new System.Drawing.Point(3, 0);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(80, 20);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice No.";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInvoiceDate.Location = new System.Drawing.Point(3, 23);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(80, 20);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "Invoice Date";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReference.Location = new System.Drawing.Point(3, 46);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(80, 20);
            this.lblReference.TabIndex = 4;
            this.lblReference.Text = "Reference No";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNote.Location = new System.Drawing.Point(3, 69);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(80, 100);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Note";
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReferenceNo.Location = new System.Drawing.Point(89, 49);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(151, 20);
            this.txtReferenceNo.TabIndex = 9;
            // 
            // richTxtNote
            // 
            this.richTxtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtNote.Location = new System.Drawing.Point(89, 72);
            this.richTxtNote.Name = "richTxtNote";
            this.richTxtNote.Size = new System.Drawing.Size(151, 94);
            this.richTxtNote.TabIndex = 15;
            this.richTxtNote.Text = "";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(89, 26);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(151, 20);
            this.dtpInvoiceDate.TabIndex = 17;
            // 
            // tlpSubLeftHeader
            // 
            this.tlpSubLeftHeader.ColumnCount = 2;
            this.tlpSubLeftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpSubLeftHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSubLeftHeader.Controls.Add(this.lblCustomerName, 0, 0);
            this.tlpSubLeftHeader.Controls.Add(this.lblPostCode, 0, 12);
            this.tlpSubLeftHeader.Controls.Add(this.lblState, 0, 10);
            this.tlpSubLeftHeader.Controls.Add(this.lblAddress1, 0, 2);
            this.tlpSubLeftHeader.Controls.Add(this.lblSuburb, 0, 8);
            this.tlpSubLeftHeader.Controls.Add(this.lblAddress2, 0, 4);
            this.tlpSubLeftHeader.Controls.Add(this.lblAddress3, 0, 6);
            this.tlpSubLeftHeader.Controls.Add(this.txtAddress1, 1, 2);
            this.tlpSubLeftHeader.Controls.Add(this.txtAddress2, 1, 4);
            this.tlpSubLeftHeader.Controls.Add(this.txtAddress3, 1, 6);
            this.tlpSubLeftHeader.Controls.Add(this.txtSuburb, 1, 8);
            this.tlpSubLeftHeader.Controls.Add(this.txtState, 1, 10);
            this.tlpSubLeftHeader.Controls.Add(this.txtPostCode, 1, 12);
            this.tlpSubLeftHeader.Controls.Add(this.cmbCustomerName, 1, 0);
            this.tlpSubLeftHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSubLeftHeader.Location = new System.Drawing.Point(11, 3);
            this.tlpSubLeftHeader.Name = "tlpSubLeftHeader";
            this.tlpSubLeftHeader.RowCount = 13;
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSubLeftHeader.Size = new System.Drawing.Size(280, 163);
            this.tlpSubLeftHeader.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPostCode.Location = new System.Drawing.Point(3, 138);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(103, 25);
            this.lblPostCode.TabIndex = 8;
            this.lblPostCode.Text = "Post Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblState.Location = new System.Drawing.Point(3, 115);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(103, 20);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress1.Location = new System.Drawing.Point(3, 23);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(103, 20);
            this.lblAddress1.TabIndex = 2;
            this.lblAddress1.Text = "Address 1";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSuburb.Location = new System.Drawing.Point(3, 92);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(103, 20);
            this.lblSuburb.TabIndex = 6;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress2.Location = new System.Drawing.Point(3, 46);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(103, 20);
            this.lblAddress2.TabIndex = 4;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblAddress3
            // 
            this.lblAddress3.AutoSize = true;
            this.lblAddress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress3.Location = new System.Drawing.Point(3, 69);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(103, 20);
            this.lblAddress3.TabIndex = 5;
            this.lblAddress3.Text = "Address 3";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress1.Location = new System.Drawing.Point(112, 26);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(165, 20);
            this.txtAddress1.TabIndex = 3;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress2.Location = new System.Drawing.Point(112, 49);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(165, 20);
            this.txtAddress2.TabIndex = 9;
            // 
            // txtAddress3
            // 
            this.txtAddress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress3.Location = new System.Drawing.Point(112, 72);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(165, 20);
            this.txtAddress3.TabIndex = 10;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSuburb.Location = new System.Drawing.Point(112, 95);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(165, 20);
            this.txtSuburb.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtState.Location = new System.Drawing.Point(112, 118);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(165, 20);
            this.txtState.TabIndex = 12;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPostCode.Location = new System.Drawing.Point(112, 141);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(165, 20);
            this.txtPostCode.TabIndex = 13;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(112, 3);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(165, 21);
            this.cmbCustomerName.TabIndex = 14;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // dgvItemDetails
            // 
            this.dgvItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbItemcode,
            this.cmbDescription,
            this.txtNote,
            this.txtQuantity,
            this.txtPrice,
            this.txtTax,
            this.txtExclAmount,
            this.txtTaxAmount,
            this.txtInclAmount});
            this.dgvItemDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemDetails.Location = new System.Drawing.Point(11, 216);
            this.dgvItemDetails.Name = "dgvItemDetails";
            this.dgvItemDetails.Size = new System.Drawing.Size(778, 181);
            this.dgvItemDetails.TabIndex = 26;
            this.dgvItemDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemDetails_CellEndEdit);
            this.dgvItemDetails.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItemDetails_DataError);
            // 
            // cmbItemcode
            // 
            this.cmbItemcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbItemcode.DataPropertyName = "ItemId";
            this.cmbItemcode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cmbItemcode.HeaderText = "Item Code";
            this.cmbItemcode.Name = "cmbItemcode";
            // 
            // cmbDescription
            // 
            this.cmbDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmbDescription.DataPropertyName = "ItemId";
            this.cmbDescription.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cmbDescription.HeaderText = "Description";
            this.cmbDescription.Name = "cmbDescription";
            // 
            // txtNote
            // 
            this.txtNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNote.DataPropertyName = "note";
            this.txtNote.HeaderText = "Note";
            this.txtNote.Name = "txtNote";
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtQuantity.DataPropertyName = "quantity";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.txtQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPrice.DataPropertyName = "price";
            dataGridViewCellStyle2.Format = "C4";
            dataGridViewCellStyle2.NullValue = "0";
            this.txtPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtPrice.HeaderText = "Price";
            this.txtPrice.Name = "txtPrice";
            // 
            // txtTax
            // 
            this.txtTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTax.DataPropertyName = "tax";
            dataGridViewCellStyle3.Format = "C4";
            dataGridViewCellStyle3.NullValue = "0";
            this.txtTax.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtTax.HeaderText = "Tax";
            this.txtTax.Name = "txtTax";
            // 
            // txtExclAmount
            // 
            this.txtExclAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtExclAmount.DataPropertyName = "exclamount";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Format = "C4";
            dataGridViewCellStyle4.NullValue = "0";
            this.txtExclAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtExclAmount.HeaderText = "Excl Amount";
            this.txtExclAmount.Name = "txtExclAmount";
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtTaxAmount.DataPropertyName = "taxamount";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Format = "C4";
            dataGridViewCellStyle5.NullValue = "0";
            this.txtTaxAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtTaxAmount.HeaderText = "Tax Amount";
            this.txtTaxAmount.Name = "txtTaxAmount";
            // 
            // txtInclAmount
            // 
            this.txtInclAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtInclAmount.DataPropertyName = "inclamount";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Format = "C4";
            dataGridViewCellStyle6.NullValue = "0";
            this.txtInclAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtInclAmount.HeaderText = "Incl Amount";
            this.txtInclAmount.Name = "txtInclAmount";
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.txtTotalIncl);
            this.panelFooter.Controls.Add(this.lblTotalIncl);
            this.panelFooter.Controls.Add(this.txtTotalTax);
            this.panelFooter.Controls.Add(this.lblTotalTax);
            this.panelFooter.Controls.Add(this.txtTotalExcl);
            this.panelFooter.Controls.Add(this.lblTotalExcl);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(11, 403);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(778, 81);
            this.panelFooter.TabIndex = 27;
            // 
            // txtTotalIncl
            // 
            this.txtTotalIncl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalIncl.Location = new System.Drawing.Point(609, 55);
            this.txtTotalIncl.Name = "txtTotalIncl";
            this.txtTotalIncl.ReadOnly = true;
            this.txtTotalIncl.Size = new System.Drawing.Size(155, 20);
            this.txtTotalIncl.TabIndex = 5;
            // 
            // lblTotalIncl
            // 
            this.lblTotalIncl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalIncl.AutoSize = true;
            this.lblTotalIncl.Location = new System.Drawing.Point(549, 55);
            this.lblTotalIncl.Name = "lblTotalIncl";
            this.lblTotalIncl.Size = new System.Drawing.Size(51, 13);
            this.lblTotalIncl.TabIndex = 4;
            this.lblTotalIncl.Text = "Total Incl";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTax.Location = new System.Drawing.Point(609, 29);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(155, 20);
            this.txtTotalTax.TabIndex = 3;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Location = new System.Drawing.Point(549, 29);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(52, 13);
            this.lblTotalTax.TabIndex = 2;
            this.lblTotalTax.Text = "Total Tax";
            // 
            // txtTotalExcl
            // 
            this.txtTotalExcl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalExcl.Location = new System.Drawing.Point(609, 3);
            this.txtTotalExcl.Name = "txtTotalExcl";
            this.txtTotalExcl.ReadOnly = true;
            this.txtTotalExcl.Size = new System.Drawing.Size(155, 20);
            this.txtTotalExcl.TabIndex = 1;
            // 
            // lblTotalExcl
            // 
            this.lblTotalExcl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalExcl.AutoSize = true;
            this.lblTotalExcl.Location = new System.Drawing.Point(549, 3);
            this.lblTotalExcl.Name = "lblTotalExcl";
            this.lblTotalExcl.Size = new System.Drawing.Size(54, 13);
            this.lblTotalExcl.TabIndex = 0;
            this.lblTotalExcl.Text = "Total Excl";
            // 
            // SalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.tlpMain);
            this.Name = "SalesOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesOrderForm";
            this.Load += new System.EventHandler(this.SalesOrderForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpHeaderMain.ResumeLayout(false);
            this.tlpSubRightHeader.ResumeLayout(false);
            this.tlpSubRightHeader.PerformLayout();
            this.tlpSubLeftHeader.ResumeLayout(false);
            this.tlpSubLeftHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemDetails)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnSaveOrder;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpHeaderMain;
        private System.Windows.Forms.TableLayoutPanel tlpSubRightHeader;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtReferenceNo;
        private System.Windows.Forms.RichTextBox richTxtNote;
        private System.Windows.Forms.TableLayoutPanel tlpSubLeftHeader;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.DataGridView dgvItemDetails;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.TextBox txtTotalIncl;
        private System.Windows.Forms.Label lblTotalIncl;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.TextBox txtTotalExcl;
        private System.Windows.Forms.Label lblTotalExcl;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbItemcode;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtExclAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInclAmount;
        private FontAwesome.Sharp.IconButton btnNew;
        private FontAwesome.Sharp.IconButton btnPrint;
    }
}