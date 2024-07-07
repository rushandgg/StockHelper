using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHelper
{
    public class MakeSource
    {
        List<string> sourceList;

        public List<string> StockList(string market, string type)
        {
            sourceList = new List<string>();
            LoadData loadData = new LoadData();
            DataTable masterDataTable = loadData.Master(market);
            sourceList = masterDataTable.AsEnumerable()
                             .Select(row => row.Field<string>(type))
                             .ToList();

            return sourceList;
        }
    }
}
