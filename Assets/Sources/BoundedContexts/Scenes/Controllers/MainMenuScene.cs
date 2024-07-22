using System;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.ControllersInterfaces.Scenes;
using Sources.Frameworks.GameServices.Curtains.Presentation.Interfaces;

namespace Sources.BoundedContexts.Scenes.Controllers
{
    public class MainMenuScene : IScene
    {
        private readonly ISceneViewFactory _sceneViewFactory;
        private readonly ICurtainView _curtainView;

        public MainMenuScene(
            ISceneViewFactory mainMenuSceneViewFactory,
            ICurtainView curtainView)
        {
            _sceneViewFactory = mainMenuSceneViewFactory ??
                                        throw new ArgumentNullException(nameof(mainMenuSceneViewFactory));
            _curtainView = curtainView ?? throw new ArgumentNullException(nameof(curtainView));
        }

        public async void Enter(object payload = null)
        {
            _sceneViewFactory.Create(null);
            // await _curtainView.HideAsync();
        }

        public void Exit()
        {
        }

        public void Update(float deltaTime)
        {
        }

        public void UpdateLate(float deltaTime)
        {
        }

        public void UpdateFixed(float fixedDeltaTime)
        {
        }
    }
}