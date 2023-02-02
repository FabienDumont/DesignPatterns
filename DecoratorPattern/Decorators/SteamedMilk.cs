using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators; 

public class SteamedMilk : CondimentDecorator {
    public SteamedMilk(Beverage beverage) : base(beverage) {
        Description = $"{Beverage.GetDescription()}, Steamed Milk";
    }

    public override double Cost() {
        return Beverage.Cost() + .10;
    }
}