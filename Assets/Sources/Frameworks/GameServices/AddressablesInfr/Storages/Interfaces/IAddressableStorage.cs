using Cysharp.Threading.Tasks;
using Sources.Frameworks.GameServices.AddressablesInfr.AssetProviders.Implementation;

namespace Sources.Frameworks.GameServices.AddressablesInfr.Storages.Interfaces
{
    public interface IAddressableStorage
    {
        UniTask LoadAsset<T>() 
            where T : AssetProviderBase;
        void Release<T>() 
            where T : AssetProviderBase;
        T GetAsset<T>() 
            where T : AssetProviderBase;
    }
}