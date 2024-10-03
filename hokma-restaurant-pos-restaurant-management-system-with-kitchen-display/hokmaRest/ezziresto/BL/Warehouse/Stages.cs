using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Warehouse
{
    class Stages
    {
        public void add_stage(string Name, string Description, int Rack_ID, string Status)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;

            param[1] = new SqlParameter("@Description", SqlDbType.NVarChar, 250);
            param[1].Value = Description;
            
            param[2] = new SqlParameter("@Status", SqlDbType.NVarChar, 250);
            param[2].Value = Status;

            param[3] = new SqlParameter("@Rack_ID", SqlDbType.Int);
            param[3].Value = Rack_ID;

            dal.excuteCommand("ADD_STAGES", param);
            dal.Close();
        }
    }
}
