using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Domain.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Zenject;

namespace Sources.App.DIContainers.Gameplay
{
    public class GameplayInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Container.Bind<RootGameObject>().FromInstance(_rootGameObject);
            // Container.Bind<GameplayHud>().FromInstance(_gameplayHud);
            
            Container.Bind<ISceneFactory>().To<GameplaySceneFactory>().AsSingle();
            Container.Bind<ISceneViewFactory>().To<GameplaySceneViewFactory>().AsSingle();
            
            //ModelsLoader
            Container.Bind<GameplayModelsCreatorService>().AsSingle();
            Container.Bind<GameplayModelsLoaderService>().AsSingle();
        }
    }
}