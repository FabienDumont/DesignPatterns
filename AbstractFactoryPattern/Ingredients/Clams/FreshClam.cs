namespace AbstractFactoryPattern.Ingredients.Clams; 

public class FreshClam : IClam {
    public string GetDescription() {
        return "Fresh Clam";
    }
}