using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Auth
{
    class Auth
    {
        public DataTable login(string email, string password)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[0].Value = email;

            param[1] = new SqlParameter("@password", SqlDbType.NVarChar, 250);
            param[1].Value = password;

            dt = dal.SelectData("AUTH_LOGIN", param);
            dal.Close();

            return dt;
        }
    }
}
