using System;
using FM.SHD.Infrastructure.Events.ApplicationEvents;

namespace FM.SHD.Infrastructure.Events
{
    public interface IEventAggregator
    {
        void Publish<T>(T message) where T : IApplicationEvent;
        void Subscribe<T>(Action<T> action) where T : IApplicationEvent;
        void Unsubscribe<T>(Action<T> action) where T : IApplicationEvent;
    }
}