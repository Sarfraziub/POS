using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.FoodPurchase
{
    class FoodPurchase
    {
        
        public DataTable get_food_purchases()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            dt = dal.SelectData("GET_FOOD_PURCHASES", null);
            dal.Close();

            return dt;
        }
        public DataTable get_food_purchases_histories()
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            dt = dal.SelectData("GET_FOOD_PURCHASES_HISTORY", null);
            dal.Close();

            return dt;
        }

        public DataTable get_food_purchases_histories_by_id(int food_purchase_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_purchase_id;

            dt = dal.SelectData("GET_FOOD_PURCHASES_HISTORIES_BY_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_food_purchases_history_by_id(int food_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@food_id", SqlDbType.Int);
            param[0].Value = food_id;

            dt = dal.SelectData("GET_FOOD_PURCHASE_HISTORY_BY_ID", param);
            dal.Close();

            return dt;
        }
        
        public DataTable get_food_purchases_by_supplier(int supplier_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = supplier_id;

            dt = dal.SelectData("GET_FOOD_PURCHASES_BY_SUPPLIER_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_food_purchases_items_by_supplier(int food_purchase_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_purchase_id;

            dt = dal.SelectData("GET_FOOD_PURCHASES_ITEMS_BY_SUPPLIER_ID", param);
            dal.Close();

            return dt;
        }

        public DataTable get_food_purchase(int food_purchase_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_purchase_id;

            dt = dal.SelectData("GET_FOOD_PURCHASE_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_food_purchase(
            int branch_id,
            int supplier_id,
            int payment_id,
            string supplier_name,
            int invoice_number,
            DateTime purchase_date,
            string description,
            string payment_type,
            decimal total_bill,
            decimal paid_amount,
            decimal credit_amount,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[0].Value = branch_id;

            param[1] = new SqlParameter("@supplier_id", SqlDbType.Int);
            param[1].Value = supplier_id;

            param[2] = new SqlParameter("@payment_id", SqlDbType.Int);
            param[2].Value = payment_id;

            param[3] = new SqlParameter("@supplier_name", SqlDbType.NVarChar, 250);
            param[3].Value = supplier_name;

            param[4] = new SqlParameter("@invoice_number", SqlDbType.Int);
            param[4].Value = invoice_number;

            param[5] = new SqlParameter("@purchase_date", SqlDbType.DateTime);
            param[5].Value = purchase_date;

            param[6] = new SqlParameter("@description", SqlDbType.NVarChar, 250);
            param[6].Value = description;

            param[7] = new SqlParameter("@payment_type", SqlDbType.NVarChar, 250);
            param[7].Value = payment_type;

            param[8] = new SqlParameter("@total_bill", SqlDbType.Decimal);
            param[8].Value = total_bill;

            param[9] = new SqlParameter("@paid_amount", SqlDbType.Decimal);
            param[9].Value = paid_amount;

            param[10] = new SqlParameter("@credit_amount", SqlDbType.Decimal);
            param[10].Value = credit_amount;

            param[11] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[11].Value = created_at;

            param[12] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[12].Value = updated_at;

            param[13] = new SqlParameter("@id", SqlDbType.Int);
            param[13].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_FOOD_PURCHASE", param, "food_purchase");
            dal.Close();

            return id;
        }

        public int add_food_purchase_history(
            int branch_id,
            int food_purchase_id,
            int food_id,
            string food_name,
            int qty,
            int rate,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[0].Value = branch_id;

            param[1] = new SqlParameter("@food_purchase_id", SqlDbType.Int);
            param[1].Value = food_purchase_id;

            param[2] = new SqlParameter("@food_id", SqlDbType.Int);
            param[2].Value = food_id;

            param[3] = new SqlParameter("@food_name", SqlDbType.NVarChar, 250);
            param[3].Value = food_name;

            param[4] = new SqlParameter("@qty", SqlDbType.Int);
            param[4].Value = qty;

            param[5] = new SqlParameter("@rate", SqlDbType.Int);
            param[5].Value = rate;

            param[6] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[6].Value = created_at;

            param[7] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[7].Value = updated_at;

            param[8] = new SqlParameter("@id", SqlDbType.Int);
            param[8].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_FOOD_PURCHASE_HISTORY", param, "food_purchase");
            dal.Close();

            return id;
        }

        public int update_food_purchase(
            int food_purchase_id,
            int branch_id,
            int supplier_id,
            int payment_id,
            string supplier_name,
            int invoice_number,
            DateTime purchase_date,
            string description,
            string payment_type,
            decimal total_bill,
            decimal paid_amount,
            decimal credit_amount,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_purchase_id;

            param[1] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[1].Value = branch_id;

            param[2] = new SqlParameter("@supplier_id", SqlDbType.Int);
            param[2].Value = supplier_id;

            param[3] = new SqlParameter("@payment_id", SqlDbType.Int);
            param[3].Value = payment_id;

            param[4] = new SqlParameter("@supplier_name", SqlDbType.NVarChar, 250);
            param[4].Value = supplier_name;

            param[5] = new SqlParameter("@invoice_number", SqlDbType.Int);
            param[5].Value = invoice_number;

            param[6] = new SqlParameter("@purchase_date", SqlDbType.DateTime);
            param[6].Value = purchase_date;

            param[7] = new SqlParameter("@description", SqlDbType.NVarChar, 250);
            param[7].Value = description;

            param[8] = new SqlParameter("@payment_type", SqlDbType.NVarChar, 250);
            param[8].Value = payment_type;

            param[9] = new SqlParameter("@total_bill", SqlDbType.Decimal);
            param[9].Value = total_bill;

            param[10] = new SqlParameter("@paid_amount", SqlDbType.Decimal);
            param[10].Value = paid_amount;

            param[11] = new SqlParameter("@credit_amount", SqlDbType.Decimal);
            param[11].Value = credit_amount;

            param[12] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[12].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_FOOD_PURCHASE", param, "food_purchase");
            dal.Close();

            return id;
        }

        public int update_food_stock_qty(
            int food_id,
            int qty,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@food_id", SqlDbType.Int);
            param[0].Value = food_id;

            param[1] = new SqlParameter("@qty", SqlDbType.Int);
            param[1].Value = qty;

            param[2] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[2].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_FOOD_STOCK_QTY", param, "food_food_stock_qty");
            dal.Close();

            return id;
        }

        public int delete(
            int food_purchase_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = food_purchase_id;

            var id = dal.excuteCommand("DELETE_FOOD_PURCHASE", param, "food_purchase");
            dal.Close();

            return id;
        }
    }
}
