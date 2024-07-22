using Infrastructure.Services.Forms;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Views;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.BoundedContexts.WalkerHudForms.Infrastructure.Factories;
using Sources.BoundedContexts.WalkerHuds.Presentation;
using Sources.BoundedContexts.WalkerRoots.Presentation;
using Sources.Presentations.Views;
using UnityEngine;
using Zenject;

namespace Sources.App.DIContainers.Walkers
{
    public class WalkerGameInstaller : MonoInstaller
    {
        [SerializeField] private WalkerGameHud _hud;
        [SerializeField] private ContainerView _containerView;
        [SerializeField] private WalkerRootGameObjects _root;
        
        public override void InstallBindings()
        {
            Container.Bind<WalkerGameHud>().FromInstance(_hud).AsSingle();
            Container.Bind<ContainerView>().FromInstance(_containerView).AsSingle();
            Container.Bind<WalkerRootGameObjects>().FromInstance(_root).AsSingle();

            Container.Bind<ISceneFactory>().To<WalkerGameSceneFactory>().AsSingle();
            Container.Bind<ISceneViewFactory>().To<WalkerGameSceneViewFactory>().AsSingle();
            
            //forms
            Container.BindInterfacesAndSelfTo<FormService>().AsSingle();
            Container.Bind<WalkerFormServiceFactory>().AsSingle();

            Container.Bind<WalkerHudFormPresenterFactory>().AsSingle();
            
            //finish
            Container.Bind<FinishPresenterFactory>().AsSingle();
            Container.Bind<FinishViewFactory>().AsSingle();
        }
    }
}