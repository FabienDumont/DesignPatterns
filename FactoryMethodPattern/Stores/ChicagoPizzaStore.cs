using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.Stores; 

public class ChicagoPizzaStore : PizzaStore {
    public override Pizza? CreatePizza(string type) {
        Pizza? pizza = null;
        
        if (type.Equals("cheese")) {
            pizza = new ChicagoStyleCheesePizza();
        } else if (type.Equals("pepperoni")) {
            pizza = new ChicagoStylePepperoniPizza();
        }

        return pizza;
    }
}