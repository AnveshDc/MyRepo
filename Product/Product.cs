namespace ProductLibrary
{
    public class Product
    {
        //fields
        public int id;
        public string name;
        public string category;


        //constructor

        public Product(int id, string name, string category)
        {
            this.id= id;
            this.name= name;
            this.category= category;
        }
        //Method
        public string GetProductDetails()
        {
            return $"Id::{id}\t Name::{name}\t Category::{category}";
        }

        public override string ToString()
        {
            return $"Id::{ id}\t Name::{ name}\t Category::{ category}";

        }


    }
}