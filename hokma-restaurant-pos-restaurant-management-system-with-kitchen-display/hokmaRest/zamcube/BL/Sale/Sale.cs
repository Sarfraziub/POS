using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Sale
{
    class Sale
    {
        public DataTable get_sales(int client_id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Cust_ID", SqlDbType.Int);
            param[0].Value = client_id;

            dt = dal.SelectData("GET_SALES_BY_CLIENT_ID", param);
            dal.Close();

            return dt;
        }

        public string get_sales_total()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@total", SqlDbType.Real);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_SALES_TOTAL_PRICE", param, "total_price");
            dal.Close();

            return id;
        }

        public string get_products_total_price(int order_id)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Sale_ID", SqlDbType.Int);
            param[0].Value = order_id;

            param[1] = new SqlParameter("@total", SqlDbType.Real);
            param[1].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_PRODUCTS_SALE_TOTAL_PRICE", param, "total_price");
            dal.Close();

            return id;
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

        public string get_last_id()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Sale_ID", SqlDbType.Int);
            param[0].Direction = ParameterDirection.Output;

            var id = dal.SelectSingleData("GET_LAST_SALE_ID", param);
            dal.Close();

            return id;
        }

        public DataTable get_sale(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Sale_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_SALE", param);
            dal.Close();

            return dt;
        }

        public DataTable get_sale_products(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Sale_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_SALE_PRODUCTS", param);
            dal.Close();

            return dt;
        }
    }
}
