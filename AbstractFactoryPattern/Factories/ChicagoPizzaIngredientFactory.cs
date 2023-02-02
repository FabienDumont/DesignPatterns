using AbstractFactoryPattern.Ingredients.Cheeses;
using AbstractFactoryPattern.Ingredients.Clams;
using AbstractFactoryPattern.Ingredients.Doughs;
using AbstractFactoryPattern.Ingredients.Pepperonis;
using AbstractFactoryPattern.Ingredients.Sauces;
using AbstractFactoryPattern.Ingredients.Veggies;

namespace AbstractFactoryPattern.Factories; 

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory {
    public IDough CreateDough() {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce() {
        return new PlumTomatoeSauce();
    }

    public ICheese CreateCheese() {
        return new MozzarellaCheese();
    }

    public IVeggie[] CreateVeggies() {
        IVeggie[] veggies = { new BlackOlive(), new Spinach(), new Eggplant() };
        return veggies;
    }

    public IPepperoni CreatePepperoni() {
        return new SlicedPepperoni();
    }

    public IClam CreateClam() {
        return new FrozenClam();
    }
}