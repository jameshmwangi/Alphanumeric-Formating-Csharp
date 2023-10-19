/*// string first = "USD";
// string second= "KES";
// string result =string.Format("{1} to {1}!",first,second);
// Console.WriteLine(result);

//String Interpolation

string first = "USD";
string second = "Kes";
Console.WriteLine($"{first} to {second}!");
Console.WriteLine($"{second} to {first}!");
Console.WriteLine($"{first} to {first} {first}!");

// formating currency
decimal price =4999999.87m;
int discount =50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
Console.WriteLine($"Price: KES {price:N1}");

decimal Bitcoin = .36785m;
Console.WriteLine($"Bitcoin rate: {Bitcoin:P2}");


// 
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; 
Console.WriteLine(yourDiscount);

*/

// int invoiceNumber =1201;
// decimal productShares = 25.4568m;
// decimal subtotal =2750.00m;
// decimal taxPercentage= .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"\tShares :{productShares:N3} Product");
// Console.WriteLine($"\tSubtotal :{subtotal:C}");
// Console.WriteLine($"\tTax:{taxPercentage:P2}");
// Console.WriteLine($"\tTotal Billed:{total:C}");

// An exercise to practise formating

string customerName = "Ms. Wambui";
string currentProduct = "Magic Yield";
int currentShares=2975000;
decimal currentReturn= 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");

Console.WriteLine($"Currently, you own {currentShares:N} at a return rate of {currentReturn:P2}" );
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");

Console.WriteLine("Here's a quick comparison:\n");
string comparisonMessage ="";
comparisonMessage =currentProduct.PadRight(20);
comparisonMessage+= string.Format("{0:P}",currentReturn).PadRight(10);
comparisonMessage+= string.Format("{0:C}",currentProfit).PadRight(10);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);
Console.WriteLine(comparisonMessage);