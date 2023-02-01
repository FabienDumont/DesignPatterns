using ObserverPattern.Observer;

namespace ObserverPattern.Subject;

public class WeatherData : ISubject {
    private List<IObserver> _observers;
    private float _temperature;

    public float Temperature => _temperature;

    private float _humidity;

    public float Humidity => _humidity;

    private float _pressure;

    public float Pressure => _pressure;

    public WeatherData() {
        _observers = new List<IObserver>();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure) {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }

    public void MeasurementsChanged() {
        NotifyObservers();
    }


    public void RegisterObserver(IObserver o) {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o) {
        _observers.Remove(o);
    }

    public void NotifyObservers() {
        foreach (IObserver observer in _observers) {
            observer.Update();
        }
    }
}