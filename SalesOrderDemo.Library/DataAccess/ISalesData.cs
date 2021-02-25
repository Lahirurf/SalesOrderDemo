using SalesOrderDemo.Library.Models;
using System.Collections.Generic;
using System.Data;

namespace SalesOrderDemo.Library.DataAccess
{
    public interface ISalesData
    {
        List<SalesDetailModel> GetAllSalesDetailsByHeaderId(int salesHeaderId);
        List<SalesHeaderModel> GetAllSalesHeaders();
        SalesHeaderModel GetSalesHeaderById(int id);
        DataSet GetSalesOrderDataSet(string headerTable, string detailTable, string relationName);
        void SaveSalesOrder(DataSet dataSet, string headerTable, string detailTable);
    }
}