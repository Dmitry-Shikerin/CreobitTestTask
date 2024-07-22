using System;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.ControllersInterfaces.Scenes;
using Sources.Frameworks.GameServices.Curtains.Presentation.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Controllers
{
    public class ClickerGameScene : IScene
    {
        private readonly ISceneViewFactory _gameplaySceneViewFactory;
        private readonly ICurtainView _curtainView;

        public ClickerGameScene(
            ISceneViewFactory gameplaySceneViewFactory
            // ICurtainView curtainView
            )
        {
            _gameplaySceneViewFactory = gameplaySceneViewFactory ?? 
                                        throw new ArgumentNullException(nameof(gameplaySceneViewFactory));
            // _curtainView = curtainView ?? throw new ArgumentNullException(nameof(curtainView));
        }

        public void Enter(object payload = null)
        {
            _gameplaySceneViewFactory.Create((IScenePayload)payload);
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