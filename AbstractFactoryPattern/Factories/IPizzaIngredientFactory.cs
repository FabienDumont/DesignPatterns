using AbstractFactoryPattern.Ingredients.Cheeses;
using AbstractFactoryPattern.Ingredients.Clams;
using AbstractFactoryPattern.Ingredients.Doughs;
using AbstractFactoryPattern.Ingredients.Pepperonis;
using AbstractFactoryPattern.Ingredients.Sauces;
using AbstractFactoryPattern.Ingredients.Veggies;

namespace AbstractFactoryPattern.Factories; 

public interface IPizzaIngredientFactory {
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IVeggie[] CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClam CreateClam();
}