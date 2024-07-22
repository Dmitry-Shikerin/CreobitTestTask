using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Views;
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

            Container.Bind<FinishViewFactory>().AsSingle();
            Container.Bind<FinishPresenterFactory>().AsSingle();
        }
    }
}