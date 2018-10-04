using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Data.DB
{
    public class DBUtil
    {
        private static DBUtil instance;
        public static DBUtil Instance => instance = instance ?? new DBUtil();
        private DBUtil() { }

        private String connectionString;
        public String ConnectionString => connectionString = connectionString ?? GetConnectionString();
        private String GetConnectionString()
        {
            var connectionBase = ConfigurationManager.ConnectionStrings["DapperConnection"].ToString();
            return connectionBase.Replace("@BasePath", AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}
