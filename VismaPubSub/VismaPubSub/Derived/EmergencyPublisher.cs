using System;
using VismaPubSub.Base;

namespace VismaPubSub.Derived
{
    public class EmergencyPublisher : Publisher<EmergencyType>
    {
        public void PublishEmergency(EmergencyType type)
        {
            Console.WriteLine($"Emergency of type '{type}' is being published'");

            Publish(type);
        }
    }
}
