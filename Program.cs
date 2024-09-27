using exercEnums.Entities;
using exercEnums.Entities.Enums;
using System.Globalization;



Console.WriteLine("Enter cliente data:");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate =  DateTime.Parse(Console.ReadLine());

Client client = new Client(name, email, birthDate);

Console.WriteLine("Enter order data:");

Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

DateTime moment = DateTime.Now;
Order order = new Order(moment, status, client);

Console.Write("How many items to this order? ");
int items = int.Parse(Console.ReadLine());

for (int i = 1; i <= items; i++)
{
    Console.WriteLine($"Enter #{i} data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem item = new OrderItem(productQuantity, product);

    order.Items.Add(item);

}


Console.WriteLine();
Console.WriteLine("ORDER SUMMARY:");
Console.WriteLine(order);