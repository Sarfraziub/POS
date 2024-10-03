using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ezziresto.BL.CustommerType
{
    class CustommerType
    {
        public void add_Type(string Type)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 250);
            param[0].Value = Type;

            dal.excuteCommand("ADD_CUSTOMMER_TYPE", param);
            dal.Close();
        }
    }
}
