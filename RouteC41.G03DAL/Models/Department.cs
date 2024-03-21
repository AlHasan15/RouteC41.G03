﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteC41.G03DAL.Models
{
    public class Department
    {
        
        public int Id { get; set; }
        
        public string Code { get; set; }
       
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
