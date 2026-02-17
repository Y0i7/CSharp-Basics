/* Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-FR");

string first = "Hello";
string second = "World";

var textos = new string[]{"Hello","World","!"};
string result = string.Format("{0} {1}{2}", textos);
Console.WriteLine(result);

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N5} units");


 */

/* ACTIVITY

Debe crear el código para imprimir un recibo para que el cliente compre acciones de un 
producto de inversión. Las acciones se adquieren automáticamente al final del año en función 
de una serie de deducciones de nómina, por lo que el número de acciones compradas normalmente 
contiene un importe decimal. Para imprimir el recibo, es probable que tenga que combinar datos 
de diferentes tipos, incluidos los valores fraccionarios, la moneda y los porcentajes de manera 
precisa.
 */

using System.ComponentModel;

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-COL");

var invoiceNumber = 1201;
var productShares = 25.4568m;
var subtotal = 2750.00m;
var taxPercentage = .15825m;
var total = 3185.19m;


Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"\tShares: {productShares:N3} Product");
Console.WriteLine($"\t\tSub Total: {subtotal:C}");
Console.WriteLine($"\t\t\tTax: {taxPercentage:P2}");

var word = "Hola";
var result = word.PadLeft(word.Length + 2, '-')
                 .PadRight(word.Length + 4, '-');

Console.WriteLine(result);


string myWords = "Learning C#";
Console.WriteLine(myWords.PadLeft(12));

/* ACTIVITY
    Para promocionar los productos de inversión más recientes de esta empresa de ventas y 
    marketing, se envían miles de cartas personalizadas a los clientes existentes de dicha 
    empresa. El trabajo consiste en escribir código de C# para combinar información 
    personalizada sobre el cliente. La carta contiene información sobre su cartera existente 
    y compara sus rendimientos actuales con los rendimientos proyectados si invirtieran en 
    los nuevos productos.
*/
Console.ReadKey();
Console.Clear();

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-COL");

string customerName = "Ms. Barrios";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(10);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(10);

Console.WriteLine(comparisonMessage);