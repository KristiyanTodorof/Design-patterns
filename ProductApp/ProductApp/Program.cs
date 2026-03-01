using ProductApp.Factory_Method;
using ProductApp.Mediator;
using ProductApp.Memento;
using ProductApp.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Стартиране на приложението за продукти...");
Console.WriteLine("-------------------------------------");

ProductFactory productFactory = new ProductFactory();
DeliveryService deliveryService = new DeliveryService();
Cart cart = new Cart();

ProductSystemMediator mediator = new ProductSystemMediator(productFactory, deliveryService, cart);

Client client = new Client("Иван Петров");
Console.WriteLine($"Клиент: {client.GetName()}");
Console.WriteLine("-------------------------------------");

Console.WriteLine("Клиентът избира продукт A със син цвят...");
mediator.RequestProductCreation("A", "син", client);
Console.WriteLine("-------------------------------------");

Console.WriteLine("Клиентът избира продукт B с червен цвят...");
mediator.RequestProductCreation("B", "червен", client);
Console.WriteLine("-------------------------------------");

List<IProduct> orderedProducts = new List<IProduct>
            {
                productFactory.CreateProduct("A"),
                productFactory.CreateProduct("B")
            };
orderedProducts[0].SetColor("син");
orderedProducts[1].SetColor("червен");

mediator.RegisterOrder(orderedProducts, client);
Console.WriteLine("Поръчката е регистрирана и запазена в кошницата.");
Console.WriteLine("-------------------------------------");

Console.WriteLine("История на поръчките:");
var orderHistory = cart.GetOrderHistory(client);

for (int i = 0; i < orderHistory.Count; i++)
{
    var memento = orderHistory[i];
    Console.WriteLine($"Поръчка #{i + 1}:");
    Console.WriteLine($"Дата на поръчка: {memento.GetOrderDate()}");
    Console.WriteLine($"Обща цена: {memento.GetTotalPrice():F2} лв.");
    Console.WriteLine("Продукти:");
    foreach (var product in memento.GetProducts())
    {
        Console.WriteLine($"- {product.GetType()} ({product.GetColor()}) - {product.GetPrice():F2} лв.");
    }
    Console.WriteLine("--------------------");
}

Console.WriteLine("Клиентът избира продукт C със зелен цвят...");
mediator.RequestProductCreation("C", "зелен", client);
Console.WriteLine("-------------------------------------");

List<IProduct> newOrderedProducts = new List<IProduct>
            {
                productFactory.CreateProduct("C")
            };
newOrderedProducts[0].SetColor("зелен");

mediator.RegisterOrder(newOrderedProducts, client);
Console.WriteLine("Нова поръчка е регистрирана и запазена в кошницата.");
Console.WriteLine("-------------------------------------");

// Показване на актуализираната история на поръчките
Console.WriteLine("Актуализирана история на поръчките:");
var updatedOrderHistory = cart.GetOrderHistory(client);

for (int i = 0; i < updatedOrderHistory.Count; i++)
{
    var memento = updatedOrderHistory[i];
    Console.WriteLine($"Поръчка #{i + 1}:");
    Console.WriteLine($"Дата на поръчка: {memento.GetOrderDate()}");
    Console.WriteLine($"Обща цена: {memento.GetTotalPrice():F2} лв.");
    Console.WriteLine("Продукти:");
    foreach (var product in memento.GetProducts())
    {
        Console.WriteLine($"- {product.GetType()} ({product.GetColor()}) - {product.GetPrice():F2} лв.");
    }
    Console.WriteLine("--------------------");
}

Console.WriteLine("Приложението завърши успешно.");
Console.ReadLine();
