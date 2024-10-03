using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ezziresto.BL.Variation
{
    class Variation
    {

        public DataTable get_variation(int variation_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = variation_id;

            dt = dal.SelectData("GET_VARIATION_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int add_variation(
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

            var id = dal.excuteCommand("ADD_VARIATION", param, "variation");
            dal.Close();

            return id;
        }

        public int update_variation(
            int variation_id,
            string Name,
            string slug,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = variation_id;

            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[1].Value = Name;

            param[2] = new SqlParameter("@slug", SqlDbType.NVarChar, 250);
            param[2].Value = slug;

            param[3] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[3].Value = updated_at;

            var id = dal.excuteCommand("UPDATE_VARIATION", param, "variation");
            dal.Close();

            return id;
        }

        public int delete(
            int variation_id
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = variation_id;

            var id = dal.excuteCommand("DELETE_VARIATION", param, "variation");
            dal.Close();

            return id;
        }

        public int update_product_price_selected(
            int Pro_ID,
            int Price_ID
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[0].Value = Pro_ID;

            param[1] = new SqlParameter("@Price_ID", SqlDbType.Int);
            param[1].Value = Price_ID;

            var id = dal.excuteCommand("UPDATE_PRODUCT_PRICE_SELECTED", param);
            dal.Close();

            return id;
        }

        public void add_Product_Price(
            int Qty,
            Decimal Buy_Price,
            Decimal Sale_Price_1,
            Decimal Sale_Price_2,
            Decimal Sale_Price_3,
            int Pro_ID
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Qty", SqlDbType.Int);
            param[0].Value = Qty;

            param[1] = new SqlParameter("@Buy_Price", SqlDbType.Decimal);
            param[1].Value = Buy_Price;

            param[2] = new SqlParameter("@Sale_Price_1", SqlDbType.Decimal);
            param[2].Value = Sale_Price_1;

            param[3] = new SqlParameter("@Sale_Price_2", SqlDbType.Decimal);
            param[3].Value = Sale_Price_2;

            param[4] = new SqlParameter("@Sale_Price_3", SqlDbType.Decimal);
            param[4].Value = Sale_Price_3;

            param[5] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[5].Value = Pro_ID;

            dal.excuteCommand("ADD_PRODUCT_PRICE", param);
            dal.Close();
        }

        public void add_Product_Barcode(
            string Barcode,
            int Pro_ID
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Barcode", SqlDbType.NVarChar, 250);
            param[0].Value = Barcode;

            param[1] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[1].Value = Pro_ID;

            dal.excuteCommand("ADD_PRODUCT_BARCODE", param);
            dal.Close();
        }

        public void add_Product_to_warehouse(
            int Qty,
            int Et_ID,
            int Pro_ID
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Qty", SqlDbType.Int);
            param[0].Value = Qty;

            param[1] = new SqlParameter("@Et_ID", SqlDbType.Int);
            param[1].Value = Et_ID;

            param[2] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[2].Value = Pro_ID;

            dal.excuteCommand("ADD_PRODUCT_TO_WAREHOUSE", param);
            dal.Close();
        }

        public int add_Product_order(
            int Sup_ID,
            DateTime Date
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Sup_ID", SqlDbType.Int);
            param[0].Value = Sup_ID;

            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;

            param[2] = new SqlParameter("@Qty", SqlDbType.Int);
            param[2].Value = 0;

            param[3] = new SqlParameter("@Total_price", SqlDbType.Real);
            param[3].Value = 0;

            param[4] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[4].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_PRODUCT_ORDER", param, "order");
            dal.Close();

            return id;
        }

        public void add_Product_order_details(
                int Order_ID,
                int Pro_ID,
                DateTime Date,
                int Qty,
                Decimal Price,
                string User_Name
                )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Order_ID", SqlDbType.Int);
            param[0].Value = Order_ID;

            param[1] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[1].Value = Pro_ID;

            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Date;

            param[3] = new SqlParameter("@Qty", SqlDbType.Int);
            param[3].Value = Qty;

            param[4] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[4].Value = Price;

            param[5] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 250);
            param[5].Value = User_Name;

            dal.excuteCommand("ADD_PRODUCT_ORDER_DETAILS", param);
            dal.Close();
        }

        public int add_Product_sale(
            int Cust_ID,
            DateTime Date
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Cust_ID", SqlDbType.Int);
            param[0].Value = Cust_ID;

            param[1] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[1].Value = Date;

            param[2] = new SqlParameter("@Qty", SqlDbType.Int);
            param[2].Value = 0;

            param[3] = new SqlParameter("@Total_price", SqlDbType.Real);
            param[3].Value = 0;

            param[4] = new SqlParameter("@Sale_ID", SqlDbType.Int);
            param[4].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_PRODUCT_SALE", param, "sale");
            dal.Close();

            return id;
        }

        public void add_Product_sale_details(
                int Sale_ID,
                int Pro_ID,
                DateTime Date,
                int Qty,
                Decimal Price,
                string User_Name
                )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Sale_ID", SqlDbType.Int);
            param[0].Value = Sale_ID;

            param[1] = new SqlParameter("@Pro_ID", SqlDbType.Int);
            param[1].Value = Pro_ID;

            param[2] = new SqlParameter("@Date", SqlDbType.DateTime);
            param[2].Value = Date;

            param[3] = new SqlParameter("@Qty", SqlDbType.Int);
            param[3].Value = Qty;

            param[4] = new SqlParameter("@Price", SqlDbType.Decimal);
            param[4].Value = Price;

            param[5] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 250);
            param[5].Value = User_Name;

            dal.excuteCommand("ADD_PRODUCT_SALE_DETAILS", param);
            dal.Close();
        }
    }
}
