﻿using DBWorkLibraries.Context;

namespace DBWorkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-NBEJJSO; Database = Test; Trusted_Connection = True; Encrypt = False ";
            
            ApplicationContext appContext = new ApplicationContext(connectionString);          
        }
    }
}