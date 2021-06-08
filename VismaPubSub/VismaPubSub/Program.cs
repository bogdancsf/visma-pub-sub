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

            dispatcher911.PublishEmergency(EmergencyType.Fire);
            dispatcher911.PublishEmergency(EmergencyType.Medical);
            dispatcher911.PublishEmergency(EmergencyType.Police);
        }
    }
}
