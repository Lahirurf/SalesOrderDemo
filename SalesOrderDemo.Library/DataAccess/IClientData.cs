using SalesOrderDemo.Library.Models;
using System.Collections.Generic;

namespace SalesOrderDemo.Library.DataAccess
{
    public interface IClientData
    {
        List<CustomerModel> GetAllCustomers();
    }
}