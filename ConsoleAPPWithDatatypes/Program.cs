//Ask user to enter the Product Name
//Shortcut ----cw+hit tab key 2 times
//Commenting lines---ctrl+kc
//uncommenting Lines---ctrl+ku
//Format Code ctrl+KD
# region Datatypes
//Console.WriteLine("Enter The Product Name::");
////Implicitly Typed Variables
//var productName = Console.ReadLine();
////Console.WriteLine(productName);
////Accept price of the Product
//Console.WriteLine("Enter the Product Price::");
////Explicitly Typed Variables
//double productPrice = double.Parse(Console.ReadLine());
////Console.WriteLine(productPrice);
//Console.WriteLine($"ProductName:::{productName}\t ProductPrice:::{productPrice}");
#endregion

using ConsoleAPPWithDatatypes;

//Product product = new Product() {productId=1,productName="TV",price=100};
//Product product = new Product(1, "TV", 2000);
//Console.WriteLine($"ID::{product.productId}\t Name::{product.productName}\t Price::{product.price}");
//Invoke a method
//string productNameis=product.GetProductName();
//Console.WriteLine(productNameis);
//Console.WriteLine(product.GetProductName());
//Console.WriteLine(product.GetProductDetails(product));
#region OutParameter
//string productWithPrice;
//string productIdWithName;

//product.GetMultipleResults(product, out productWithPrice, out productIdWithName);
//Console.WriteLine(productWithPrice);
//Console.WriteLine(productIdWithName);
#endregion
#region Params
//string[] category = { "Electronics", "Mobile", "Clothes" };
//long mobileNumber = 123456678;
//string colour = "Red";

//product.PassOneorMoreValue(category);
//product.PassOneorMoreValue(mobileNumber);
//product.PassOneorMoreValue(colour);
#endregion


//compare product names if matches then print product exist else print product doesnotexist
//if (product.productName == "TV")
//{
//    Console.WriteLine();
//}
//else
//{
//    Console.WriteLine();
//}

#region ValueTypes
//int num1 = 10;
//int num2 = num1;
//Console.WriteLine("Values before Changing");
//Console.WriteLine($"The value of num1 is ::{num1}");//10
//Console.WriteLine($"the vanlue of num2 is ::{num2}");//10
//num2 = 100;
//Console.WriteLine("Values After Changing");
//Console.WriteLine($"The value of num1 is ::{num1}");//10
//Console.WriteLine($"the vanlue of num2 is ::{num2}");//100
#endregion
#region ReferenceTypes
//Console.WriteLine("Reference Types");
//Sample sampleObj1 = new Sample();
//Sample sampleObj2 = sampleObj1;
//Console.WriteLine(sampleObj1.width);//100
//Console.WriteLine(sampleObj2.width);//100
//sampleObj1.width = 500;
//Console.WriteLine("***************************");
//Console.WriteLine(sampleObj1.width);//500
//Console.WriteLine(sampleObj2.width);//500

#endregion


#region Operators
string productName = "Tv";
int productPrice = 80000;
int discount;
double gst = 0.18 * productPrice;
Console.WriteLine("eneter the Quantity::");
int quantity=int.Parse(Console.ReadLine());
//if (productPrice >= 80000)
//{
//    discount = 100;
//}
//else
//    discount = 0;
discount = productPrice >= 80000 ? 100 : 0;

double totalbill = (quantity * productPrice) - discount + gst;
Console.WriteLine($"Your Total bill is::{totalbill}");//
#endregion