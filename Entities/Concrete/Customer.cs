﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;



namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}