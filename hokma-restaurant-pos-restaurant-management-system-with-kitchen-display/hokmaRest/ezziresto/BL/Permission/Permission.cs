﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Permission
{
    class Permission
    {
        public DataTable get_permission(int permission_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = permission_id;

            dt = dal.SelectData("GET_PERMISSION_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_permission(
            string Name,
            string slug,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[1].Value = slug;

            param[2] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[2].Value = created_at;

            param[3] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[3].Value = updated_at;

            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_PERMISSION", param, "permission");
            dal.Close();

            return id;
        }

        public int update_permission(
            int permission_id,
            string Name,
            string slug,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = permission_id;

            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[3].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_PERMISSION", param, "permission");
            dal.Close();

            return id;
        }
        public int delete(
            int permission_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = permission_id;

            var id = dal.excuteCommand("DELETE_PERMISSION", param, "permission");
            dal.Close();

            return id;
        }
    }
}
