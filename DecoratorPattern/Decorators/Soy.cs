using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators; 

public class Soy : CondimentDecorator {
    public Soy(Beverage beverage) : base(beverage) {
        Description = $"{Beverage.GetDescription()}, Soy";
    }

    public override double Cost() {
        return Beverage.Cost() + .15;
    }
}