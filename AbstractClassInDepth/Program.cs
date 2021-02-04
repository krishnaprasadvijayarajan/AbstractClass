using DemoLibrary;
using System;
using System.Collections.Generic;

namespace AbstractClassInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new()
            {
                new SqlDataAccess(),
                new SqlLiteDataAccess()
            };
            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("demo"));
                db.LoadData("SELECT * from TABLE");
                db.SaveData("SAVE TO TABLE");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
