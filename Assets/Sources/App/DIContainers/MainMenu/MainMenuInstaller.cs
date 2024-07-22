using Sources.BoundedContexts.MainMenuForms.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.MainMenuHuds.Presentation.Views;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using UnityEngine;
using Zenject;

namespace Sources.App.DIContainers.MainMenu
{
    public class MainMenuInstaller : MonoInstaller
    {
        [SerializeField] private MainMenuHud _mainMenuHud;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MainMenuHud>().FromInstance(_mainMenuHud).AsSingle();
            Container.Bind<ISceneViewFactory>().To<MainMenuSceneViewFactory>().AsSingle();
            Container.Bind<ISceneFactory>().To<MainMenuSceneFactory>().AsSingle();
            
            //Forms
            Container.Bind<MainMenuFormPresenterFactory>().AsSingle();
        }
    }
}