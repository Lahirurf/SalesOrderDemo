using SalesOrderDemo.Library.Internal.DataAccess;
using SalesOrderDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDemo.Library.DataAccess
{
    public class SalesData : ISalesData
    {
        public DataSet GetSalesOrderDataSet(string headerTable, string detailTable, string relationName)
        {
            ISqlDataAccess sql = new SqlDataAccess();
            return sql.CreateMasterDetailDataSet(headerTable, detailTable, "Id", "SalesHeaderId", relationName, "spSalesHeader_Select", "spSalesDetail_Select");
        }

        public List<SalesHeaderModel> GetAllSalesHeaders()
        {
            ISqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<SalesHeaderModel, dynamic>("spSalesHeader_GetAll", new { });
            return output;
        }

        public SalesHeaderModel GetSalesHeaderById(int id)
        {
            ISqlDataAccess sql = new SqlDataAccess();
            var p = new { @Id = id };
            var output = sql.LoadData<SalesHeaderModel, dynamic>("spSalesHeader_SelectById", p).FirstOrDefault();
            return output;
        }

        public List<SalesDetailModel> GetAllSalesDetailsByHeaderId(int salesHeaderId)
        {
            ISqlDataAccess sql = new SqlDataAccess();
            var p = new { @SalesHeaderId = salesHeaderId };
            var output = sql.LoadData<SalesDetailModel, dynamic>("spSalesDetail_SelectById", p);
            return output;
        }


        public void SaveSalesOrder(DataSet dataSet, string headerTable, string detailTable)
        {
            ISqlDataAccess sql = new SqlDataAccess();
            using (SqlConnection conn = new SqlConnection(sql.GetConnectionString()))
            {
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction();
                try
                {
                    SqlDataAdapter headerDataAdapter = new SqlDataAdapter();
                    headerDataAdapter.SelectCommand = new SqlCommand("spSalesHeader_Select");
                    headerDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    headerDataAdapter.SelectCommand.Connection = conn;
                    headerDataAdapter.SelectCommand.Transaction = sqlTran;

                    SqlCommandBuilder headerCommandBuilder = new SqlCommandBuilder(headerDataAdapter);

                    headerDataAdapter.InsertCommand = new SqlCommand("spSalesHeader_Insert");
                    headerDataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    headerDataAdapter.InsertCommand.Connection = conn;
                    headerDataAdapter.InsertCommand.Transaction = sqlTran;

                    headerDataAdapter.InsertCommand.Parameters.Add("@CustomerId", SqlDbType.Int, 0, "CustomerId");
                    headerDataAdapter.InsertCommand.Parameters.Add("@Address1", SqlDbType.NVarChar, 100, "Address1");
                    headerDataAdapter.InsertCommand.Parameters.Add("@Address2", SqlDbType.NVarChar, 100, "Address2");
                    headerDataAdapter.InsertCommand.Parameters.Add("@Address3", SqlDbType.NVarChar, 100, "Address3");
                    headerDataAdapter.InsertCommand.Parameters.Add("@Suburb", SqlDbType.NVarChar, 50, "Suburb");
                    headerDataAdapter.InsertCommand.Parameters.Add("@State", SqlDbType.NVarChar, 50, "State");
                    headerDataAdapter.InsertCommand.Parameters.Add("@PostCode", SqlDbType.NVarChar, 50, "PostCode");
                    headerDataAdapter.InsertCommand.Parameters.Add("@InvoiceNo", SqlDbType.NVarChar, 50, "InvoiceNo");
                    headerDataAdapter.InsertCommand.Parameters.Add("@InvoiceDate", SqlDbType.DateTime2, 50, "InvoiceDate");
                    headerDataAdapter.InsertCommand.Parameters.Add("@ReferenceNo", SqlDbType.NVarChar, 50, "ReferenceNo");
                    headerDataAdapter.InsertCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 200, "Note");
                    headerDataAdapter.InsertCommand.Parameters.Add("@TotalExcl", SqlDbType.Money, 0, "TotalExcl");
                    headerDataAdapter.InsertCommand.Parameters.Add("@TotalTax", SqlDbType.Money, 0, "TotalTax");
                    headerDataAdapter.InsertCommand.Parameters.Add("@TotalIncl", SqlDbType.Money, 0, "TotalIncl");
                    SqlParameter parameter = headerDataAdapter.InsertCommand.Parameters.Add("@Identity", SqlDbType.Int, 0, "Id");
                    parameter.Direction = ParameterDirection.Output;


                    headerDataAdapter.Update(dataSet, headerTable);

                    int hdrid = 0;
                    hdrid = Convert.ToInt32(parameter.Value);

                    SqlDataAdapter detailDataAdapter = new SqlDataAdapter();
                    detailDataAdapter.SelectCommand = new SqlCommand("spSalesDetail_Select");
                    detailDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    detailDataAdapter.SelectCommand.Connection = conn;
                    detailDataAdapter.SelectCommand.Transaction = sqlTran;

                    SqlCommandBuilder detailCommandBuilder = new SqlCommandBuilder(detailDataAdapter);
                    detailDataAdapter.InsertCommand = new SqlCommand("spSalesDetail_Insert");
                    detailDataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    detailDataAdapter.InsertCommand.Connection = conn;
                    detailDataAdapter.InsertCommand.Transaction = sqlTran;

                    detailDataAdapter.InsertCommand.Parameters.Add("@ItemId", SqlDbType.Int, 0, "ItemId");
                    detailDataAdapter.InsertCommand.Parameters.Add("@Note", SqlDbType.NVarChar, 100, "Note");
                    detailDataAdapter.InsertCommand.Parameters.Add("@Quantity", SqlDbType.Int, 0, "Quantity");
                    detailDataAdapter.InsertCommand.Parameters.Add("@Price", SqlDbType.Money, 0, "Price");
                    detailDataAdapter.InsertCommand.Parameters.Add("@Tax", SqlDbType.Money, 0, "Tax");
                    detailDataAdapter.InsertCommand.Parameters.Add("@ExclAmount", SqlDbType.Money, 0, "ExclAmount");
                    detailDataAdapter.InsertCommand.Parameters.Add("@TaxAmount", SqlDbType.Money, 0, "TaxAmount");
                    detailDataAdapter.InsertCommand.Parameters.Add("@InclAmount", SqlDbType.Money, 0, "InclAmount");
                    if (hdrid == 0)
                    {
                        detailDataAdapter.InsertCommand.Parameters.Add("@SalesHeaderId", SqlDbType.Int, 0, "SalesHeaderId");
                    }
                    else
                    {
                        detailDataAdapter.InsertCommand.Parameters.AddWithValue("@SalesHeaderId", hdrid);
                    }

                    detailDataAdapter.Update(dataSet, detailTable);
                    sqlTran.Commit();
                }
                catch (Exception ex)
                {
                    try
                    {
                        sqlTran.Rollback();
                        throw ex;
                    }
                    catch (Exception exRollback)
                    {
                        throw exRollback;
                    }
                }
            }
        }
    }
}
