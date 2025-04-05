using System;

namespace Network
{
    [AttributeUsage(AttributeTargets.Method,AllowMultiple = false)]
    public class Atribute_SignalTask : Attribute
    {
        public string EventName { get; }

        public Atribute_SignalTask(string eventName)
        {
            EventName = eventName;
        }
    }
}