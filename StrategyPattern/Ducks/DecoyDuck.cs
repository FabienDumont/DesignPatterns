using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks; 

public class DecoyDuck : Duck {

	public DecoyDuck() : base(new FlyNoWay(), new MuteQuack()) {
	}
	
	public override void Display() {
		Console.WriteLine("This is a decoy duck");
	}
}