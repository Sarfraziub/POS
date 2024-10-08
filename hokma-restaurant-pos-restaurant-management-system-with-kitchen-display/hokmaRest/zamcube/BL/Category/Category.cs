﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ezziresto.BL.Category
{
    class Category
    {
        public void add_category(string Name,byte[] Image, string Tax)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 250);
            param[0].Value = Name;
            
            param[1] = new SqlParameter("@Image", SqlDbType.Image);
            param[1].Value = Image;

            param[2] = new SqlParameter("@Tax", SqlDbType.NVarChar, 250);
            param[2].Value = Tax;

            dal.excuteCommand("ADD_CATEGORY", param);
            dal.Close();

        }
    }
}
