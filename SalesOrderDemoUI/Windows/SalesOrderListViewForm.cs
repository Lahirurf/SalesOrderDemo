using SalesOrderDemo.Library.DataAccess;
using SalesOrderDemo.Library.Models;
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
    public partial class SalesOrderListViewForm : Form
    {
        private List<SalesHeaderModel> _salesHeaders;
        public SalesOrderListViewForm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SalesOrderForm child = new SalesOrderForm(0)
            {
                MdiParent = this.ParentForm
            };
            this.Close();
            child.Show();
        }

        public void WireUpSalesHeaderListView()
        {
            SalesData data = new SalesData();
            _salesHeaders = data.GetAllSalesHeaders();
            dgvSalesOrders.AutoGenerateColumns = false;
            dgvSalesOrders.DataSource = _salesHeaders;
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SalesOrderListViewForm_Load(object sender, EventArgs e)
        {
            WireUpSalesHeaderListView();
        }

        private void dgvSalesOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int salesHeaderId = 0;
                int.TryParse(dgvSalesOrders.Rows[e.RowIndex].Cells["txtId"].Value.ToString(),out salesHeaderId );
                SalesOrderForm child = new SalesOrderForm(salesHeaderId)
                {
                    MdiParent = this.ParentForm
                };
                this.Close();
                child.Show();
            }
            
        }
    }
}
