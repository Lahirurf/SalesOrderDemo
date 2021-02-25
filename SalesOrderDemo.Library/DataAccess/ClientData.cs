using SalesOrderDemo.Library.Internal.DataAccess;
using SalesOrderDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDemo.Library.DataAccess
{
    public class ClientData : IClientData
    {
        public List<CustomerModel> GetAllCustomers()
        {
            ISqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<CustomerModel, dynamic>("dbo.spClient_GetAll", new { });
            return output;
        }
    }
}
