using Cysharp.Threading.Tasks;
using Sources.BoundedContexts.Scenes.Controllers;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.ControllersInterfaces.Scenes;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation
{
    public class WalkerGameSceneFactory : ISceneFactory
    {
        public UniTask<IScene> Create(object payload)
        {
            IScene gameplayScene = new WalkerGameScene();

            return UniTask.FromResult(gameplayScene);
        }
    }
}