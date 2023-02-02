using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators; 

public abstract class CondimentDecorator : Beverage {
    private Beverage _beverage;

    public Beverage Beverage {
        get => _beverage;
        set => _beverage = value ?? throw new ArgumentNullException(nameof(value));
    }

    protected CondimentDecorator(Beverage beverage) {
        _beverage = beverage;
    }


}