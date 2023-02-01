using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public abstract class Duck {
	private FlyBehavior _flyBehavior;

	public FlyBehavior FlyBehavior {
		get => _flyBehavior;
		set => _flyBehavior = value ?? throw new ArgumentNullException(nameof(value));
	}

	private QuackBehavior _quackBehavior;

	public QuackBehavior QuackBehavior {
		get => _quackBehavior;
		set => _quackBehavior = value ?? throw new ArgumentNullException(nameof(value));
	}

	protected Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior) {
		_flyBehavior = flyBehavior;
		_quackBehavior = quackBehavior;
	}

	public void PerformFly() {
		FlyBehavior.Fly();
	}

	public void PerformQuack() {
		QuackBehavior.Quack();
	}

	public void Swim() {
		Console.WriteLine("All ducks float, even decoys!");
	}

	public abstract void Display();
}