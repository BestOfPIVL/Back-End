using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace FirstProject.DbLayer.POCOs
{
    [Table(Name = "Review")]
    public class Review_Data
    {
        [PrimaryKey, Identity]
        public int ID { get; set; }
        [Column(Name = "Author"), NotNull]
        public string Author { get; set; }
        [Column(Name = "Review")]
        public string Review { get; set; }
        [Column(Name = "Rating"), NotNull]
        public int Rating { get; set; }
    }
}
