using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation
{
    public class WalkerGameSceneViewFactory : ISceneViewFactory
    {
        private readonly WalkerFormServiceFactory _formServiceFactory;

        public WalkerGameSceneViewFactory(WalkerFormServiceFactory formServiceFactory)
        {
            _formServiceFactory = formServiceFactory ?? 
                                  throw new ArgumentNullException(nameof(formServiceFactory));
        }

        public void Create(IScenePayload payload)
        {
            _formServiceFactory
                .Create()
                .Show<WalkerHudForm>();
        }
    }
}