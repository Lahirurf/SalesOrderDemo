using SalesOrderDemo.Library.DataAccess;
using SalesOrderDemo.Library.Models;
using SalesOrderDemoUI.UIModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesOrderDemoUI.Windows
{
    public partial class SalesOrderForm : Form
    {
        private List<CustomerModel> _customers;
        private List<ItemModel> _items;
        private BindingSource _headerBindingSource = new BindingSource();
        private BindingSource _detailBindingSource = new BindingSource();
        private int _salesHeaderId = 0;

        public SalesOrderForm(int salesHeaderId)
        {
            InitializeComponent();
            _salesHeaderId = salesHeaderId;
            dtpInvoiceDate.Format = DateTimePickerFormat.Custom;
            dtpInvoiceDate.CustomFormat = "dd/MM/yyyy";
            dtpInvoiceDate.Text = DateTime.Now.ToString();
            

        }

        private void _headerBindingSource_PositionChanged(object sender, EventArgs e)
        {
            int headerId = 0;
            if (txtId.Text != null)
            {
                int.TryParse(txtId.Text, out headerId);
                if (headerId == 0)
                {
                    btnPrint.Visible = false;
                }
                else
                {
                    btnPrint.Visible = true;
                    _headerBindingSource.ResetBindings(true);
                }
            }
            else
            {
                btnPrint.Visible = false;
            }
            
        }

        public void FillBindingSources()
        {
            ISalesData salesData = new SalesData();
            DataSet data = salesData.GetSalesOrderDataSet("SalesHeader", "SalesDetail", "SalesHeaderDetail");
            _headerBindingSource.DataSource = data;
            _headerBindingSource.DataMember = "SalesHeader";
            _detailBindingSource.DataSource = _headerBindingSource;
            _detailBindingSource.DataMember = "SalesHeaderDetail";
        }

        public void BindData()
        {
            
            FillBindingSources();
            txtId.DataBindings.Add("Text", _headerBindingSource, "Id");
            cmbCustomerName.DataBindings.Add("SelectedValue", _headerBindingSource, "CustomerId");
            txtAddress1.DataBindings.Add("Text", _headerBindingSource, "Address1");
            txtAddress2.DataBindings.Add("Text", _headerBindingSource, "Address2");
            txtAddress3.DataBindings.Add("Text", _headerBindingSource, "Address3");
            txtSuburb.DataBindings.Add("Text", _headerBindingSource, "Suburb");
            txtState.DataBindings.Add("Text", _headerBindingSource, "State");
            txtPostCode.DataBindings.Add("Text", _headerBindingSource, "PostCode");
            txtInvoiceNo.DataBindings.Add("Text", _headerBindingSource, "InvoiceNo");
            dtpInvoiceDate.DataBindings.Add("Text", _headerBindingSource, "InvoiceDate");
            txtReferenceNo.DataBindings.Add("Text", _headerBindingSource, "ReferenceNo");
            richTxtNote.DataBindings.Add("Text", _headerBindingSource, "Note");
            txtTotalExcl.DataBindings.Add("Text", _headerBindingSource, "TotalExcl");
            txtTotalTax.DataBindings.Add("Text", _headerBindingSource, "TotalTax");
            txtTotalIncl.DataBindings.Add("Text", _headerBindingSource, "TotalIncl");
            dgvItemDetails.AutoGenerateColumns = false;
            dgvItemDetails.DataSource = _detailBindingSource;
            _headerBindingSource.AddNew();

        }

        public void WireUpCustomerList()
        {
            try
            {
                IClientData data = new ClientData();
                _customers = data.GetAllCustomers();
                cmbCustomerName.DataSource = _customers;
                cmbCustomerName.DisplayMember = "Name";
                cmbCustomerName.ValueMember = "Id";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        public void WireUpItemList()
        {
            IItemData data = new ItemData();
            _items = data.GetAllItems();
            cmbItemcode.DataSource = _items;
            cmbItemcode.DisplayMember = "ItemCode";
            cmbItemcode.ValueMember = "Id";
            cmbDescription.DataSource = _items;
            cmbDescription.DisplayMember = "Description";
            cmbDescription.ValueMember = "Id";
        }



        private bool isFormValid()
        {
            if (cmbCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("Customer Name is Requied", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCustomerName.Focus();
                return false;
            }
            if (txtAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Address 1 is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress1.Focus();
                return false;
            }
            if (txtAddress2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Address 2 is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress2.Focus();
                return false;
            }
            if (txtAddress3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Address 3 is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress3.Focus();
                return false;
            }
            if (txtSuburb.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Suburb is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuburb.Focus();
                return false;
            }
            if (txtState.Text.Trim() == string.Empty)
            {
                MessageBox.Show("State is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtState.Focus();
                return false;
            }
            if (txtPostCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Post Code is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPostCode.Focus();
                return false;
            }
            if (txtInvoiceNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Invoice No is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInvoiceNo.Focus();
                return false;
            }
            if (txtReferenceNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Reference No is Required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReferenceNo.Focus();
                return false;
            }
            return true;
        }




        public bool isDetailGridValid()
        {
            if (dgvItemDetails.Rows.Count > 1)
            {
                for (int i = 0; i < (dgvItemDetails.Rows.Count - 1); i++)
                {
                    for (int j = 0; j < dgvItemDetails.Columns.Count; j++)
                    {
                        if (object.ReferenceEquals(dgvItemDetails.Rows[i].Cells[j].Value, null))
                        {
                            MessageBox.Show($"Row:{i+1} {dgvItemDetails.Columns[j].HeaderText} value is null");
                            return false;
                        }
                        if (dgvItemDetails.Rows[i].Cells[j].Value.ToString() == string.Empty)
                        {
                            MessageBox.Show($"Row:{i + 1} {dgvItemDetails.Columns[j].HeaderText} value is empty");
                            return false;

                        }
                        if(dgvItemDetails.Rows[i].Cells["txtQuantity"].ColumnIndex == j|| dgvItemDetails.Rows[i].Cells["txtPrice"].ColumnIndex == j|| dgvItemDetails.Rows[i].Cells["txtTax"].ColumnIndex == j)
                        {
                            if (Convert.ToInt32(dgvItemDetails.Rows[i].Cells[j].Value) <= 0)
                            {
                                MessageBox.Show($"Row:{i + 1} {dgvItemDetails.Columns[j].HeaderText} value should be greater than zero");
                                return false;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Add Item Details");
                return false;
            }

            return true;
        }


        private void SalesOrderForm_Load(object sender, EventArgs e)
        {
            BindData();
            WireUpCustomerList();
            WireUpItemList();
            if(_salesHeaderId > 0)
            {
                FillBindingSources();
                int position = _headerBindingSource.Find("Id", _salesHeaderId);
                _headerBindingSource.Position = position;
                _headerBindingSource.PositionChanged += _headerBindingSource_PositionChanged;
                cmbCustomerName.Enabled = false;
            }
            else
            {
                btnPrint.Visible = false;
            }

        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
                if (isFormValid() && isDetailGridValid())
                {
                    try
                    {
                        ISalesData data = new SalesData();
                        _headerBindingSource.EndEdit();
                        _detailBindingSource.EndEdit();
                        data.SaveSalesOrder((DataSet)_headerBindingSource.DataSource, "SalesHeader", "SalesDetail");
                        FillBindingSources();
                        _headerBindingSource.AddNew();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                } 
            cmbCustomerName.Enabled = true;
        }



        

        public void caluculateTotalValues()
        {
            decimal exclTotal = 0;
            decimal taxTotal = 0;
            decimal inclTotal = 0;
            for (int i = 0; i < dgvItemDetails.Rows.Count-1; ++i)
            {
                if (!object.Equals(dgvItemDetails.Rows[i].Cells["txtExclAmount"].Value, DBNull.Value))
                {
                    exclTotal += decimal.Parse(dgvItemDetails.Rows[i].Cells["txtExclAmount"].Value.ToString());                    
                }
                if (!object.Equals(dgvItemDetails.Rows[i].Cells["txtTaxAmount"].Value, DBNull.Value))
                {
                    taxTotal += decimal.Parse(dgvItemDetails.Rows[i].Cells["txtTaxAmount"].Value.ToString());
                }
                if (!object.Equals(dgvItemDetails.Rows[i].Cells["txtInclAmount"].Value, DBNull.Value))
                {
                    inclTotal += decimal.Parse(dgvItemDetails.Rows[i].Cells["txtInclAmount"].Value.ToString());
                }
                
            }
            txtTotalExcl.Text = exclTotal.ToString();
            txtTotalTax.Text = taxTotal.ToString();
            txtTotalIncl.Text = inclTotal.ToString();
        }

        private void dgvItemDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!object.Equals(dgvItemDetails.Rows[e.RowIndex].Cells["txtQuantity"].Value, DBNull.Value) && !object.Equals(dgvItemDetails.Rows[e.RowIndex].Cells["txtPrice"].Value, DBNull.Value))
            {
                dgvItemDetails.Rows[e.RowIndex].Cells["txtExclAmount"].Value =
                    Convert.ToInt32(dgvItemDetails.Rows[e.RowIndex].Cells["txtQuantity"].Value) *
                    Convert.ToDecimal(dgvItemDetails.Rows[e.RowIndex].Cells["txtPrice"].Value);
            }

            if (!object.Equals(dgvItemDetails.Rows[e.RowIndex].Cells["txtExclAmount"].Value, DBNull.Value) && !object.Equals(dgvItemDetails.Rows[e.RowIndex].Cells["txtTax"].Value, DBNull.Value))
            {
                dgvItemDetails.Rows[e.RowIndex].Cells["txtTaxAmount"].Value =
                    Convert.ToInt32(dgvItemDetails.Rows[e.RowIndex].Cells["txtExclAmount"].Value) *
                    (Convert.ToDecimal(dgvItemDetails.Rows[e.RowIndex].Cells["txtTax"].Value) / 100);
            }

            if (!object.Equals(dgvItemDetails.Rows[e.RowIndex].Cells["txtExclAmount"].Value, DBNull.Value) && !object.Equals(dgvItemDetails.Rows[e.RowIndex].Cells["txtTaxAmount"].Value, DBNull.Value))
            {
                dgvItemDetails.Rows[e.RowIndex].Cells["txtInclAmount"].Value =
                    Convert.ToInt32(dgvItemDetails.Rows[e.RowIndex].Cells["txtExclAmount"].Value) +
                    Convert.ToDecimal(dgvItemDetails.Rows[e.RowIndex].Cells["txtTaxAmount"].Value);
            }

            caluculateTotalValues();
        }

        private void dgvItemDetails_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Error happend Row: {e.RowIndex + 1} Column: {dgvItemDetails.Columns[e.ColumnIndex].HeaderText} - {e.Context.ToString()}");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _salesHeaderId = 0;
            FillBindingSources();
            _headerBindingSource.AddNew();
            cmbCustomerName.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ISalesData data = new SalesData();
            SalesHeaderModel salesHeaderModel = data.GetSalesHeaderById(_salesHeaderId);
            List<SalesDetailModel> tempSalesDetailModels = data.GetAllSalesDetailsByHeaderId(_salesHeaderId);
            List<UIModels.UISalesDetailModel> salesDetailModels = new List<UIModels.UISalesDetailModel>();
            foreach(SalesDetailModel item in tempSalesDetailModels)
            {
                UIModels.UISalesDetailModel newitem = new UIModels.UISalesDetailModel();
                newitem.ItemCode = item.ItemCode;
                newitem.Note = item.Note;
                newitem.Quantity = item.Quantity;
                newitem.Price = item.Price;
                newitem.Tax = item.Tax;
                newitem.ExclAmount = item.ExclAmount;
                newitem.TaxAmount = item.TaxAmount;
                newitem.InclAmount = item.InclAmount;
                salesDetailModels.Add(newitem);
            }
            PrintForm child = new PrintForm(salesHeaderModel, salesDetailModels)
            {
                MdiParent = this.ParentForm
            };
            child.Show();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            int headerId = 0;
            if (txtId.Text != null)
            {
                int.TryParse(txtId.Text, out headerId);
                if (headerId == 0)
                {
                    btnPrint.Visible = false;
                }
                else
                {
                    btnPrint.Visible = true;
                }
            }
            else
            {
                btnPrint.Visible = false;
            }
        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmbCustomerName.SelectedValue != null)
                {
                   var isConverted = int.TryParse(cmbCustomerName.SelectedValue.ToString(), out int id);
                    if (isConverted)
                    {
                        var selectedCustomer = _customers.Where(x => x.Id == id).First();
                        txtAddress1.Text = selectedCustomer.Address1;
                        txtAddress2.Text = selectedCustomer.Address2;
                        txtAddress3.Text = selectedCustomer.Address3;
                        txtSuburb.Text = selectedCustomer.Suburb;
                        txtState.Text = selectedCustomer.State;
                        txtPostCode.Text = selectedCustomer.PostCode;

                    }
                }
        }
    }
}
