using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Table
{
    class Table
    {
        public DataTable get_table(int table_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = table_id;

            dt = dal.SelectData("GET_TABLE_BY_ID", param);
            dal.Close();

            return dt;
        }
        
        public int add_table(
            string name,
            string slug,
            string capacity,
            string assigned_to_section,
            int rsv_id,
            int waiter_id,
            DateTime seating_time,
            int branch_id,
            int zone_id,
            string status,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[1].Value = slug;

            param[2] = new SqlParameter("@capacity", SqlDbType.NVarChar, 250);
            param[2].Value = capacity;

            param[3] = new SqlParameter("@assigned_to_section", SqlDbType.NVarChar, 250);
            param[3].Value = assigned_to_section;

            param[4] = new SqlParameter("@rsv_id", SqlDbType.Int);
            param[4].Value = rsv_id;

            param[5] = new SqlParameter("@waiter_id", SqlDbType.Int);
            param[5].Value = waiter_id;

            param[6] = new SqlParameter("@seating_time", SqlDbType.DateTime);
            param[6].Value = seating_time;

            param[7] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[7].Value = branch_id;

            param[8] = new SqlParameter("@zone_id", SqlDbType.Int);
            param[8].Value = zone_id;

            param[9] = new SqlParameter("@status", SqlDbType.NVarChar, 250);
            param[9].Value = status;

            param[10] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[10].Value = created_at;

            param[11] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[11].Value = updated_at;

            param[12] = new SqlParameter("@id", SqlDbType.Int);
            param[12].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_TABLE", param, "table");
            dal.Close();

            return id;
        }

        public int update_table(
            int table_id,
            string name,
            string slug,
            string capacity,
            string assigned_to_section,
            int rsv_id,
            int waiter_id,
            DateTime seating_time,
            int branch_id,
            int zone_id,
            string status,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = table_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@capacity", SqlDbType.NVarChar, 250);
            param[3].Value = capacity;

            param[4] = new SqlParameter("@assigned_to_section", SqlDbType.NVarChar, 250);
            param[4].Value = assigned_to_section;

            param[5] = new SqlParameter("@rsv_id", SqlDbType.Int);
            param[5].Value = rsv_id;

            param[6] = new SqlParameter("@waiter_id", SqlDbType.Int);
            param[6].Value = waiter_id;

            param[7] = new SqlParameter("@seating_time", SqlDbType.DateTime);
            param[7].Value = seating_time;

            param[8] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[8].Value = branch_id;

            param[9] = new SqlParameter("@zone_id", SqlDbType.Int);
            param[9].Value = zone_id;

            param[10] = new SqlParameter("@status", SqlDbType.NVarChar, 250);
            param[10].Value = status;

            param[11] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[11].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_TABLE", param, "table");
            dal.Close();

            return id;
        }

        public int delete(
            int table_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = table_id;

            var id = dal.excuteCommand("DELETE_TABLE", param, "table");
            dal.Close();

            return id;
        }
    }
}
