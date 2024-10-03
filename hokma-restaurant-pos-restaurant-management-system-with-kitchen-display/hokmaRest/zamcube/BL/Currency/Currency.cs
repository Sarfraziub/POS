using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Currency
{
    class Currency
    {
        public DataTable get_currency(int currency_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = currency_id;

            dt = dal.SelectData("GET_CURRENCY_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_currency(
            string name, 
            string symbol,
            Decimal rate,
            string alignment,
            int is_default,
            string code,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@symbol", SqlDbType.NVarChar, 250);
            param[1].Value = symbol;

            param[2] = new SqlParameter("@rate", SqlDbType.Decimal);
            param[2].Value = rate;

            param[3] = new SqlParameter("@alignment", SqlDbType.NVarChar, 250);
            param[3].Value = alignment;

            param[4] = new SqlParameter("@is_default", SqlDbType.Int);
            param[4].Value = is_default;

            param[5] = new SqlParameter("@code", SqlDbType.NVarChar, 250);
            param[5].Value = code;

            param[6] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[6].Value = created_at;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            param[8] = new SqlParameter("@id", SqlDbType.Int);
            param[8].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_CURRENCY", param, "currency");
            dal.Close();

            return id;
        }
        public int update_currency(
            int currency_id,
            string name,
            string symbol,
            Decimal rate,
            string alignment,
            int is_default,
            string code,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = currency_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@symbol", SqlDbType.NVarChar, 250);
            param[2].Value = symbol;

            param[3] = new SqlParameter("@rate", SqlDbType.Decimal);
            param[3].Value = rate;

            param[4] = new SqlParameter("@alignment", SqlDbType.NVarChar, 250);
            param[4].Value = alignment;

            param[5] = new SqlParameter("@is_default", SqlDbType.Int);
            param[5].Value = is_default;

            param[6] = new SqlParameter("@code", SqlDbType.NVarChar, 250);
            param[6].Value = code;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_CURRENCY", param, "currency");
            dal.Close();

            return id;
        }


        public int default_currency(
            int currency_id,
            int is_default,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = currency_id;

            param[1] = new SqlParameter("@is_default", SqlDbType.Int);
            param[1].Value = is_default;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("DEFAULT_CURRENCY", param, "currency");
            dal.Close();

            return id;
        }

        public DataTable get_currency()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = null;

            dt = dal.SelectData("GET_DEFAULT_CURRENCY", param);
            dal.Close();

            return dt;
        }

        public int delete(
            int currency_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = currency_id;

            var id = dal.excuteCommand("DELETE_CURRENCY", param, "currency");
            dal.Close();

            return id;
        }
    }
}
