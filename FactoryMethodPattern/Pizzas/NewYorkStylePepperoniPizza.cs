namespace FactoryMethodPattern.Pizzas; 

public class NewYorkStylePepperoniPizza : Pizza {
    public NewYorkStylePepperoniPizza() {
        Name = "NY Style Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marina Sauce Sauce";
        
        Toppings.Add("Grated Reggiano Cheese");
        Toppings.Add("Sliced Pepperoni");
        Toppings.Add("Garlic");
        Toppings.Add("Onion");
        Toppings.Add("Mushrooms");
        Toppings.Add("Red Pepper");
    }
}