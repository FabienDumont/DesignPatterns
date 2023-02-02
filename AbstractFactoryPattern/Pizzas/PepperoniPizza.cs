using AbstractFactoryPattern.Factories;

namespace AbstractFactoryPattern.Pizzas; 

public class PepperoniPizza : Pizza {
    private IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) {
        _ingredientFactory = ingredientFactory;
    }
    
    public override void Prepare() {
        Console.WriteLine($"Preparging {Name}");
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veggies = _ingredientFactory.CreateVeggies();
        Pepperoni = _ingredientFactory.CreatePepperoni();
    }
}