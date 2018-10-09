using FirstProject.DbLayer.POCOs;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    public class ConectionClass : LinqToDB.Data.DataConnection
    {
        public ConectionClass() : base("Data_Base_One") { }
        public ITable<FileData> FileData => GetTable<FileData>();
        public ITable<Admin_Data> Admin_Data => GetTable<Admin_Data>();
        public ITable<Review_Data> Review_Data => GetTable<Review_Data>();
    }
}
