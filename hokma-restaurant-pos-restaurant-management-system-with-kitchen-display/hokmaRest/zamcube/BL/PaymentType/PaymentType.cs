using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.PaymentType
{
    class PaymentType
    {
        public DataTable get_payment_type(int payment_type_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = payment_type_id;

            dt = dal.SelectData("GET_PAYMENT_TYPE_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable exists(string value)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@value", SqlDbType.NVarChar, 250);
            param[0].Value = value;

            dt = dal.SelectData("EXISTS_PAYMENT_TYPE_VALUE", param);
            dal.Close();

            return dt;
        }

        public int add_payment_type(
            string Name,
            string slug,
            string input_key,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[1].Value = slug;

            param[2] = new SqlParameter("@input_key", SqlDbType.NVarChar, 250);
            param[2].Value = input_key;
            
            param[3] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[3].Value = created_at;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_PAYMENT_TYPE", param, "payment_type");
            dal.Close();

            return id;
        }
        public int update_payment_type(
            int payment_type_id,
            string Name,
            string slug,
            string input_key,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = payment_type_id;

            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@input_key", SqlDbType.NVarChar, 250);
            param[3].Value = input_key;
            
            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_PAYMENT_TYPE", param, "payment_type");
            dal.Close();

            return id;
        }
        public int delete(
            int payment_type_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = payment_type_id;

            var id = dal.excuteCommand("DELETE_PAYMENT_TYPE", param, "payment_type");
            dal.Close();

            return id;
        }
    }
}
