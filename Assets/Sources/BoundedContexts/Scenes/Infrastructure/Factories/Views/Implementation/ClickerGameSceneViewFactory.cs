using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation
{
    public class ClickerGameSceneViewFactory : ISceneViewFactory
    {
        private readonly ClickerFormServiceFactory _formServiceFactory;

        public ClickerGameSceneViewFactory(ClickerFormServiceFactory formServiceFactory)
        {
            _formServiceFactory = formServiceFactory ?? throw new ArgumentNullException(nameof(formServiceFactory));
        }

        public void Create(IScenePayload payload)
        {
            _formServiceFactory
                .Create()
                .Show<ClickerHudForm>();
            
        }
    }
}