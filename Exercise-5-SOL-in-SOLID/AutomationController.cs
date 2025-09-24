namespace SmartHomeMonolith;

public class AutomationController
{
    public void ProcessEvent(SensorEvent sensorEvent, AlertChannel channel)
    {
        // 1) Device logic
        if (sensorEvent.Type == EventType.Motion)
            Console.WriteLine($"[DEVICE] Light ON in {sensorEvent.Room}");

        if (sensorEvent.Type == EventType.Temperature && sensorEvent.Value < 70)
            Console.WriteLine("[DEVICE] Heat ON in " + sensorEvent.Room);

        // 2) Calculate Risk Percentage between 0.0 to 1.0
        double risk = (sensorEvent.Type == EventType.Temperature && sensorEvent.Value < 65) ? 0.8 : 0.0;
        
        // 3) Notify the user
        if (risk >= 0.8)
        {
            string msg = $"ALERT: Risk {risk} in {sensorEvent.Room}";
            
            switch (channel)
            {
                case AlertChannel.Email: 
                    Console.WriteLine("[EMAIL] " + msg); 
                    break;
                case AlertChannel.MobilePush: 
                    Console.WriteLine("[PUSH] " + msg); 
                    break;
                default:
                    throw new Exception("Unknown channel");
            }
        }
    }
}
