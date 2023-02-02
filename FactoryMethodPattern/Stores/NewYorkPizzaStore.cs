using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.Stores; 

public class NewYorkPizzaStore : PizzaStore {
    public override Pizza? CreatePizza(string type) {
        Pizza? pizza = null;
        
        if (type.Equals("cheese")) {
            pizza = new NewYorkStyleCheesePizza();
        } else if (type.Equals("pepperoni")) {
            pizza = new NewYorkStylePepperoniPizza();
        }

        return pizza;
    }
}