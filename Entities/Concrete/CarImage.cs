using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        [Key]
        public int ImageId { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
