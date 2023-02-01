/*
 * The Observer Pattern defines a one-to-many 
 * dependency between objects so that when one 
 * object changes state, all of its dependents are 
 * notified and updated automatically.
 */

using ObserverPattern.Observer;
using ObserverPattern.Subject;

WeatherData weatherData = new();

CurrentConditionsDisplay currentConditionsDisplay = new(weatherData);
StatisticsDisplay statisticsDisplay = new(weatherData);
ForecastDisplay forecastDisplay = new(weatherData);
HeatIndexDisplay heatIndexDisplay = new(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);