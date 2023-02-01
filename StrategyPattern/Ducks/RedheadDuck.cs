using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public class RedheadDuck : Duck {
	public RedheadDuck() : base(new FlyWithWings(), new RegularQuack()) {
	}

	public override void Display() {
		Console.WriteLine("This is a redhead duck");
	}
}