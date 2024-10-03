using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.WorkPeriods
{
    class WorkPeriods
    {

        public int add_work_periods(
            DateTime date,
            string branch_name,
            string started_by,
            DateTime started_at,
            DateTime ended_at,
            string ended_by,
            int branch_id,
            DateTime created_at,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@date", SqlDbType.DateTime);
            param[0].Value = date;

            param[1] = new SqlParameter("@branch_name", SqlDbType.NVarChar, 250);
            param[1].Value = branch_name;

            param[2] = new SqlParameter("@started_by", SqlDbType.NVarChar, 250);
            param[2].Value = started_by;

            param[3] = new SqlParameter("@started_at", SqlDbType.DateTime);
            param[3].Value = started_at;

            param[4] = new SqlParameter("@ended_at", SqlDbType.DateTime);
            param[4].Value = ended_at;

            param[5] = new SqlParameter("@ended_by", SqlDbType.NVarChar, 250);
            param[5].Value = ended_by;

            param[6] = new SqlParameter("@branch_id", SqlDbType.Int);
            param[6].Value = branch_id;

            param[7] = new SqlParameter("@created_at", SqlDbType.DateTime);
            param[7].Value = created_at;

            param[8] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[8].Value = updated_at;

            param[9] = new SqlParameter("@id", SqlDbType.Int);
            param[9].Direction = ParameterDirection.Output;

            var id = dal.excuteCommand("ADD_WORK_PERIODS", param, "work_periods");
            dal.Close();

            return id;
        }

        public int end_work_periods(
            int work_period_id,
            DateTime ended_at,
            string ended_by,
            DateTime updated_at
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = work_period_id;

            param[1] = new SqlParameter("@ended_at", SqlDbType.DateTime);
            param[1].Value = ended_at;

            param[2] = new SqlParameter("@ended_by", SqlDbType.NVarChar, 250);
            param[2].Value = ended_by;

            param[3] = new SqlParameter("@updated_at", SqlDbType.DateTime);
            param[3].Value = updated_at;

            var id = dal.excuteCommand("END_WORK_PERIODS", param, "work_periods");
            dal.Close();

            return id;
        }
    }
}
