using AbstractFactoryPattern.Ingredients.Cheeses;
using AbstractFactoryPattern.Ingredients.Clams;
using AbstractFactoryPattern.Ingredients.Doughs;
using AbstractFactoryPattern.Ingredients.Pepperonis;
using AbstractFactoryPattern.Ingredients.Sauces;
using AbstractFactoryPattern.Ingredients.Veggies;

namespace AbstractFactoryPattern.Pizzas;

public abstract class Pizza {
    public string Name;
    protected IDough? Dough;
    protected ISauce? Sauce;
    protected IVeggie[]? Veggies;
    protected ICheese? Cheese;
    protected IPepperoni? Pepperoni;
    protected IClam? Clam;

    public abstract void Prepare();

    public void Bake() {
        Console.WriteLine($"Bake for 25 minutes at 350");
    }

    public virtual void Cut() {
        Console.WriteLine($"Cutting the pizza into diagonal slices");
    }

    public void Box() {
        Console.WriteLine($"Place pizza in official PizzaStore box");
    }

    public string GetDescription() {
        string result = string.Empty;
        result += $"---{Name}---";
        if (Dough != null) {
            result += $"{Dough.GetDescription()}";
        }

        if (Sauce != null) {
            result += $"{Sauce.GetDescription()}";
        }

        if (Cheese != null) {
            result += $"{Cheese.GetDescription()}";
        }

        if (Veggies != null) {
            for (int i = 0; i < Veggies.Length; i++) {
                result += $"{Veggies[i].GetDescription()}-";
                if (i < Veggies.Length - 1) {
                    result += ",";
                }
            }
        }
        
        if (Clam != null) {
            result += $"{Clam.GetDescription()}";
        }
        
        if (Pepperoni != null) {
            result += $"{Pepperoni.GetDescription()}";
        }

        return result;
    }
}