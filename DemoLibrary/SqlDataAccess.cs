using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class SqlDataAccess : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQL String");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving SQL String"); 
        }
    }
}
