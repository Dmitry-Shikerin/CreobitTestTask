using Sources.BoundedContexts.ClicckerAssets.Infrastructure.Services;
using Sources.BoundedContexts.WalkerAssets.Infrastructure.Services;
using Zenject;

namespace Sources.App.DIContainers.Projects
{
    public class AddressablesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<ClickerAssetProvider>().AsSingle();
            Container.Bind<WalkerAssetProvider>().AsSingle();
        }
    }
}