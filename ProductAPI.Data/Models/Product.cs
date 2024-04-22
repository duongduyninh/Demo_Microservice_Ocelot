﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string ProductName { get; set; }
        public string Description { get; set; }

    }
}
