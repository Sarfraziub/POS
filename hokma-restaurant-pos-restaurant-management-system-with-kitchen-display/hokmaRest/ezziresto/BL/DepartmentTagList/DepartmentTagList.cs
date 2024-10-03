using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.DepartmentTagList
{
    class DepartmentTagList
    {
        public DataTable get_department_tag_list(int department_tag_list_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = department_tag_list_id;

            dt = dal.SelectData("GET_DEPARTMENT_TAG_LIST_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_department_tag_list(
            string name,
            string slug,
            string commission, 
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[1].Value = slug;

            param[2] = new SqlParameter("@commission", SqlDbType.NVarChar, 250);
            param[2].Value = commission;

            param[3] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[3].Value = created_at;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_DEPARTMENT_TAG_LIST", param, "department_tag_list");
            dal.Close();

            return id;
        }

        public int update_department_tag_list(
            int department_tag_list_id,
            string name,
            string slug,
            string commission,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = department_tag_list_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@commission", SqlDbType.NVarChar, 250);
            param[3].Value = commission;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_DEPARTMENT_TAG_LIST", param, "department_tag_list");
            dal.Close();

            return id;
        }
        public int delete(
            int department_tag_list_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = department_tag_list_id;

            var id = dal.excuteCommand("DELETE_DEPARTMENT_TAG_LIST", param, "department_tag_list");
            dal.Close();

            return id;
        }
    }
}
