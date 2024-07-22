using Sources.Frameworks.GameServices.SceneLoaderServices.Implementation;
using Sources.Infrastructure.Services.PauseServices;
using Sources.InfrastructureInterfaces.Services.PauseServices;
using Sources.InfrastructureInterfaces.Services.SceneLoaderService;
using Zenject;

namespace Sources.App.DIContainers.Projects
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPauseService>().To<PauseService>().AsSingle();
            Container.Bind<ISceneLoaderService>().To<SceneLoaderService>().AsSingle();
        }
    }
}