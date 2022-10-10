﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CarImage:IEntity
    {
        //Id,CarId,ImagePath,Date

        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }  //databasede ntext yaptık hadi bakam 
        public DateTime Date { get; set; }
    }
}
