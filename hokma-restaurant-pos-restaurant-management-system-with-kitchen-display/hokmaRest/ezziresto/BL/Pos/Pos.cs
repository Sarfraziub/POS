using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Pos
{
    class Pos
    {
        public DataTable get_food_orders_by_client(int client_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = client_id;

            dt = dal.SelectData("GET_FOOD_ORDERS_BY_CLIENT_ID", param);
            dal.Close();

            return dt;
        }
        
        public int add_order_groups(
            int restaurant_id,
            int work_period_id,
            int user_id,
            string user_name,
            int branch_id,
            string branch_name,
            int customer_id,
            string customer_name,
            string ref_text,
            int table_id,
            string ref_amount,
            string table_name,
            int waiter_id,
            string waiter_name,
            int dept_tag_id,
            string dept_tag_name,
            string token,
            string total_guest,
            int service_charge,
            int discount,
            int dept_commission,
            string order_bill,
            string vat,
            string vat_system,
            string cgst,
            string sgst,
            string total_payable,
            string bill_distribution,
            string paid_amount,
            string return_amount,
            int is_paid,
            int is_accepted,
            int is_cancelled,
            int is_settled,
            int is_ready, 
            int is_delivered, 
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[39];

            param[0] = new SqlParameter("@restaurant_id", SqlDbType.Int);
            param[0].Value = restaurant_id;

            param[1] = new SqlParameter("@work_period_id", SqlDbType.Int);
            param[1].Value = work_period_id;

            param[2] = new SqlParameter("@user_id", SqlDbType.Int);
            param[2].Value = user_id;

            param[3] = new SqlParameter("@user_name", SqlDbType.NVarChar, 250);
            param[3].Value = user_name;

            param[4] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[4].Value = branch_id;

            param[5] = new SqlParameter("@branch_name", SqlDbType.NVarChar, 250);
            param[5].Value = branch_name;

            param[6] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[6].Value = customer_id;

            param[7] = new SqlParameter("@customer_name", SqlDbType.NVarChar, 250);
            param[7].Value = customer_name;

            param[8] = new SqlParameter("@ref_text", SqlDbType.NVarChar, 250);
            param[8].Value = ref_text;

            param[9] = new SqlParameter("@table_id", SqlDbType.Int);
            param[9].Value = table_id;

            param[10] = new SqlParameter("@ref_amount", SqlDbType.NVarChar, 250);
            param[10].Value = ref_amount;

            param[11] = new SqlParameter("@table_name", SqlDbType.NVarChar, 250);
            param[11].Value = table_name;

            param[12] = new SqlParameter("@waiter_id", SqlDbType.Int);
            param[12].Value = waiter_id;

            param[13] = new SqlParameter("@waiter_name", SqlDbType.NVarChar, 250);
            param[13].Value = waiter_name;

            param[14] = new SqlParameter("@dept_tag_id", SqlDbType.Int);
            param[14].Value = dept_tag_id;

            param[15] = new SqlParameter("@dept_tag_name", SqlDbType.NVarChar, 250);
            param[15].Value = dept_tag_name;

            param[16] = new SqlParameter("@token", SqlDbType.NVarChar, 250);
            param[16].Value = token;

            param[17] = new SqlParameter("@total_guest", SqlDbType.NVarChar, 250);
            param[17].Value = total_guest;

            param[18] = new SqlParameter("@service_charge", SqlDbType.Int);
            param[18].Value = service_charge;

            param[19] = new SqlParameter("@discount", SqlDbType.Int);
            param[19].Value = discount;

            param[20] = new SqlParameter("@dept_commission", SqlDbType.Int);
            param[20].Value = dept_commission;

            param[21] = new SqlParameter("@order_bill", SqlDbType.NVarChar, 250);
            param[21].Value = order_bill;

            param[22] = new SqlParameter("@vat", SqlDbType.NVarChar, 250);
            param[22].Value = vat;

            param[23] = new SqlParameter("@vat_system", SqlDbType.NVarChar, 250);
            param[23].Value = vat_system;

            param[24] = new SqlParameter("@cgst", SqlDbType.NVarChar, 250);
            param[24].Value = cgst;

            param[25] = new SqlParameter("@sgst", SqlDbType.NVarChar, 250);
            param[25].Value = sgst;

            param[26] = new SqlParameter("@total_payable", SqlDbType.NVarChar, 250);
            param[26].Value = total_payable;

            param[27] = new SqlParameter("@bill_distribution", SqlDbType.NVarChar, 250);
            param[27].Value = bill_distribution;

            param[28] = new SqlParameter("@paid_amount", SqlDbType.NVarChar, 250);
            param[28].Value = paid_amount;

            param[29] = new SqlParameter("@return_amount", SqlDbType.NVarChar, 250);
            param[29].Value = return_amount;

            param[30] = new SqlParameter("@is_paid", SqlDbType.Int);
            param[30].Value = is_paid;

            param[31] = new SqlParameter("@is_accepted", SqlDbType.Int);
            param[31].Value = is_accepted;

            param[32] = new SqlParameter("@is_cancelled", SqlDbType.Int);
            param[32].Value = is_cancelled;

            param[33] = new SqlParameter("@is_settled", SqlDbType.Int);
            param[33].Value = is_settled;

            param[34] = new SqlParameter("@is_ready", SqlDbType.Int);
            param[34].Value = is_ready;

            param[35] = new SqlParameter("@is_delivered", SqlDbType.Int);
            param[35].Value = is_delivered;
            
            param[36] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[36].Value = created_at;

            param[37] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[37].Value = updated_at;

            param[38] = new SqlParameter("@id", SqlDbType.Int);
            param[38].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_ORDER_GROUPS", param, "order_groups");
            dal.Close();

            return id;
        }

        public int add_order_items(
            int order_group_id,
            int food_item_id,
            string food_item,
            string food_group,
            string variation,
            string properties,
            int quantity,
            string price,
            string department_tags,
            int is_cooking,
            int is_ready,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@order_group_id", SqlDbType.Int);
            param[0].Value = order_group_id;

            param[1] = new SqlParameter("@food_item_id", SqlDbType.Int);
            param[1].Value = food_item_id;

            param[2] = new SqlParameter("@food_item", SqlDbType.NVarChar, 250);
            param[2].Value = food_item;

            param[3] = new SqlParameter("@food_group", SqlDbType.NVarChar, 250);
            param[3].Value = food_group;

            param[4] = new SqlParameter("@variation", SqlDbType.NVarChar, 250);
            param[4].Value = variation;

            param[5] = new SqlParameter("@properties", SqlDbType.NVarChar, 250);
            param[5].Value = properties;

            param[6] = new SqlParameter("@quantity", SqlDbType.Int);
            param[6].Value = quantity;

            param[7] = new SqlParameter("@price", SqlDbType.NVarChar, 250);
            param[7].Value = price;

            param[8] = new SqlParameter("@department_tags", SqlDbType.NVarChar, 250);
            param[8].Value = department_tags;

            param[9] = new SqlParameter("@is_cooking", SqlDbType.Int);
            param[9].Value = is_cooking;

            param[10] = new SqlParameter("@is_ready", SqlDbType.Int);
            param[10].Value = is_ready;

            param[11] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[11].Value = created_at;

            param[12] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[12].Value = updated_at;

            param[13] = new SqlParameter("@id", SqlDbType.Int);
            param[13].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_ORDER_ITEMS", param, "order_items");
            dal.Close();

            return id;
        }



        public DataTable get_food_item_by_group_id(int food_group_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_group_id;

            dt = dal.SelectData("GET_FOOD_ITEM_BY_GROUP_ID", param);
            dal.Close();

            return dt;
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
        public DataTable get_food_properties_by_id(string properties_ids)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ids", SqlDbType.NVarChar, 250);
            param[0].Value = properties_ids;

            dt = dal.SelectData("GET_FOOD_PROPERTIES_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int update_accept_order(
            int order_id,
            int is_accepted,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@is_accepted", SqlDbType.Int);
            param[1].Value = is_accepted;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_ACCEPT_ORDER", param, "order");
            dal.Close();

            return id;
        }
        public int update_ready_order(
            int order_id,
            int is_ready,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@is_ready", SqlDbType.Int);
            param[1].Value = is_ready;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_READY_ORDER", param, "order");
            dal.Close();

            return id;
        }

        public int update_cancelled_order(
            int order_id,
            int is_cancelled,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@is_cancelled", SqlDbType.Int);
            param[1].Value = is_cancelled;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_CANCEL_ORDER", param, "order");
            dal.Close();

            return id;
        }

        public int update_delivered_order(
            int order_id,
            int is_delivered,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@is_delivered", SqlDbType.Int);
            param[1].Value = is_delivered;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_DELIVRED_ORDER", param, "order");
            dal.Close();

            return id;
        }
    }
    
}
