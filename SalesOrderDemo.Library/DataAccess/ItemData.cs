using SalesOrderDemo.Library.Internal.DataAccess;
using SalesOrderDemo.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDemo.Library.DataAccess
{
    public class ItemData : IItemData
    {
        public List<ItemModel> GetAllItems()
        {
            ISqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<ItemModel, dynamic>("dbo.spStkItem_GetAll", new { });
            return output;
        }
    }
}
