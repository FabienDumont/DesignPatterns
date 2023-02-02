using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Pizzas; 

public class ClamPizza : Pizza {
    private IPizzaIngredientFactory _ingredientFactory;

    public ClamPizza(IPizzaIngredientFactory ingredientFactory) {
        _ingredientFactory = ingredientFactory;
    }
    
    public override void Prepare() {
        Console.WriteLine($"Preparging {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Clam = _ingredientFactory.CreateClam();
    }
}