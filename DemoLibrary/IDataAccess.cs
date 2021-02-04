using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public interface IDataAccess
    {
        public string LoadConnectionString(string name);
        public void LoadData(string sql);
        public void SaveData(string sql);
    }
}
