using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace FirstProject.DbLayer.POCOs
{
    [Table(Name = "FileData")]
    public class FileData
    {
        [PrimaryKey, Identity]
        public Guid ID { get; set; }
        [Column(Name = "File_Name"), NotNull]
        public string File_Name { get; set; }
        [Column(Name = "Teacher"), NotNull]
        public string Teacher { get; set; }       
        [Column(Name = "Description")]
        public string Description { get; set; }
        [Column(Name = "Rating"), NotNull]
        public double Rating { get; set; }
        [Column(Name = "Review")]
        public string Review { get; set; }
        [Column(Name = "Type"), NotNull]
        public string Type { get; set; }
        [Column(Name = "Extension"), NotNull]
        public string Extension { get; set; }
        [Column(Name = "Date_Of_Download"), NotNull]
        public DateTime Date_of_Download { get; set; }

    }
}
