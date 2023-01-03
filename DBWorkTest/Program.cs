using DBWorkLibraries.Context;
using DBWorkLibraries.Entities;
using DBWorkTest.DBWork;
using System.Text;

namespace DBWorkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-NBEJJSO; Database = Test4; Trusted_Connection = True; Encrypt = False ";

            DataBaseWork dbWork = new DataBaseWork(connectionString);

            //byte[] bytes = Encoding.ASCII.GetBytes(connectionString);

            //ICollection<Detail> details = new List<Detail>()
            //{
            //    new Detail() {Title = "Шестеренка", FullName = "Шестеренка распредвала", Contours = bytes },
            //    new Detail() {Title = "Шпилька", FullName = "Шпилька распредвала", Contours = bytes },
            //    new Detail() {Title = "Распредвал", FullName = "Распредвал для КЗКТ", Contours = bytes },
            //    new Detail() {Title = "Коленвал", FullName = "Коленвал Т-150", Contours = bytes },
            //};


           //var res = dbWork.SearchDetail(d=>d.Id==1);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Id.ToString());
            //    Console.WriteLine(item.Title);
            //}

            //Console.WriteLine(dbWork.InsertDetail(details));
            //string sqlQuery = "SELECT * FROM Detail";

            //var result = dbWork.SelectSqlFromDetail(sqlQuery);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Название детали: {item.Title}");
            //    Console.WriteLine($"Описание детали: {item.FullName}");
            //    Console.WriteLine();
            //}
        }
    }
}