using System;
using Cysharp.Threading.Tasks;
using Sources.BoundedContexts.Scenes.Controllers;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.ControllersInterfaces.Scenes;
using Sources.Frameworks.GameServices.Curtains.Presentation.Interfaces;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation
{
    public class MainMenuSceneFactory : ISceneFactory
    {
        private readonly ISceneViewFactory _sceneViewFactory;
        // private readonly ICurtainView _curtainView;

        public MainMenuSceneFactory(
            ISceneViewFactory sceneViewFactory
            // ICurtainView curtainView
            )
        {
            _sceneViewFactory = sceneViewFactory ??
                                        throw new ArgumentNullException(nameof(sceneViewFactory));
            // _curtainView = curtainView ?? throw new ArgumentNullException(nameof(curtainView));
        }
        
        public UniTask<IScene> Create(object payload)
        {
            IScene mainMenuScene = new MainMenuScene(
                _sceneViewFactory
                // _curtainView
                );
            
            return UniTask.FromResult(mainMenuScene);
        }
    }
}