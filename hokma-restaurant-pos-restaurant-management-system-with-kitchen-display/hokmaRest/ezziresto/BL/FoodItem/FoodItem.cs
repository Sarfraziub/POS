using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.FoodItem
{
    class FoodItem
    {
        public DataTable get_food_item(int food_item_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_item_id;

            dt = dal.SelectData("GET_FOOD_ITEM_BY_ID", param);
            dal.Close();

            return dt;
        }
        
        public int add_food_item(
            int food_group_id,
            string name,
            decimal price,
            byte[] image,
            string barcode,
            string has_property,
            string property_group_ids,
            string has_variation,
            string is_special,
            string slug,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@food_group_id", SqlDbType.Int);
            param[0].Value = food_group_id;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@price", SqlDbType.Decimal);
            param[2].Value = price;

            param[3] = new SqlParameter("@image", SqlDbType.Image);
            param[3].Value = image;

            param[4] = new SqlParameter("@barcode", SqlDbType.NVarChar, 250);
            param[4].Value = barcode;

            param[5] = new SqlParameter("@has_property", SqlDbType.NVarChar, 250);
            param[5].Value = has_property;

            param[6] = new SqlParameter("@property_group_ids", SqlDbType.NVarChar, 250);
            param[6].Value = property_group_ids;

            param[7] = new SqlParameter("@has_variation", SqlDbType.NVarChar, 250);
            param[7].Value = has_variation;

            param[8] = new SqlParameter("@is_special", SqlDbType.NVarChar, 250);
            param[8].Value = is_special;

            param[9] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[9].Value = slug;

            param[10] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[10].Value = created_at;
            
            param[11] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[11].Value = updated_at;

            param[12] = new SqlParameter("@id", SqlDbType.Int);
            param[12].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_FOOD_ITEM", param, "food_item");
            dal.Close();

            return id;
        }

        public int update_food_item(
            int food_item_id,
            int food_group_id,
            string name,
            decimal price,
            byte[] image,
            string barcode,
            string has_property,
            string property_group_ids,
            string has_variation,
            string is_special,
            string slug,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_item_id;

            param[1] = new SqlParameter("@food_group_id", SqlDbType.Int);
            param[1].Value = food_group_id;

            param[2] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[2].Value = name;

            param[3] = new SqlParameter("@price", SqlDbType.Decimal);
            param[3].Value = price;

            param[4] = new SqlParameter("@image", SqlDbType.Image);
            param[4].Value = image;

            param[5] = new SqlParameter("@barcode", SqlDbType.NVarChar, 250);
            param[5].Value = barcode;

            param[6] = new SqlParameter("@has_property", SqlDbType.NVarChar, 250);
            param[6].Value = has_property;

            param[7] = new SqlParameter("@property_group_ids", SqlDbType.NVarChar, 250);
            param[7].Value = property_group_ids;

            param[8] = new SqlParameter("@has_variation", SqlDbType.NVarChar, 250);
            param[8].Value = has_variation;

            param[9] = new SqlParameter("@is_special", SqlDbType.NVarChar, 250);
            param[9].Value = is_special;

            param[10] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[10].Value = slug;

            param[11] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[11].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_FOOD_ITEM", param, "food_item");
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

            var id = dal.excuteCommand("DELETE_FOOD_ITEM", param, "food_item");
            dal.Close();

            return id;
        }

        public int add_food_with_variations(
            int food_item_id,
            int variation_id,
            decimal price,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@food_item_id", SqlDbType.Int);
            param[0].Value = food_item_id;

            param[1] = new SqlParameter("@variation_id", SqlDbType.Int);
            param[1].Value = variation_id;

            param[2] = new SqlParameter("@price", SqlDbType.Decimal);
            param[2].Value = price;

            param[3] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[3].Value = created_at;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            param[5] = new SqlParameter("@id", SqlDbType.Int);
            param[5].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_FOOD_WITH_VARIATIONS", param, "food_with_variations");
            dal.Close();

            return id;
        }

        public DataTable get_food_variations_by_id(int food_item_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_item_id;

            dt = dal.SelectData("GET_FOOD_VARIATIONS_BY_ID", param);
            dal.Close();

            return dt;
        }
        
    }
}
