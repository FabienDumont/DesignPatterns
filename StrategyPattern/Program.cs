/*
 * The Strategy Pattern defines a family of algorithms, 
 * encapsulates each one, and makes them interchangeable. 
 * Strategy lets the algorithm vary independently from 
 * clients that use it.
 */

using SimUDuck.Ducks;
using SimUDuck.FlyBehaviors;

Duck mallard = new MallardDuck();
mallard.PerformFly();
mallard.PerformQuack();

Duck model = new ModelDuck();
model.PerformFly();
model.FlyBehavior = new FlyRocketPowered();
model.PerformFly();