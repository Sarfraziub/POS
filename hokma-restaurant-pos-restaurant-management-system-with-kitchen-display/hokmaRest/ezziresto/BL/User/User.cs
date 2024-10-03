using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.User
{
    class User
    {
        public string get_last_id()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_USER_LAST_ID", param);
            dal.Close();

            return id;
        }

        public DataTable get_user(int user_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = user_id;

            dt = dal.SelectData("GET_USER_BY_ID", param);
            dal.Close();

            return dt;
        }
        
        public bool check_user_permission_group(int user_id, string group)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@group", SqlDbType.NVarChar, 250);
            param[1].Value = group;

            dt = dal.SelectData("CHECK_USER_PERMISSION_GROUP", param);
            dal.Close();

            if (dt.Rows.Count == 0)
                return false;

            return true;
        }
        public bool check_user_permission(int user_id, string permission)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@permission", SqlDbType.NVarChar, 250);
            param[1].Value = permission;

            dt = dal.SelectData("CHECK_USER_PERMISSION", param);
            dal.Close();

            if (dt.Rows.Count == 0)
                return false;

            return true;
        }

        public DataTable get_user_permission_groups(int user_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            dt = dal.SelectData("GET_USER_PERMISSION_GROUPS_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_user_permissions(int user_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            dt = dal.SelectData("GET_USER_PERMISSIONS_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_all_users()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = null;

            dt = dal.SelectData("GET_ALL_USERS", param);
            dal.Close();

            return dt;
        }

        public int add_permission_group(
           int user_id,
           int permission_group_id,
           string group,
           DateTime created_at,
           DateTime updated_at
           )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@permission_group_id", SqlDbType.Int);
            param[1].Value = permission_group_id;

            param[2] = new SqlParameter("@group", SqlDbType.NVarChar, 250);
            param[2].Value = group;

            param[3] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[3].Value = created_at;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_USER_PERMISSION_GROUP", param, "permission");
            dal.Close();

            return id;
        }
        
        public int add_permission(
            int user_id,
            int permission_id,
            string permission,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@permission_id", SqlDbType.Int);
            param[1].Value = permission_id;

            param[2] = new SqlParameter("@permission", SqlDbType.NVarChar, 250);
            param[2].Value = permission;

            param[3] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[3].Value = created_at;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_USER_PERMISSION", param, "permission");
            dal.Close();

            return id;
        }

        public int add_user(
            string name,
            string phn_no,
            string slug,
            string email,
            string password,
            string user_type,
            int is_active,
            int is_banned,
            int permission_group_id,
            int restaurant_id,
            string address,
            byte[] image,
            int branch_id,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[1].Value = phn_no;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[3].Value = email;

            param[4] = new SqlParameter("@password", SqlDbType.NVarChar, 250);
            param[4].Value = password;

            param[5] = new SqlParameter("@user_type", SqlDbType.NVarChar, 250);
            param[5].Value = user_type;

            param[6] = new SqlParameter("@is_active", SqlDbType.Int);
            param[6].Value = is_active;

            param[7] = new SqlParameter("@is_banned", SqlDbType.Int);
            param[7].Value = is_banned;

            param[8] = new SqlParameter("@permission_group_id", SqlDbType.Int);
            param[8].Value = permission_group_id;

            param[9] = new SqlParameter("@restaurant_id", SqlDbType.Int);
            param[9].Value = restaurant_id;

            param[10] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[10].Value = address;

            param[11] = new SqlParameter("@image", SqlDbType.Image);
            param[11].Value = image;

            param[12] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[12].Value = branch_id;

            param[13] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[13].Value = created_at;

            param[14] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[14].Value = updated_at;

            param[15] = new SqlParameter("@id", SqlDbType.Int);
            param[15].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_USER", param, "user");
            dal.Close();

            return id;
        }

        public int update_user(
            int user_id,
            string name,
            string phn_no,
            string slug,
            string email,
            string password,
            string user_type,
            int is_active,
            int is_banned,
            int permission_group_id,
            int restaurant_id,
            string address,
            byte[] image,
            int branch_id,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[15];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[2].Value = phn_no;

            param[3] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[3].Value = slug;

            param[4] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[4].Value = email;

            param[5] = new SqlParameter("@password", SqlDbType.NVarChar, 250);
            param[5].Value = password;

            param[6] = new SqlParameter("@user_type", SqlDbType.NVarChar, 250);
            param[6].Value = user_type;

            param[7] = new SqlParameter("@is_active", SqlDbType.Int);
            param[7].Value = is_active;

            param[8] = new SqlParameter("@is_banned", SqlDbType.Int);
            param[8].Value = is_banned;

            param[9] = new SqlParameter("@permission_group_id", SqlDbType.Int);
            param[9].Value = permission_group_id;

            param[10] = new SqlParameter("@restaurant_id", SqlDbType.Int);
            param[10].Value = restaurant_id;

            param[11] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[11].Value = address;

            param[12] = new SqlParameter("@image", SqlDbType.Image);
            param[12].Value = image;

            param[13] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[13].Value = branch_id;

            param[14] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[14].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_USER", param, "user");
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

            var id = dal.excuteCommand("DELETE_USER", param, "user");
            dal.Close();

            return id;
        }
        public int delete_all()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = null;

            var id = dal.excuteCommand("DELETE_ALL_USER", param, "user");
            dal.Close();

            return id;
        }
    }
}
