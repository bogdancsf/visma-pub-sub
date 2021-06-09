using System;
using VismaPubSub.Base;

namespace VismaPubSub.Derived
{
    public class EmergencyPublisher : Publisher<Emergency>
    {
        public void PublishEmergency(Emergency emergency)
        {
            Console.WriteLine($"Emergency of type '{emergency.Type}' is being published'");

            Publish(emergency);
        }
    }
}
