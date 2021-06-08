using System;
using Xunit;
using Tests.Fakes;

namespace VismaPubSub
{
    public class PublisherTests
    {
        [Fact]
        public void Test()
        {
            //arrange
            object sender = null;
            int? publishedArgs = null;

            var publisher = new FakePublisher<int>();
            publisher.Event += new EventHandler<int>((object x, int y) => 
            {
                sender = x; 
                publishedArgs = y; 
            });

            //act
            publisher.Publish(123);

            //assert
            Assert.NotNull(sender);
            Assert.Same(publisher, sender);

            Assert.NotNull(publishedArgs);
            Assert.Equal(123, publishedArgs);
        }
    }
}
