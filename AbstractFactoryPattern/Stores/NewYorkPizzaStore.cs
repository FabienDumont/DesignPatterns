using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Pizzas;

namespace AbstractFactoryPattern.Stores; 

public class NewYorkPizzaStore : PizzaStore {
    public override Pizza? CreatePizza(string type) {
        Pizza? pizza = null;
        IPizzaIngredientFactory ingredientfactory = new NewYorkPizzaIngredientFactory();
        
        if (type.Equals("cheese")) {
            pizza = new CheesePizza(ingredientfactory);
            pizza.Name = "New York Style Cheese Pizza";
        } else if (type.Equals("veggie")) {
            pizza = new VeggiePizza(ingredientfactory);
            pizza.Name = "New York Style Veggie Pizza";
        }else if (type.Equals("clam")) {
            pizza = new ClamPizza(ingredientfactory);
            pizza.Name = "New York Style Clam Pizza";
        } else if (type.Equals("pepperoni")) {
            pizza = new PepperoniPizza(ingredientfactory);
            pizza.Name = "New York Style Pepperoni Pizza";
        }

        return pizza;
    }
}