using AbstractFactoryPattern.Ingredients.Cheeses;
using AbstractFactoryPattern.Ingredients.Clams;
using AbstractFactoryPattern.Ingredients.Doughs;
using AbstractFactoryPattern.Ingredients.Pepperonis;
using AbstractFactoryPattern.Ingredients.Sauces;
using AbstractFactoryPattern.Ingredients.Veggies;

namespace AbstractFactoryPattern.Factories;

public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory {
    public IDough CreateDough() {
        return new ThinCrustDough();
    }

    public ISauce CreateSauce() {
        return new MarinaSauce();
    }

    public ICheese CreateCheese() {
        return new RegianoCheese();
    }

    public IVeggie[] CreateVeggies() {
        IVeggie[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        return veggies;
    }

    public IPepperoni CreatePepperoni() {
        return new SlicedPepperoni();
    }

    public IClam CreateClam() {
        return new FreshClam();
    }
}