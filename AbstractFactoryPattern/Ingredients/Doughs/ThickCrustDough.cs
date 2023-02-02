namespace AbstractFactoryPattern.Ingredients.Doughs; 

public class ThickCrustDough : IDough {
    public string GetDescription() {
        return "Thick Crust Dough";
    }
}