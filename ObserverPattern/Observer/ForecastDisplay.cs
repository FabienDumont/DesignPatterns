using ObserverPattern.Subject;

namespace ObserverPattern.Observer;

public class ForecastDisplay : IObserver, IDisplayElement {
    private float _currentPressure = 29.92f;
    private float _lastPressure;
    private WeatherData _weatherData;
    
    public ForecastDisplay(WeatherData weatherData) {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    public void Update() {
        _lastPressure = _currentPressure;
        _currentPressure = _weatherData.Pressure;
        
        Display();
    }

    public void Display() {
        Console.WriteLine($"Forecast: ");
        if (_currentPressure > _lastPressure) {
            Console.WriteLine($"Improving weather on the way!");
        } else if (Math.Abs(_currentPressure - _lastPressure) < 0.01f) {
            Console.WriteLine($"More of the same");
        } else {
            Console.WriteLine($"Watch out for cooler, rainy weather");
        }
    }
}