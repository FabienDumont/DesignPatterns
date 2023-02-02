using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public class Mocha : CondimentDecorator {
    public Mocha(Beverage beverage) : base(beverage) {
        Description = $"{Beverage.GetDescription()}, Mocha";
    }

    public override double Cost() {
        return Beverage.Cost() + .20;
    }
}