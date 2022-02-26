using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UniversCenter.DAL
{
    class Dal
    {
        SqlConnection cn;
        public Dal()
        {
            cn = new SqlConnection(@"Data Source=DESKTOP-J0NF284\SQLEXPRESS;Initial Catalog=universDB;Integrated Security=True;");
        }
        public void Open()
        {
            if(cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }
        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        public DataTable SelectData(string stored_procedure , SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            if(param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExecuteCommand(string stored_procedure , SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
