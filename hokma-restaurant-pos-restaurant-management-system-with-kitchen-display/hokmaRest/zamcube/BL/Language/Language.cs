using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Language
{
    class Language
    {
        public DataTable get_language(int language_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = language_id;

            dt = dal.SelectData("GET_LANGUAGE_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_language(
            string name,
            Byte[] image,
            int is_default,
            string code,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@image", SqlDbType.Image);
            param[1].Value = image;

            param[2] = new SqlParameter("@is_default", SqlDbType.Int);
            param[2].Value = is_default;

            param[3] = new SqlParameter("@code", SqlDbType.NVarChar, 250);
            param[3].Value = code;

            param[4] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[4].Value = created_at;

            param[5] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[5].Value = updated_at;

            param[6] = new SqlParameter("@id", SqlDbType.Int);
            param[6].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_LANGUAGE", param, "language");
            dal.Close();

            return id;
        }
        public int update_language(
            int language_id,
            string name,
            Byte[] image,
            int is_default,
            string code,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = language_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@image", SqlDbType.Image);
            param[2].Value = image;

            param[3] = new SqlParameter("@is_default", SqlDbType.Int);
            param[3].Value = is_default;

            param[4] = new SqlParameter("@code", SqlDbType.NVarChar, 250);
            param[4].Value = code;

            param[5] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[5].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_LANGUAGE", param, "language");
            dal.Close();

            return id;
        }
        public int delete(
            int language_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = language_id;

            var id = dal.excuteCommand("DELETE_LANGUAGE", param, "language");
            dal.Close();

            return id;
        }
    }
}
