using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Waiter
{
    class Waiter
    {
        public string get_last_id()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_WAITER_LAST_ID", param);
            dal.Close();

            return id;
        }

        public DataTable get_waiter(int waiter_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = waiter_id;

            dt = dal.SelectData("GET_WAITER_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_all_waiters()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = null;

            dt = dal.SelectData("GET_ALL_WAITERS", param);
            dal.Close();

            return dt;
        }
        
        public int add_waiter(
            string name,
            string phn_no,
            string slug,
            string address,
            byte[] image,
            int branch_id,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[1].Value = phn_no;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;

            param[4] = new SqlParameter("@image", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[5].Value = branch_id;

            param[6] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[6].Value = created_at;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            param[8] = new SqlParameter("@id", SqlDbType.Int);
            param[8].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_WAITER", param, "waiter");
            dal.Close();

            return id;
        }

        public int update_waiter(
            int waiter_id,
            string name,
            string phn_no,
            string slug,
            string address,
            byte[] image,
            int branch_id,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = waiter_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[2].Value = phn_no;

            param[3] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[3].Value = slug;

            param[4] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[4].Value = address;

            param[5] = new SqlParameter("@image", SqlDbType.Image);
            param[5].Value = image;

            param[6] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[6].Value = branch_id;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_WAITER", param, "waiter");
            dal.Close();

            return id;
        }
        public int delete(
            int waiter_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = waiter_id;

            var id = dal.excuteCommand("DELETE_WAITER", param, "waiter");
            dal.Close();

            return id;
        }
        public int delete_all()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = null;

            var id = dal.excuteCommand("DELETE_ALL_WAITER", param, "waiter");
            dal.Close();

            return id;
        }
    }
}
