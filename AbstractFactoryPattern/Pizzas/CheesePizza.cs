using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Pizzas; 

public class CheesePizza : Pizza {
    private IPizzaIngredientFactory _ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory) {
        _ingredientFactory = ingredientFactory;
    }
    
    public override void Prepare() {
        Console.WriteLine($"Preparging {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}