using Xunit;
using Tests.Fakes;

namespace Tests
{
    public class SubscriberTests
    {
        [Fact]
        public void Test()
        {
            //arrange
            var subscriber = new FakeSubscriber<int>();
            var publisher = new FakePublisher<int>();
            subscriber.Subscribe(publisher);

            //act
            publisher.Publish(123);

            //assert
            Assert.Equal(123, subscriber.Value);
        }
    }
}
