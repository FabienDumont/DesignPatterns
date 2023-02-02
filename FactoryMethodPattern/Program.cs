using FactoryMethodPattern.Pizzas;
using FactoryMethodPattern.Stores;

PizzaStore nyStore = new NewYorkPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza.Name}");