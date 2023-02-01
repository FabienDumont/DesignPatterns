using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public class RubberDuck : Duck {
	public RubberDuck() : base(new FlyNoWay(), new Squeak()) {
	}

	public override void Display() {
		Console.WriteLine("This is a rubber duck");
	}
}