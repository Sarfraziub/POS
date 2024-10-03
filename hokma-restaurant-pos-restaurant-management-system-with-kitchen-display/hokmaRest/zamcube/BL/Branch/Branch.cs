using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Branch
{
    class Branch
    {
        public DataTable get_branch(int food_item_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_item_id;

            dt = dal.SelectData("GET_BRANCH_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_branch(
            string name,
            string delivery_free,
            string slug,
            string address,
            string phn_no,
            string saas_banner,
            string saas_thumb,
            string active,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@delivery_free", SqlDbType.NVarChar, 250);
            param[1].Value = delivery_free;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;

            param[4] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[4].Value = phn_no;

            param[5] = new SqlParameter("@saas_banner", SqlDbType.NVarChar, 250);
            param[5].Value = saas_banner;

            param[6] = new SqlParameter("@saas_thumb", SqlDbType.NVarChar, 250);
            param[6].Value = saas_thumb;
            
            param[7] = new SqlParameter("@active", SqlDbType.NVarChar, 250);
            param[7].Value = active;

            param[8] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[8].Value = created_at;

            param[9] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[9].Value = updated_at;

            param[10] = new SqlParameter("@id", SqlDbType.Int);
            param[10].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_BRANCH", param, "branch");
            dal.Close();

            return id;
        }

        public int update_branch(
            int branch_id,
            string name,
            string delivery_free,
            string slug,
            string address,
            string phn_no,
            string saas_banner,
            string saas_thumb,
            string active,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = branch_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@delivery_free", SqlDbType.NVarChar, 250);
            param[2].Value = delivery_free;

            param[3] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[3].Value = slug;

            param[4] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[4].Value = address;

            param[5] = new SqlParameter("@phn_no", SqlDbType.NVarChar, 250);
            param[5].Value = phn_no;

            param[6] = new SqlParameter("@saas_banner", SqlDbType.NVarChar, 250);
            param[6].Value = saas_banner;

            param[7] = new SqlParameter("@saas_thumb", SqlDbType.NVarChar, 250);
            param[7].Value = saas_thumb;

            param[8] = new SqlParameter("@active", SqlDbType.NVarChar, 250);
            param[8].Value = active;

            param[9] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[9].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_BRANCH", param, "branch");
            dal.Close();

            return id;
        }
        public int delete(
            int food_item_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_item_id;

            var id = dal.excuteCommand("DELETE_BRANCH", param, "branch");
            dal.Close();

            return id;
        }

    }
}
