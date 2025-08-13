using System;
public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance(bool useMetric) =>
        useMetric ? _distanceKm : _distanceKm * 0.62;

    public override double GetSpeed(bool useMetric) =>
        (GetDistance(useMetric) / Minutes) * 60;

    public override double GetPace(bool useMetric) =>
        Minutes / GetDistance(useMetric);
}
