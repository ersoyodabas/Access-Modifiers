using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAssembly
{
   public class Product
    {
        int Id { get; set; }
        private string Name { get; set; }

        public int Count { get; set; }
        public static string Currency{ get; set; }
        static string Picture { get; set; }

        protected double Price { get; set; }
        protected internal string Path { get; set; }
        internal string Origin { get; set; }    

    }
    public class AnotherProduct
    {
        Product product = new Product();

        void setValues()
        {

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

        }

    }

    public class AnotherProduct2 : Product
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


    public static class AnotherProduct3 
    {
        public static int Id { get; set; }
    }
}
