using Microsoft.EntityFrameworkCore;

namespace DBWorkLibraries.Context
{
    internal class AppContext:DbContext
    {
        private string _connectionString;

        public AppContext(string connectionString)
        {
            _connectionString= connectionString;
        }


    }
}
