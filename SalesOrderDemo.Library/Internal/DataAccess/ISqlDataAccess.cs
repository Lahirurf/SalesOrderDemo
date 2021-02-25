using System.Collections.Generic;
using System.Data;

namespace SalesOrderDemo.Library.Internal.DataAccess
{
    internal interface ISqlDataAccess
    {
        DataSet CreateMasterDetailDataSet(string headerTable, string detailTable, string primaryKey, string foreignKey, string relationName, string headerStoredProcedure, string detailStoredProcedure);
        string GetConnectionString();
        List<T> LoadData<T, U>(string storedProcedure, U parameters);
        void SaveData<T>(string storedProcedure, T parameters);
    }
}