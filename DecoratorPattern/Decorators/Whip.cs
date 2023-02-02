using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators; 

public class Whip : CondimentDecorator {
    public Whip(Beverage beverage) : base(beverage) {
        Description = $"{Beverage.GetDescription()}, Whip";
    }

    public override double Cost() {
        return Beverage.Cost() + .10;
    }
}