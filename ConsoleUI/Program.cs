using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //Console.WriteLine(carManager.GetCarById(5).Data.CarName + "  "+carManager.GetCarById(5).Message);


            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //9 u daha önce eklediğim için boyle yaptım
            //Brand brand1 = new Brand();
            //brand1.Id = 10;
            //brand1.Name = "Jaguar"; 

            //Console.WriteLine(brandManager.Add(brand1).Message);
            
            //foreach (var brand in brandManager.GetAll().Data)
            //{
            //    Console.WriteLine(brand.Name);
            //}

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //Console.WriteLine(colorManager.GetColorById(5).Data.Name);

            //Console.WriteLine("*********************************");

            //foreach (var color in colorManager.GetAll().Data)
            //{
            //    Console.WriteLine(color.Name);
            //}
            //Console.WriteLine(colorManager.GetAll().Message);



        }
    }
}

