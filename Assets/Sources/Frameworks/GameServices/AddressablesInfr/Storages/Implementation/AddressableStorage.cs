using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using Sources.Frameworks.GameServices.AddressablesInfr.AssetProviders.Implementation;
using Sources.Frameworks.GameServices.AddressablesInfr.Storages.Interfaces;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Sources.Frameworks.GameServices.AddressablesInfr.Storages.Implementation
{
    [DefaultExecutionOrder(-1)]
    public class AddressableStorage : MonoBehaviour, IAddressableStorage
    {
        private Dictionary<Type, AssetProviderBase> _assetProviders;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            _assetProviders = new Dictionary<Type, AssetProviderBase>();
        }

        private void OnDestroy() =>
            ReleaseAll();

        public async UniTask<T> LoadAsset<T>() 
            where T : AssetProviderBase
        {
            if (_assetProviders.ContainsKey(typeof(T)) == false)
                throw new NullReferenceException(nameof(T));
            
            await _assetProviders[typeof(T)].LoadAsync();
            
             return (T)_assetProviders[typeof(T)];
        }

        public void Release<T>() 
            where T : AssetProviderBase
        {
            if (_assetProviders.ContainsKey(typeof(T)) == false)
                throw new NullReferenceException(nameof(T));

            _assetProviders[typeof(T)].Release();
        }

        public void Construct()
        {
            
        }

        private void ReleaseAll()
        {
            _assetProviders.Values
                .ToList()
                .ForEach(Addressables.Release);
        }
    }
}