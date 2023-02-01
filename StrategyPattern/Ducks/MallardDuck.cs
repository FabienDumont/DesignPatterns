using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public class MallardDuck : Duck {
	public MallardDuck() : base(new FlyWithWings(), new RegularQuack()) {
	}

	public override void Display() {
		Console.WriteLine("This is a mallard duck");
	}
}