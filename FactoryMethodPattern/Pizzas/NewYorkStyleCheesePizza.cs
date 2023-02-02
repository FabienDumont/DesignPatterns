namespace FactoryMethodPattern.Pizzas; 

public class NewYorkStyleCheesePizza : Pizza {
    public NewYorkStyleCheesePizza() {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marina Sauce Sauce";
        
        Toppings.Add("Grated Reggiano Cheese");
    }
}