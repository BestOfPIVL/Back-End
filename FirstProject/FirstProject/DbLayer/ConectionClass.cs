using FirstProject.DbLayer.POCOs;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    public class FilesharingConnection : LinqToDB.Data.DataConnection
    {
        public FilesharingConnection() : base("Data_Base_One") { }
        public ITable<FileData> FileData => GetTable<FileData>();
        public ITable<Admin> Admins => GetTable<Admin>();
        public ITable<Review> Reviews => GetTable<Review>();
    }
}
