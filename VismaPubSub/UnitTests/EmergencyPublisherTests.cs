using System;
using VismaPubSub.Derived;
using Xunit;

namespace VismaPubSub
{
    public class EmergencyPublisherTests
    {
        [Theory]
        [InlineData(EmergencyType.Fire)]
        [InlineData(EmergencyType.Medical)]
        [InlineData(EmergencyType.Police)]
        public void PublisherInvokesEvent(EmergencyType type)
        {
            //arrange
            object sender = null;
            EmergencyType? publishedEmergencyType = null;

            var publisher = new EmergencyPublisher();
            publisher.Event += new EventHandler<EmergencyType>((object x, EmergencyType y) => 
            {
                sender = x; 
                publishedEmergencyType = y; 
            });

            //act
            publisher.PublishEmergency(type);

            //assert
            Assert.NotNull(sender);
            Assert.Same(publisher, sender);

            Assert.NotNull(publishedEmergencyType);
            Assert.Equal(publishedEmergencyType, type);
        }
    }
}
