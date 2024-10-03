using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Credit
{
    class Versemenet
    {

        public int InsertVeresement(decimal Montant, DateTime Date, int Credit_ID, string Note)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@Montant", SqlDbType.Real) { Value = Montant };
            Param[1] = new SqlParameter("@Date", SqlDbType.DateTime) { Value = Date };
            Param[2] = new SqlParameter("@Credit_ID", SqlDbType.Int) { Value = Credit_ID };
            Param[3] = new SqlParameter("@Note", SqlDbType.Text) { Value = Note };

            Param[4] = new SqlParameter("@Vers_ID", SqlDbType.Int);
            Param[4].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("InsertVeresement", Param, "veresement");
            dal.Close();

            return id;
        }

        public DataTable get_veresement_by_credit_id(int id)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Credit_ID", SqlDbType.Int);
            param[0].Value = id;

            dt = dal.SelectData("GET_VERSEMENTS_BY_CREDIT_ID", param);
            dal.Close();

            return dt;
        }
    }
}
