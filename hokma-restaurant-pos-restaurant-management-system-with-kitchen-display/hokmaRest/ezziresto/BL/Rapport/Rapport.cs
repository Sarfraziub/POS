using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Rapport
{
    class Rapport
    {
        public string get_total_purchase_profit_today()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PURCHASE_PROFIT_TODAY", null);
            dal.Close();

            return id;
        }

        public string get_total_sale_profit_settled()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PURCHASE_PROFIT_SETTLED", null);
            dal.Close();

            return id;
        }

        public string get_total_sale_profit_Submitted()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PURCHASE_PROFIT_SUBMITTED", null);
            dal.Close();

            return id;
        }
    }
}
