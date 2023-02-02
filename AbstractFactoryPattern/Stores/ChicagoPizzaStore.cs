using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Pizzas;

namespace AbstractFactoryPattern.Stores; 

public class ChicagoPizzaStore : PizzaStore {
    public override Pizza? CreatePizza(string type) {
        Pizza? pizza = null;
        IPizzaIngredientFactory ingredientfactory = new ChicagoPizzaIngredientFactory();
        
        if (type.Equals("cheese")) {
            pizza = new CheesePizza(ingredientfactory);
            pizza.Name = "Chicago Style Cheese Pizza";
        } else if (type.Equals("veggie")) {
            pizza = new VeggiePizza(ingredientfactory);
            pizza.Name = "Chicago Style Veggie Pizza";
        }else if (type.Equals("clam")) {
            pizza = new ClamPizza(ingredientfactory);
            pizza.Name = "Chicago Style Clam Pizza";
        } else if (type.Equals("pepperoni")) {
            pizza = new PepperoniPizza(ingredientfactory);
            pizza.Name = "Chicago Style Pepperoni Pizza";
        }

        return pizza;
    }
}