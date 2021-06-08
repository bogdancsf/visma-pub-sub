using System;
using VismaPubSub.Base;

namespace VismaPubSub.Derived
{
    public class EmergencySubscriber : Subscriber<EmergencyType>
    {
        private readonly string _name;
        private readonly EmergencyType _type;

        public EmergencySubscriber(string name, EmergencyType type)
        {
            _name = name;
            _type = type;
        }

        protected override void Handle(object sender, EmergencyType emergencyType)
        {
            if (emergencyType == _type)
            {
                Console.WriteLine($"Subscriber '{_name}' has handled event of type '{emergencyType}'");
            }
        }
    }
}
