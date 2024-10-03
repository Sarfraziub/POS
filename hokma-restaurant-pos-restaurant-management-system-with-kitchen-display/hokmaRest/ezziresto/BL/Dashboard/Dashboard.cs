using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Dashboard
{
    class Dashboard
    {
        public string get_total_profit_today()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PROFIT_TODAY", null);
            dal.Close();

            return id;
        }

        public string get_total_profit_last_week()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PROFIT_LAST_WEEK", null);
            dal.Close();

            return id;
        }

        public string get_total_profit_last_month()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PROFIT_LAST_MONTH", null);
            dal.Close();

            return id;
        }

        public string get_total_profit_last_year()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            var id = dal.SelectSingleData("GET_TOTAL_PROFIT_LAST_YEAR", null);
            dal.Close();

            return id;
        }
    }
}
