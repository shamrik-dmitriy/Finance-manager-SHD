using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using FM.SHD.Infrastructure.Events.ApplicationEvents;

namespace FM.SHD.Infrastructure.Events
{
    public class EventAggregator : IEventAggregator
    {
        private static readonly IEventAggregator _instance = new EventAggregator();

        public static IEventAggregator Instance => _instance;

        private readonly ConcurrentDictionary<Type, List<object>> _subscriptions = new ConcurrentDictionary<Type, List<object>>();
        
        public void Publish<T>(T message) where T : IApplicationEvent
        {
            if (!_subscriptions.TryGetValue(typeof(T), out var subscribers)) return;
            foreach (var subscriber in subscribers.ToArray())
            {
                ((Action<T>)subscriber)(message);
            }
        }

        public void Publish<T>() where T : IApplicationEvent
        {
            if (!_subscriptions.TryGetValue(typeof(T), out var subscribers)) return;
            foreach (var subscriber in subscribers.ToArray())
            {
                var action = (Action<T>)subscriber;
                action.Invoke(default);
            }
        }

        public void Subscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            var subscribers = _subscriptions.GetOrAdd(typeof(T), t => new List<object>());
            lock (subscribers)
            {
                subscribers.Add(action);
            }
        }

        public void Unsubscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            if (!_subscriptions.TryGetValue(typeof(T), out var subscribers)) return;
            lock (subscribers)
            {
                subscribers.Remove(action);
            }
        }
        
        public void Dispose()
        {
            _subscriptions.Clear();
        }
    }
}