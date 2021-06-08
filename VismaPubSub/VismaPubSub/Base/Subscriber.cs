namespace VismaPubSub.Base
{
    public abstract class Subscriber<T>
    {
        public void Subscribe(Publisher<T> publisher)
        {
            publisher.Event += Handle;
        }

        public void Unsubscribe(Publisher<T> publisher)
        {
            publisher.Event -= Handle;
        }

        protected abstract void Handle(object sender, T args);
    }
}