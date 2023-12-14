using OutAndRefKeyword;

Calculator calculator = new Calculator();
# region OutKeyword
//int total;
//int multiply;
//calculator.Calculation(10, 20, out total, out multiply);
//Console.WriteLine($"Sum is ::{total}");
//Console.WriteLine($"Product is ::{multiply}");
# endregion

//ref keyword
int total=0;
int multiply=0;
calculator.Calculation(20, 10, ref total, ref multiply);
Console.WriteLine($"Sum is ::{total}");
Console.WriteLine($"Product is ::{multiply}");
