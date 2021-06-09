using System;
using VismaPubSub.Derived;

namespace VismaPubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatcher911 = new EmergencyPublisher();

            var policeDepartment = new EmergencySubscriber("NYPD", EmergencyType.Police);
            var ambulanceDepartment = new EmergencySubscriber("Ambulance", EmergencyType.Medical);
            var fireDepartment = new EmergencySubscriber("FDNY", EmergencyType.Fire);

            policeDepartment.Subscribe(dispatcher911);
            ambulanceDepartment.Subscribe(dispatcher911);
            fireDepartment.Subscribe(dispatcher911);

            var contactInfo = GetInput();

            dispatcher911.PublishEmergency(BuildEmergency(EmergencyType.Fire, contactInfo));
            dispatcher911.PublishEmergency(BuildEmergency(EmergencyType.Medical, contactInfo));
            dispatcher911.PublishEmergency(BuildEmergency(EmergencyType.Police, contactInfo));
        }

        private static string GetInput()
        {
            Console.WriteLine("Type in address where emergency is taking place:");
            var address = Console.ReadLine();

            Console.WriteLine("\nType in phone number for contact:");
            var phoneNumber = Console.ReadLine();

            Console.WriteLine();

            return $"Address: {address}; Phone number: {phoneNumber}";
        }

        private static Emergency BuildEmergency(EmergencyType type, string input)
        {
            return new Emergency
            {
                Type = type,
                ContactInfo = input
            };
        }
    }
}
