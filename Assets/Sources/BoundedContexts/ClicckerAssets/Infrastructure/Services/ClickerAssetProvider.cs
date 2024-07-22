using Cysharp.Threading.Tasks;
using Sources.Frameworks.GameServices.AddressablesInfr.AssetProviders.Implementation;

namespace Sources.BoundedContexts.ClicckerAssets.Infrastructure.Services
{
    public class ClickerAssetProvider : AssetProviderBase
    {
        
        public override UniTask LoadAsync()
        {
            return UniTask.CompletedTask;
        }
    }
}