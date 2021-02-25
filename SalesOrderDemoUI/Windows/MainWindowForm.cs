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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
            SalesOrderListViewForm child = new SalesOrderListViewForm
            {
                MdiParent = this
            };
            child.Show();
        }

        private void salesOrderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                if (ActiveMdiChild.GetType().Name != "SalesOrderForm")
                {
                    ActiveMdiChild.Close();
                    SalesOrderForm child = new SalesOrderForm(0)
                    {
                        MdiParent = this
                    };
                    child.Show();
                }
                else
                {
                    MessageBox.Show("Sales Order Entry is already open");
                }

            }
            else
            {
                SalesOrderForm child = new SalesOrderForm(0)
                {
                    MdiParent = this
                };
                child.Show();
            }
            
        }

        private void salesOrdersListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                if (ActiveMdiChild.GetType().Name != "SalesOrderListViewForm")
                {
                    ActiveMdiChild.Close();
                    SalesOrderListViewForm child = new SalesOrderListViewForm
                    {
                        MdiParent = this
                    };
                    child.Show();
                }
                else
                {
                    MessageBox.Show("Sales Order List View is already open");
                }

            }
            else
            {
                SalesOrderListViewForm child = new SalesOrderListViewForm
                {
                    MdiParent = this
                };
                child.Show();
            }
        }
    }
}
