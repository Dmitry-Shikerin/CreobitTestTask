using Infrastructure.Services.Forms;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.MainMenuForms.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.MainMenuHuds.Presentation.Views;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.Presentations.Views;
using UnityEngine;
using Zenject;

namespace Sources.App.DIContainers.MainMenu
{
    public class MainMenuInstaller : MonoInstaller
    {
        [SerializeField] private MainMenuHud _mainMenuHud;
        [SerializeField] private ContainerView _containerView;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainMenuHud>().FromInstance(_mainMenuHud).AsSingle();
            Container.BindInterfacesAndSelfTo<ContainerView>().FromInstance(_containerView).AsSingle();
            Container.Bind<ISceneViewFactory>().To<MainMenuSceneViewFactory>().AsSingle();
            Container.Bind<ISceneFactory>().To<MainMenuSceneFactory>().AsSingle();
            
            //Forms
            Container.BindInterfacesAndSelfTo<FormService>().AsSingle();
            Container.Bind<MainMenuFormServiceFactory>().AsSingle();
            Container.Bind<MainMenuFormPresenterFactory>().AsSingle();
        }
    }
}