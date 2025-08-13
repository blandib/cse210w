using System;
using System.Collections.Generic;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date => _date;
    public int Minutes => _minutes;

    public abstract double GetDistance(bool useMetric); // km or miles
    public abstract double GetSpeed(bool useMetric);    // kph or mph
    public abstract double GetPace(bool useMetric);     // min/km or min/mile

    public virtual string GetSummary(bool useMetric)
    {
        string unit = useMetric ? "km" : "miles";
        string speedUnit = useMetric ? "kph" : "mph";
        string paceUnit = useMetric ? "min per km" : "min per mile";

        return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min): " +
               $"Distance: {GetDistance(useMetric):0.0} {unit}, " +
               $"Speed: {GetSpeed(useMetric):0.0} {speedUnit}, " +
               $"Pace: {GetPace(useMetric):0.0} {paceUnit}";
    }
}
