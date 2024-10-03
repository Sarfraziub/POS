using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Credit
{
    class Credit
    {
        
        public int InsertCredit(int Supp_ID, string Type_Credit, string Etat, Decimal Montant, string Methode, DateTime Date, string Notes)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] Param = new SqlParameter[8];

            Param[0] = new SqlParameter("@Supp_ID", SqlDbType.Int) { Value = Supp_ID };
            Param[1] = new SqlParameter("@Type_Credit", SqlDbType.NVarChar) { Value = Type_Credit };
            Param[2] = new SqlParameter("@Etat", SqlDbType.NVarChar) { Value = Etat };
            Param[3] = new SqlParameter("@Montant", SqlDbType.Real) { Value = Montant };
            Param[4] = new SqlParameter("@Methode", SqlDbType.NVarChar) { Value = Methode };
            Param[5] = new SqlParameter("@Date", SqlDbType.Date) { Value = Date };
            Param[6] = new SqlParameter("@Notes", SqlDbType.Text) { Value = Notes };

            Param[7] = new SqlParameter("@Credit_ID", SqlDbType.Int);
            Param[7].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("InsertCredit", Param, "credit");
            dal.Close();

            return id;
        }

        public DataTable get_credit(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Credit_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_CREDIT", param);
            dal.Close();

            return dt;
        }

        public string get_remaining_amount(int Credit_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Credit_ID", SqlDbType.Int);
            param[0].Value = Credit_ID;

            param[1] = new SqlParameter("@total", SqlDbType.Real);
            param[1].Direction = ParameterDirection.Output;

            var value = dal.SelectSingleData("GET_REMAINING_AMOUNT", param, "remaining_amount");
            dal.Close();

            return value;
        }

        public DataTable get_credit_by_cust_id(int id,string Paid)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Supp_ID", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Paid", SqlDbType.NVarChar,250);
            param[1].Value = Paid;

            dt = dal.SelectData("GET_CREDIT_BY_CUST_ID", param);
            dal.Close();

            return dt;
        }
    }
}
