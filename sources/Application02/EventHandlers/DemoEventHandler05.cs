﻿using AsyncMediator;
using DustInTheWind.DomainEventsPerformance.Application02;
using DustInTheWind.DomainEventsPerformance.Application02.UseCases.Demo2;

namespace DustInTheWind.DomainEventsPerformance.Application02.EventHandlers;

internal class DemoEventHandler05 : IEventHandler<Demo2Event>
{
    public Task Handle(Demo2Event @event)
    {
        StaticLog.Messages.Add("Result from MyClass05");
        return Task.CompletedTask;
    }
}
