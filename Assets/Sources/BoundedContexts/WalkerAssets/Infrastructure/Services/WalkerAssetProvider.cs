using Cysharp.Threading.Tasks;
using Sources.Frameworks.GameServices.AddressablesInfr.AssetProviders.Implementation;

namespace Sources.BoundedContexts.WalkerAssets.Infrastructure.Services
{
    public class WalkerAssetProvider : AssetProviderBase
    {
        public override UniTask LoadAsync()
        {
            return UniTask.CompletedTask;
        }
    }
}