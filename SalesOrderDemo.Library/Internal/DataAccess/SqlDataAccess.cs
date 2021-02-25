using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDemo.Library.Internal.DataAccess
{
    internal class SqlDataAccess : ISqlDataAccess
    {
        public string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SODATA"].ConnectionString;
        }
        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            string connectionString = GetConnectionString();
            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    List<T> rows = cnn.Query<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure).ToList();
                    return rows;
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }
        public void SaveData<T>(string storedProcedure, T parameters)
        {
            string connectionString = GetConnectionString();
            using (IDbConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        public DataSet CreateMasterDetailDataSet(string headerTable, string detailTable, string primaryKey, string foreignKey, string relationName, string headerStoredProcedure, string detailStoredProcedure)
        {
            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    SqlDataAdapter phda = new SqlDataAdapter(headerStoredProcedure, conn);
                    phda.Fill(data, headerTable);

                    SqlDataAdapter pda = new SqlDataAdapter(detailStoredProcedure, conn);
                    pda.Fill(data, detailTable);

                    DataRelation relation = new DataRelation(relationName,
                    data.Tables[headerTable].Columns[primaryKey],
                    data.Tables[detailTable].Columns[foreignKey]);
                    data.Relations.Add(relation);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return data;
        }
    }
}
