using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.IngredientItem
{
    class IngredientItem
    {
        public DataTable get_ingredient_item(int ingredient_item_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ingredient_item_id;

            dt = dal.SelectData("GET_INGREDIENT_ITEM_BY_ID", param);
            dal.Close(); 

            return dt;
        }

        public int add_ingredient_item(
            int ingredient_group_id,
            string group_name,
            string name,
            string slug,
            string unit,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@ingredient_group_id", SqlDbType.Int);
            param[0].Value = ingredient_group_id;

            param[1] = new SqlParameter("@group_name", SqlDbType.NVarChar, 250);
            param[1].Value = group_name;

            param[2] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[2].Value = name;

            param[3] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[3].Value = slug;

            param[4] = new SqlParameter("@unit", SqlDbType.NVarChar, 250);
            param[4].Value = unit;

            param[5] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[5].Value = created_at;

            param[6] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[6].Value = updated_at;

            param[7] = new SqlParameter("@id", SqlDbType.Int);
            param[7].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_INGREDIENT_ITEM", param, "ingredient_item");
            dal.Close();

            return id;
        }

        public int update_ingredient_item(
            int ingredient_item_id,
            int ingredient_group_id,
            string group_name,
            string name,
            string slug,
            string unit,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ingredient_item_id;

            param[1] = new SqlParameter("@ingredient_group_id", SqlDbType.Int);
            param[1].Value = ingredient_group_id;

            param[2] = new SqlParameter("@group_name", SqlDbType.NVarChar, 250);
            param[2].Value = group_name;

            param[3] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[3].Value = name;

            param[4] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[4].Value = slug;

            param[5] = new SqlParameter("@unit", SqlDbType.NVarChar, 250);
            param[5].Value = unit;

            param[6] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[6].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_INGREDIENT_ITEM", param, "ingredient_item");
            dal.Close();

            return id;
        }
        public int delete(
            int ingredient_item_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ingredient_item_id;

            var id = dal.excuteCommand("DELETE_INGREDIENT_ITEM", param, "ingredient_item");
            dal.Close();

            return id;
        }
    }
}
