using AnotherAssembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();

            //PRIVATE
            product.Id = 1;
            product.Name = 'A';

            //PUBLIC
            product.Count = 1;
            
            //PUBLIC STATIC
            product.Currency = "TL";
            
            //STATIC
            product.Picture = "a.jpg";

            //PROTECTED
            product.Price = 10;


            //PROTECTED INTERNAL
            product.Path = "/a/b/";

            //INTERNAL
            product.Origin = "TR";


            //PUBLIC STATIC
            AnotherProduct3.Id = 10;

            //STATIC
            AnotherProduct4.Id = 10;

            //STATIC
            AnotherProduct5.Id = 10;

        }
    }

    class Testx : Product
    {
        void setValues()
        {

            //PRIVATE
            Id = 1;
            Name = 'A';

            //PUBLIC
            Count = 1;

            //PUBLIC STATIC
            Currency = "TL";

            //STATIC
            Picture = "a.jpg";

            //PROTECTED
            Price = 10;

            //PROTECTED INTERNAL
            Path = "/a/b/";

            //INTERNAL
            Origin = "TR";

        }


    }

    static class AnotherProduct4
    {
        static int Id { get; set; }
    }

    static class AnotherProduct5
    {
        public static int Id { get; set; }
    }
}
