using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class SqlLiteDataAccess:DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += "(from SQL Lite)";
            return output;
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQL Lite String");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving SQL Lite String");
        }
    }
}
