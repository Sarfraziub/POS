using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Customer
{
    class Customer
    {
        public string get_last_id()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_CUSTOMER_LAST_ID", param);
            dal.Close();

            return id;
        }

        public DataTable get_customer(int customer_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = customer_id;

            dt = dal.SelectData("GET_CUSTOMER_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_all_customers()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = null;

            dt = dal.SelectData("GET_ALL_CUSTOMERS", param);
            dal.Close();

            return dt;
        }
        
        public int add_customer(
            string name,
            string phn_no,
            string slug,
            string email,
            string type,
            string address,
            int branch_id,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[1].Value = phn_no;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[3].Value = email;

            param[4] = new SqlParameter("@type", SqlDbType.NVarChar, 250);
            param[4].Value = type;

            param[5] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[5].Value = address;

            param[6] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[6].Value = branch_id;

            param[7] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[7].Value = created_at;

            param[8] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[8].Value = updated_at;

            param[9] = new SqlParameter("@id", SqlDbType.Int);
            param[9].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_CUSTOMER", param, "customer");
            dal.Close();

            return id;
        }

        public int update_customer(
            int customer_id,
            string name,
            string phn_no,
            string slug,
            string email,
            string type,
            string address,
            int branch_id,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = customer_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[2].Value = phn_no;

            param[3] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[3].Value = slug;

            param[4] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[4].Value = email;

            param[5] = new SqlParameter("@type", SqlDbType.NVarChar, 250);
            param[5].Value = type;

            param[6] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[6].Value = address;

            param[7] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[7].Value = branch_id;

            param[8] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[8].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_CUSTOMER", param, "customer");
            dal.Close();

            return id;
        }

        public int update_customer_points(
            int customer_id,
            string points,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = customer_id;

            param[1] = new SqlParameter("@points", SqlDbType.NVarChar, 250);
            param[1].Value = points;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_CUSTOMER_POINTS", param, "customer");
            dal.Close();

            return id;
        }

        public int delete(
            int customer_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = customer_id;

            var id = dal.excuteCommand("DELETE_CUSTOMER", param, "customer");
            dal.Close();

            return id;
        }
        public int delete_all()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = null;

            var id = dal.excuteCommand("DELETE_ALL_CUSTOMER", param, "customer");
            dal.Close();

            return id;
        }

    }
}
