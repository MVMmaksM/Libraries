using DBWorkLibraries.Context;
using DBWorkLibraries.Entities;

namespace DBWorkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-NBEJJSO; Database = Test; Trusted_Connection = True; Encrypt = False ";

            ApplicationContext appContext = new ApplicationContext(connectionString);

            Detail detail = new Detail { Title = "sdfdsf", FullName = "dsfsdf", Contours = new byte[5] };

            //appContext.Detail.Add(detail);

            //appContext.SaveChanges();
        }
    }
}