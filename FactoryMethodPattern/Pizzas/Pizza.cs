namespace FactoryMethodPattern.Pizzas;

public abstract class Pizza {
    public string Name;
    protected string Dough;
    protected string Sauce;
    protected List<string> Toppings = new();

    public void Prepare() {
        Console.WriteLine($"Preparing {Name}");
        Console.WriteLine($"Tossing dough...");
        Console.WriteLine($"Adding sauce...");
        Console.WriteLine($"Adding toppings: ");
        foreach (string topping in Toppings) {
            Console.WriteLine($"   {topping}");
        }
    }

    public void Bake() {
        Console.WriteLine($"Bake for 25 minutes at 350");
    }

    public virtual void Cut() {
        Console.WriteLine($"Cutting the pizza into diagonal slices");
    }

    public void Box() {
        Console.WriteLine($"Place pizza in official PizzaStore box");
    }
}