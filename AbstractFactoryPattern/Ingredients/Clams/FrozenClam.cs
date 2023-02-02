namespace AbstractFactoryPattern.Ingredients.Clams; 

public class FrozenClam : IClam {
    public string GetDescription() {
        return "Frozen Clam";
    }
}