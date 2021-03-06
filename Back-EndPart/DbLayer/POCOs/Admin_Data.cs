﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace FirstProject.DbLayer.POCOs
{
    [Table(Name ="Admins")]
    public class Admin
    {
        [PrimaryKey, Identity]
        public Guid ID { get; set; }
        [Column(Name = "Username"), NotNull]
        public string Username { get; set; }
        [Column(Name = "Password"), NotNull]
        public string Password { get; set; }
        [Column(Name = "Status"), NotNull]
        public string Status { get; set; }
        [Column(Name = "Faculty"), NotNull]
        public string Faculty { get; set; }
        [Column(Name = "Specialty"), NotNull]
        public string Specialty { get; set; }
        [Column(Name = "Admission_Year")]
        public DateTime Admission_Year { get; set; }
        [Column(Name = "Mail"), NotNull]
        public string Mail { get; set; }
    }
}
