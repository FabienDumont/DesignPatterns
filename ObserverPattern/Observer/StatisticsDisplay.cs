using ObserverPattern.Subject;

namespace ObserverPattern.Observer; 

public class StatisticsDisplay : IObserver, IDisplayElement {
    private float _maxTemp = 0.0f;
    private float _minTemp = 200;
    private float _tempSum = 0.0f;
    private int _numReadings;
    private WeatherData _weatherData;
    
    public StatisticsDisplay(WeatherData weatherData) {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    
    public void Update() {
        _tempSum += _weatherData.Temperature;
        _numReadings++;
        if (_weatherData.Temperature > _maxTemp) {
            _maxTemp = _weatherData.Temperature;
        }

        if (_weatherData.Temperature < _minTemp) {
            _minTemp = _weatherData.Temperature;
        }
        
        Display();
    }

    public void Display() {
        Console.WriteLine($"Avg/Max/Min temperature = {_tempSum / _numReadings}/{_maxTemp}/{_minTemp}");
    }
}