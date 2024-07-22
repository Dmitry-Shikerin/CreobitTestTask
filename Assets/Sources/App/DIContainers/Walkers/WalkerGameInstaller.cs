using Sources.BoundedContexts.WalkerHuds.Presentation;
using UnityEngine;
using Zenject;

namespace Sources.App.DIContainers.Walkers
{
    public class WalkerGameInstaller : MonoInstaller
    {
        [SerializeField] private WalkerGameHud _hud;
        
        public override void InstallBindings()
        {
            Container.Bind<WalkerGameHud>().FromInstance(_hud).AsSingle();
        }
    }
}