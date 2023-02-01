namespace SimUDuck.QuackBehaviors; 

public class MuteQuack : QuackBehavior {
	public void Quack() {
		Console.WriteLine("*can't quack*");
	}
}