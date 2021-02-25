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
    public partial class PrintForm : Form
    {
        private SalesHeaderModel _salesHeaderModel;
        private List<UISalesDetailModel> _salesDetailModels;
        public PrintForm(SalesHeaderModel salesHeaderModel, List<UISalesDetailModel> salesDetailModels)
        {
            InitializeComponent();
            _salesHeaderModel = salesHeaderModel;
            _salesDetailModels = salesDetailModels;
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            SalesInvoice1.SetDataSource(_salesDetailModels);
            SalesInvoice1.SetParameterValue("pCustomerName", _salesHeaderModel.CustomerName);
            SalesInvoice1.SetParameterValue("pAddress1", _salesHeaderModel.Address1);
            SalesInvoice1.SetParameterValue("pAddress2", _salesHeaderModel.Address2);
            SalesInvoice1.SetParameterValue("pAddress3", _salesHeaderModel.Address3);
            SalesInvoice1.SetParameterValue("pSuburb", _salesHeaderModel.Suburb);
            SalesInvoice1.SetParameterValue("pState", _salesHeaderModel.State);
            SalesInvoice1.SetParameterValue("pPostCode", _salesHeaderModel.PostCode);
            SalesInvoice1.SetParameterValue("pInvoiceNo", _salesHeaderModel.InvoiceNo);
            SalesInvoice1.SetParameterValue("pInvoiceDate", _salesHeaderModel.InvoiceDate);
            SalesInvoice1.SetParameterValue("pReferenceNo", _salesHeaderModel.ReferenceNo);
            SalesInvoice1.SetParameterValue("pNote", _salesHeaderModel.Note);
        }
    }
}
