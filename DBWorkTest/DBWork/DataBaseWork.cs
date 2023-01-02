using DBWorkLibraries.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBWorkTest.DBWork
{
    internal class DataBaseWork
    {
        public string ConnectionString { get; }
        public DataBaseWork(string connectionString)
        {
            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                ConnectionString = connectionString;
            }
            else
            {
                throw new Exception("ConnectionString IsNullOrWhiteSpace");
            }
        }
        public bool DataBaseCreated()
        {
            using (var appContext = new ApplicationContext(ConnectionString))
            {
                return appContext.Database.EnsureCreated();
            }
        }

    }
}
