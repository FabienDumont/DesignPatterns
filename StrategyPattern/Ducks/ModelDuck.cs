using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public class ModelDuck : Duck {
	public ModelDuck() : base(new FlyNoWay(), new RegularQuack()) {
	}

	public override void Display() {
		Console.WriteLine("This is a model duck");
	}
}