﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDbApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
        public virtual ICollection<CarShop> Shop { get; set; }
        public Customer()
        {

        }
        public Customer(string line)
        {
            string[] split = line.Split('#');
            CustomerId = int.Parse(split[0]);
            Age = int.Parse(split[1]);
            Name = split[2];
            Address = split[3];
        }
    }
}