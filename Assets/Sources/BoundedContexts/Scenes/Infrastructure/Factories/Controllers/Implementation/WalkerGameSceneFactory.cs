using System;
using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using Sources.BoundedContexts.Scenes.Controllers;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.ControllersInterfaces.Scenes;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation
{
    public class WalkerGameSceneFactory : ISceneFactory
    {
        private readonly ISceneViewFactory _viewFactory;

        public WalkerGameSceneFactory(ISceneViewFactory viewFactory)
        {
            _viewFactory = viewFactory ?? throw new ArgumentNullException(nameof(viewFactory));
        }

        public UniTask<IScene> Create(object payload)
        {
            IScene gameplayScene = new WalkerGameScene(_viewFactory);

            return UniTask.FromResult(gameplayScene);
        }
    }
}