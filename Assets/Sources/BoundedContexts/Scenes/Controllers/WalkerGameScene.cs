using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.ControllersInterfaces.Scenes;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Controllers
{
    public class WalkerGameScene : IScene
    {
        private readonly ISceneViewFactory _viewFactory;

        public WalkerGameScene(ISceneViewFactory viewFactory)
        {
            _viewFactory = viewFactory ?? throw new ArgumentNullException(nameof(viewFactory));
        }

        public void Enter(object payload = null)
        {
            _viewFactory.Create((IScenePayload)payload);
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