using VismaPubSub.Base;

namespace Tests.Fakes
{
    public class FakeSubscriber<T> : Subscriber<T>
    {
        public T Value { get; set; }

        protected override void Handle(object sender, T args)
        {
            Value = args;
        }
    }
}
