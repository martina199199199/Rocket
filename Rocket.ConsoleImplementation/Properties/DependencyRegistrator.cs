﻿using Rocket.API;
using Rocket.API.Chat;
using Rocket.API.DependencyInjection;
using Rocket.API.Scheduler;

namespace Rocket.ConsoleImplementation.Properties
{
    public class DependencyRegistrator : IDependencyRegistrator
    {
        public void Register(IDependencyContainer container, IDependencyResolver resolver)
        {
            container.RegisterSingletonType<IImplementation, ConsoleImplementation>();
            container.RegisterSingletonType<ITaskScheduler, SimpleTaskScheduler>();
            container.RegisterSingletonType<IChatManager, ConsoleChatManager>();
        }
    }
}