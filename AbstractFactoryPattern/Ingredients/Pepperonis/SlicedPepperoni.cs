namespace AbstractFactoryPattern.Ingredients.Pepperonis; 

public class SlicedPepperoni : IPepperoni {
    public string GetDescription() {
        return "Sliced Pepperoni";
    }
}