using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Supplier
{
    class Supplier
    {
        public DataTable get_supplier(int supplier_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = supplier_id;

            dt = dal.SelectData("GET_SUPPLIER_BY_ID", param);
            dal.Close();

            return dt;
        }
        
        public int add_supplier(
            string name,
            string slug,
            string email,
            string phn_no,
            decimal due_balance,
            string address,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[1].Value = slug;

            param[2] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[2].Value = email;

            param[3] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[3].Value = phn_no;

            param[4] = new SqlParameter("@due_balance", SqlDbType.Decimal);
            param[4].Value = due_balance;

            param[5] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[5].Value = address;

            param[6] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[6].Value = created_at;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            param[8] = new SqlParameter("@id", SqlDbType.Int);
            param[8].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_SUPPLIER", param, "supplier");
            dal.Close();

            return id;
        }

        public int update_supplier(
            int supplier_id,
            string name,
            string slug,
            string email,
            string phn_no,
            decimal due_balance,
            string address,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = supplier_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[3].Value = email;

            param[4] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[4].Value = phn_no;

            param[5] = new SqlParameter("@due_balance", SqlDbType.Decimal);
            param[5].Value = due_balance;

            param[6] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[6].Value = address;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_SUPPLIER", param, "supplier");
            dal.Close();

            return id;
        }
        public int delete(
            int supplier_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = supplier_id;

            var id = dal.excuteCommand("DELETE_SUPPLIER", param, "supplier");
            dal.Close();

            return id;
        }
    }
}
