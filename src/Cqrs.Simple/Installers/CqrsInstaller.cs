﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Cqrs.Simple.Installers
{
    public class CqrsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<ICommandHandlerFactory>()
                    .ImplementedBy<CommandHandlerFactory>()
                    .LifestyleSingleton(),
                Component.For<IQueryHandlerFactory>()
                    .ImplementedBy<QueryHandlerFactory>()
                    .LifestyleSingleton(),
                Component.For<IExecute>()
                    .ImplementedBy<Execute>()
                    .LifestyleSingleton()
            );
        }
    }
}