using System;
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance(bool useMetric)
    {
        double km = (_laps * 50) / 1000.0;
        return useMetric ? km : km * 0.62;
    }

    public override double GetSpeed(bool useMetric) =>
        (GetDistance(useMetric) / Minutes) * 60;

    public override double GetPace(bool useMetric) =>
        Minutes / GetDistance(useMetric);
}
