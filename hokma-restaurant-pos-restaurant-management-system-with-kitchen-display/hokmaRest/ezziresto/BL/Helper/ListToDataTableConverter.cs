using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezziresto.BL.Helper
{
    public class ListToDataTableConverter
    {
        public DataTable ToDataTable(List<BL.Models.Product> data)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Pro_ID");
            table.Columns.Add("Pro_Name");
            table.Columns.Add("Ref");
            table.Columns.Add("Qty");
            table.Columns.Add("User_Name");
            table.Columns.Add("Buy_Price");
            
            foreach (BL.Models.Product item in data)
            {
                DataRow row = table.NewRow();
                row["Pro_ID"] = item.ProID;
                row["Pro_Name"] = item.ProName;
                row["Ref"] = item.Reference;
                row["Qty"] = item.Qte;
                row["User_Name"] = item.UserName;
                row["Buy_Price"] = item.BuyPrice;

                table.Rows.Add(row);
            }

            return table;
        }
    }


}
