namespace SmartHomeMonolith;

class Program
{
    static void Main(string[] args)
    {
        SensorEvent e = new SensorEvent { Type = EventType.Temperature, Room = "Bedroom", Value = 63 };
        new AutomationController().ProcessEvent(e, AlertChannel.Email);
    }
}