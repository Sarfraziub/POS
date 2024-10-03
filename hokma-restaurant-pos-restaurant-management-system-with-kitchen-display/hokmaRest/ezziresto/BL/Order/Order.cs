using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Order
{
    class Order
    {

        public DataTable get_new_orders_by_waiter_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_NEW_ORDERS_WAITER_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_accepted_orders_by_waiter_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ACCEPTED_ORDERS_WAITER_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_delivred_orders_by_waiter_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_DELIVRED_ORDERS_WAITER_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_termined_orders_by_waiter_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_TERMINED_ORDERS_WAITER_BY_ID", param);
            dal.Close();

            return dt;
        }




        public DataTable get_new_orders_by_custommer_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_NEW_ORDERS_CUSTOMMER_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_accepted_orders_by_custommer_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ACCEPTED_ORDERS_CUSTOMMER_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_delivred_orders_by_custommer_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_DELIVRED_ORDERS_CUSTOMMER_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_termined_orders_by_custommer_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_TERMINED_ORDERS_CUSTOMMER_BY_ID", param);
            dal.Close();

            return dt;
        }




        public DataTable get_new_orders_by_table_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_NEW_ORDERS_TABLE_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_accepted_orders_by_table_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ACCEPTED_ORDERS_TABLE_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_delivred_orders_by_table_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_DELIVRED_ORDERS_TABLE_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_termined_orders_by_table_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_TERMINED_ORDERS_TABLE_BY_ID", param);
            dal.Close();

            return dt;
        }




        public DataTable get_order_group_by_branch_id(int branch_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = branch_id;

            dt = dal.SelectData("GET_ORDER_GROUP_BY_BRANCH", param);
            dal.Close();

            return dt;
        }

        public DataTable get_order_group_by_id(int order_group_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_group_id;

            dt = dal.SelectData("GET_ORDER_GROUP_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_new_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("GET_NEW_ORDERS", null);
            dal.Close();

            return dt;
        }
        public DataTable get_accepted_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("GET_ACCEPTED_ORDERS", null);
            dal.Close();

            return dt;
        }
        public DataTable get_delivred_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("GET_DELIVRED_ORDERS", null);
            dal.Close();

            return dt;
        }
        public DataTable get_termined_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("GET_TERMINED_ORDERS", null);
            dal.Close();

            return dt;
        }

        public DataTable get_new_orders_by_branch_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_NEW_ORDERS_BRANCH_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_accepted_orders_by_branch_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ACCEPTED_ORDERS_BRANCH_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_delivred_orders_by_branch_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_DELIVRED_ORDERS_BRANCH_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_termined_orders_by_branch_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_TERMINED_ORDERS_BRANCH_BY_ID", param);
            dal.Close();

            return dt;
        }



        public DataTable get_new_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_NEW_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_accepted_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ACCEPTED_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_delivred_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_DELIVRED_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable get_termined_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_TERMINED_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_order_groups()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("GET_ORDER_GROUPS", null);
            dal.Close();

            return dt;
        }

        public DataTable get_food_orders_by_id(int order_group_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_group_id;

            dt = dal.SelectData("GET_ORDER_ITEMS_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int update_product(
            string Pro_Name,
            string Ref,
            int Box,
            Decimal Box_Price,
            int Qnt_Init,
            int Qty_Alert,
            DateTime Production_Date,
            DateTime Expiration_Date,
            DateTime Waiting_period,
            byte[] Image,
            int Tax_ID,
            int Ut_ID,
            int Cate_ID,
            int Fm_ID,
            int Brand_ID
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@Pro_Name", SqlDbType.NVarChar, 250);
            param[0].Value = Pro_Name;

            param[1] = new SqlParameter("@Ref", SqlDbType.NVarChar, 50);
            param[1].Value = Ref;

            param[2] = new SqlParameter("@Box", SqlDbType.Int);
            param[2].Value = Box;

            param[3] = new SqlParameter("@Box_Price", SqlDbType.Decimal);
            param[3].Value = Box_Price;

            param[4] = new SqlParameter("@Qnt_Init", SqlDbType.Int);
            param[4].Value = Qnt_Init;

            param[5] = new SqlParameter("@Qty_Alert", SqlDbType.Int);
            param[5].Value = Qty_Alert;

            param[6] = new SqlParameter("@Production_Date", SqlDbType.DateTime);
            param[6].Value = Production_Date;

            param[7] = new SqlParameter("@Expiration_Date", SqlDbType.DateTime);
            param[7].Value = Expiration_Date;

            param[8] = new SqlParameter("@Waiting_period", SqlDbType.DateTime);
            param[8].Value = Waiting_period;

            param[9] = new SqlParameter("@Image", SqlDbType.Image);
            param[9].Value = Image;

            param[10] = new SqlParameter("@Tax_ID", SqlDbType.Int);
            param[10].Value = Tax_ID;

            param[11] = new SqlParameter("@Ut_ID", SqlDbType.Int);
            param[11].Value = Ut_ID;

            param[12] = new SqlParameter("@Cate_ID", SqlDbType.Int);
            param[12].Value = Cate_ID;

            param[13] = new SqlParameter("@Fm_ID", SqlDbType.Int);
            param[13].Value = Fm_ID;

            param[14] = new SqlParameter("@Brand_ID", SqlDbType.Int);
            param[14].Value = Brand_ID;

            param[15] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[15].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_PRODUCT", param, "product");
            dal.Close();

            return id;
        }

        public DataTable update_new_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("UPDATE_NEW_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable update_accepted_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("UPDATE_ACCEPTED_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable update_delivred_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("UPDATE_DELIVRED_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }
        public DataTable update_termined_orders_by_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("UPDATE_TERMINED_ORDERS_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable update_all_new_orders_cancelled()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_ALL_NEW_ORDERS_CANCELLED", null);
            dal.Close();

            return dt;
        }

        public DataTable update_return_all_new_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_RETURN_ALL_NEW_ORDERS", null);
            dal.Close();

            return dt;
        }

        public DataTable update_all_new_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_ALL_NEW_ORDERS", null);
            dal.Close();

            return dt;
        }

        public DataTable update_return_all_accepted_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_RETURN_ALL_ACCEPTED_ORDERS", null);
            dal.Close();

            return dt;
        }

        public DataTable update_all_accepted_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_ALL_ACCEPTED_ORDERS", null);
            dal.Close();

            return dt;
        }
        public DataTable update_all_delivred_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_ALL_DELIVRED_ORDERS", null);
            dal.Close();

            return dt;
        }

        public DataTable update_all_termined_orders()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[0];

            dt = dal.SelectData("UPDATE_ALL_TERMINED_ORDERS", null);
            dal.Close();

            return dt;
        }

        public string get_last_id()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_LAST_ID", param);
            dal.Close();

            return id;
        }
        
        public string get_products_total_price(int order_id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@total", SqlDbType.Real);
            param[1].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_PRODUCTS_ORDER_TOTAL_PRICE", param, "total_price");
            dal.Close();

            return id;
        }
        public string get_orders_total()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@total", SqlDbType.Real);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_ORDERS_TOTAL_PRICE", param, "total_price");
            dal.Close();

            return id;
        }

        public DataTable get_product_prices(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_PRODUCT_PRICES", param);
            dal.Close();

            return dt;
        }
        public DataTable get_order(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ORDER", param);
            dal.Close();

            return dt;
        }
        public DataTable get_order_products(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_ORDER_PRODUCTS", param);
            dal.Close();

            return dt;
        }

        public DataTable get_product_details(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_PRODUCT_DETAILS", param);
            dal.Close();

            return dt;
        }

        public DataTable update_order_waiter_id(int id,int waiter_id, DateTime updated_at)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@waiter_id", SqlDbType.Int);
            param[1].Value = waiter_id;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            dt = dal.SelectData("UPDATE_ORDER_WAITER_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable update_order_customer_id(int id,int customer_id, DateTime updated_at)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@customer_id", SqlDbType.Int);
            param[1].Value = customer_id;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            dt = dal.SelectData("UPDATE_ORDER_CUSTOMER_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable update_order_table_id(int id,int table_id, DateTime updated_at)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@table_id", SqlDbType.Int);
            param[1].Value = table_id;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            dt = dal.SelectData("UPDATE_ORDER_TABLE_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable update_order_branch_id(int id, int branch_id, DateTime updated_at)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[1].Value = branch_id;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            dt = dal.SelectData("UPDATE_ORDER_BRANCH_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable update_order_departement_id(int id, int dept_tag_id, DateTime updated_at)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@dept_tag_id", SqlDbType.Int);
            param[1].Value = dept_tag_id;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            dt = dal.SelectData("UPDATE_ORDER_DEPARTEMENT_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable order_is_paid_id(int id, int is_paid, string paid_amount, string return_amount, DateTime updated_at)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@is_paid", SqlDbType.Int);
            param[1].Value = is_paid;

            param[2] = new SqlParameter("@paid_amount", SqlDbType.NVarChar, 250);
            param[2].Value = paid_amount;

            param[3] = new SqlParameter("@return_amount", SqlDbType.NVarChar, 250);
            param[3].Value = return_amount;

            param[4] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[4].Value = updated_at;

            dt = dal.SelectData("UPDATE_ORDER_IS_PAID_ID", param);
            dal.Close();

            return dt;
        }

        public int delete_order(
            int order_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_id;

            var id = dal.excuteCommand("DELETE_ORDER", param, "order");
            dal.Close();

            return id;
        }

        public int delete_order_item(
            int order_item_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = order_item_id;

            var id = dal.excuteCommand("DELETE_ORDER_ITEM", param, "order");
            dal.Close();

            return id;
        }
    }
}
