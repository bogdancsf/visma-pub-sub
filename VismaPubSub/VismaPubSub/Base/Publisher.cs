using System;

namespace VismaPubSub.Base
{
    public abstract class Publisher<T>
    {
        public event EventHandler<T> Event = delegate { };

        public void Publish(T args)
        {
            Event?.Invoke(this, args);
        }
    }
}