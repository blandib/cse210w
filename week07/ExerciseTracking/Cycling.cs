using System;
public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(DateTime date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed(bool useMetric) =>
        useMetric ? _speedKph : _speedKph * 0.62;

    public override double GetDistance(bool useMetric) =>
        (GetSpeed(useMetric) * Minutes) / 60;

    public override double GetPace(bool useMetric) =>
        60 / GetSpeed(useMetric);
}
