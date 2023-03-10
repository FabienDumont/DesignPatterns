using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.Stores; 

public abstract class PizzaStore {

    public Pizza OrderPizza(string type) {
        Pizza pizza;

        pizza = CreatePizza(type) ?? throw new InvalidOperationException();

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }

    public abstract Pizza? CreatePizza(string type);
}