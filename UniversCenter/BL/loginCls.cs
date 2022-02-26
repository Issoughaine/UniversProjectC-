using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace UniversCenter.BL
{
    class loginCls
    {
        public DataTable Login(string ID , string pwd)
        {
            DAL.Dal dataAccessLayer = new DAL.Dal();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@userName", SqlDbType.VarChar);
            param[0].Value = ID;

            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar);
            param[1].Value = pwd;

            dataAccessLayer.Open();
            DataTable dt = new DataTable();
            dt = dataAccessLayer.SelectData("sp_login", param);
            return dt;
        }
    }
}
