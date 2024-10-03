using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ezziresto.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        
        //this constructor initialise the connection object 
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Data Source=DESKTOP-5GVD81R\SA;Initial Catalog=ezziresto;Integrated Security=True");
        }

        // methode to open connection
        public void Open()
        {
            if(sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }


        // methode to close connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Methode to read Data from database
        public DataTable SelectData(string StoredProcedure, SqlParameter[] param = null)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = StoredProcedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Methode to read Data from database
        public string SelectSingleData(string StoredProcedure, SqlParameter[] param = null, string table = "")
        {
            string data;
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = StoredProcedure;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }

                sqlcmd.ExecuteNonQuery();

                data = sqlcmd.ExecuteScalar().ToString();

                return data;
            } catch(Exception e)
            {
                return null;
            }
        }
        //Methode to insert,Update and delete Data from database
        
        public int excuteCommand(string StoredProcedure, SqlParameter[] param,string table = "")
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = StoredProcedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();

            string id = "0";

            if (table == "credit")
                id = sqlcmd.Parameters["@Credit_ID"].Value.ToString();
            else if (table == "veresement")
                id = sqlcmd.Parameters["@Vers_ID"].Value.ToString();
            else if (table == "delete_temp_order")
                id = "0";
            else if (table == "delete_temp_ingredient_purchase")
                id = "0";
            else if (table == "delete_temp_food_purchase")
                id = "0";
            else if (table == "food_food_stock_qty")
                id = "0";
            else
                id = sqlcmd.Parameters["@id"].Value.ToString();
            
            return Convert.ToInt32(id);
        }
    }
}
