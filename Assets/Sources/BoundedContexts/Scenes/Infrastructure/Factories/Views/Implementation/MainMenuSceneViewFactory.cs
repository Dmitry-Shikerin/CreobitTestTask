using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.MainMenuHuds.Presentation.Views;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation
{
    public class MainMenuSceneViewFactory : ISceneViewFactory
    {
        private readonly MainMenuHud _mainMenuHud;
        private readonly MainMenuFormServiceFactory _mainMenuFormServiceFactory;

        public MainMenuSceneViewFactory(
            MainMenuHud mainMenuHud,
            MainMenuFormServiceFactory mainMenuFormServiceFactory)
        {
            _mainMenuHud = mainMenuHud ?? throw new ArgumentNullException(nameof(mainMenuHud));
            _mainMenuFormServiceFactory = mainMenuFormServiceFactory ?? 
                                          throw new ArgumentNullException(nameof(mainMenuFormServiceFactory));
        }
    
        public void Create(IScenePayload payload)
        {
            _mainMenuFormServiceFactory.Create();
        }
    }
}
