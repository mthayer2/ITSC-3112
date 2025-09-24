namespace SmartHomeMonolith;

public class SensorEvent
{
    public EventType Type { get; set; }
    public string Room { get; set; }
    public double Value { get; set; }   // For Temperature: °F
}