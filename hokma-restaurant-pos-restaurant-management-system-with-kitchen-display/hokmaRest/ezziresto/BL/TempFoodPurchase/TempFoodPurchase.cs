using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.TempFoodPurchase
{
    class TempFoodPurchase
    {
        public int add_temp_food_purchase(
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

            var id = dal.excuteCommand("ADD_TEMP_FOOD_PURCHASE", param, "food_purchase");
            dal.Close();

            return id;
        }

        public int add_temp_food_purchase_history(
            int branch_id,
            int food_purchase_id,
            int food_id,
            string food_name,
            int qty,
            decimal price,
            int rate,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[10];

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

            param[5] = new SqlParameter("@price", SqlDbType.Decimal);
            param[5].Value = price;

            param[6] = new SqlParameter("@rate", SqlDbType.Int);
            param[6].Value = rate;

            param[7] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[7].Value = created_at;

            param[8] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[8].Value = updated_at;

            param[9] = new SqlParameter("@id", SqlDbType.Int);
            param[9].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_TEMP_FOOD_PURCHASE_HISTORY", param, "food_purchase");
            dal.Close();

            return id;
        }

        public int delete()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = null;

            var id = dal.excuteCommand("DELETE_TEMP_PURCHASE_ORDER", param, "delete_temp_food_purchase");
            dal.Close();

            return id;
        }
    }
}
