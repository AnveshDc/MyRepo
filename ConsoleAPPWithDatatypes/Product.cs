namespace ConsoleAPPWithDatatypes
{
    internal class Product
    {
        //Fields or Variables
        public int productId;
        //making field as a static
        public string productName;
        public double price;

        //ctor+2times tab key
        //constructor
        public Product(int productId,string name,double productPrice)
        {
            this.productId = productId;
            productName=name;
            price= productPrice;
        }

        //gets and prints the productname to the console
        //declare and implement a method
       internal string GetProductName()
        {
            //Console.WriteLine($"Name of the Product is:: {productName}");
            return productName;
        }

        internal string GetProductDetails(Product product)
        {
          return  $"ID::{product.productId}\t Name::{product.productName}\t Price::{product.price}";
        }

        internal void GetMultipleResults(Product product,out string productNameWithPrice, out string productIdWithName)
        {
            productNameWithPrice = productName + price;
            productIdWithName = productId + productName;
        }

        internal void PassOneorMoreValue(params object[] category)
        {
            foreach (object categoryItem in category)
            {
                Console.WriteLine(categoryItem);
            }
        }
    }
}
