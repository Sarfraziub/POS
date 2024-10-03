using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ezziresto.BL.Warehouse
{
    class Warehouse
    {
        public void add_Warehouse(string Name, string Address, byte[] Image, int City_ID, int Comm_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Address", SqlDbType.NVarChar, 250);
            param[1].Value = Address;

            param[2] = new SqlParameter("@Image", SqlDbType.Image);
            param[2].Value = Image;

            param[3] = new SqlParameter("@City_ID", SqlDbType.Int);
            param[3].Value = City_ID;

            param[4] = new SqlParameter("@Comm_ID", SqlDbType.Int);
            param[4].Value = Comm_ID;

            dal.excuteCommand("ADD_WAREHOUSE", param);
            dal.Close();
        }
    }
}
