using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Data.DB
{
    public class DapperConnection : IDisposable
    {
        private SqlConnection con;

        public DapperConnection()
        {
            con = new SqlConnection(DBUtil.Instance.ConnectionString);
            //con.Open();
        }

        public List<T> Query<T>(String sql, Object param = null) => con.Query<T>(sql, param: param).ToList();
        public void Execute(String sql, Object param = null) => con.Execute(sql, param: param);

        internal static List<T> DoQuery<T>(String sql, Object param = null) =>
            DapperFunction(db => db.Query<T>(sql, param: param));

        internal static void DoExecute(String sql, Object param = null) =>
            DapperAction(db => db.Execute(sql, param: param));

        internal static T DapperFunction<T>(Func<DapperConnection, T> func)
        {
            using (var db = new DapperConnection())
            {
                return func(db);
            }
        }
        internal static void DapperAction(Action<DapperConnection> action)
        {
            using (var db = new DapperConnection())
            {
                action(db);
            }
        }

        public void Dispose()
        {
            con?.Close();
            con?.Dispose();
        }
    }
}
