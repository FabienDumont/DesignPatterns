namespace AbstractFactoryPattern.Ingredients.Doughs; 

public class ThinCrustDough : IDough {
    public string GetDescription() {
        return "Thin Crust Dough";
    }
}