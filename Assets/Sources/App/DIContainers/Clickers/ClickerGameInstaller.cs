using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Zenject;

namespace Sources.App.DIContainers.Clickers
{
    public class ClickerGameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ISceneFactory>().To<ClickerGameSceneFactory>().AsSingle();
        }
    }
}