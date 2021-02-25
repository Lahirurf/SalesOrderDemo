using SalesOrderDemo.Library.Models;
using System.Collections.Generic;

namespace SalesOrderDemo.Library.DataAccess
{
    public interface IItemData
    {
        List<ItemModel> GetAllItems();
    }
}