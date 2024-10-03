using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ezziresto.BL.Setting
{
    class Setting
    {
        public DataTable get_setting_by_id(int setting_id = 30)
        {
            DataTable dt = new DataTable();

            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = setting_id;

            dt = dal.SelectData("GET_SETTING_BY_ID", param);
            dal.Close();

            return dt;
        }

        public int update_setting(
            int setting_id,
            string company,
            string tell,
            string phone,
            string email,
            string address,
            byte[] logo,
            string lang,
            string account_n,
            string bank,
            string swift_code,
            string card_payment,
            string point_money,
            string sound
            )
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 250);
            param[0].Value = setting_id;

            param[1] = new SqlParameter("@company", SqlDbType.NVarChar, 250);
            param[1].Value = company;

            param[2] = new SqlParameter("@tell", SqlDbType.NVarChar, 250);
            param[2].Value = tell;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 250);
            param[3].Value = phone;

            param[4] = new SqlParameter("@email", SqlDbType.NVarChar, 250);
            param[4].Value = email;

            param[5] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[5].Value = address;

            param[6] = new SqlParameter("@logo", SqlDbType.Image);
            param[6].Value = logo;

            param[7] = new SqlParameter("@lang", SqlDbType.NVarChar, 250);
            param[7].Value = lang;

            param[8] = new SqlParameter("@account_n", SqlDbType.NVarChar, 250);
            param[8].Value = account_n;

            param[9] = new SqlParameter("@bank", SqlDbType.NVarChar, 250);
            param[9].Value = bank;

            param[10] = new SqlParameter("@swift_code", SqlDbType.NVarChar, 250);
            param[10].Value = swift_code;

            param[11] = new SqlParameter("@card_payment", SqlDbType.NVarChar, 250);
            param[11].Value = card_payment;

            param[12] = new SqlParameter("@point_money", SqlDbType.NVarChar, 250);
            param[12].Value = point_money;

            param[13] = new SqlParameter("@sound", SqlDbType.NVarChar, 250);
            param[13].Value = sound;

            var id = dal.excuteCommand("UPDATE_SETTINGS", param, "setting");
            dal.Close();

            return id;
        }
    }
}
