using Infrastructure.Services.Forms;
using Sources.BoundedContexts.ClickerHudForms.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.ClickerHuds.Presentation;
using Sources.BoundedContexts.ClickerScores.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.ClickerScores.Infrastructure.Factories.Views;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Views;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.Presentations.Views;
using UnityEngine;
using Zenject;

namespace Sources.App.DIContainers.Clickers
{
    public class ClickerGameInstaller : MonoInstaller
    {
        [SerializeField] private ClickerGameHud _clickerGameHud;
        [SerializeField] private ContainerView _containerView;
        
        public override void InstallBindings()
        {
            Container.Bind<ClickerGameHud>().FromInstance(_clickerGameHud).AsSingle();
            Container.Bind<ContainerView>().FromInstance(_containerView).AsSingle();
            
            Container.Bind<ISceneFactory>().To<ClickerGameSceneFactory>().AsSingle();
            Container.Bind<ISceneViewFactory>().To<ClickerGameSceneViewFactory>().AsSingle();

            Container.Bind<FinishViewFactory>().AsSingle();
            Container.Bind<FinishPresenterFactory>().AsSingle();
            
            //Forms
            Container.BindInterfacesAndSelfTo<FormService>().AsSingle();
            Container.Bind<ClickerFormServiceFactory>().AsSingle();
            
            Container.Bind<ClickerHudFormPresenterFactory>().AsSingle();
            
            //Score
            Container.Bind<ClickScorePresenterFactory>().AsSingle();
            Container.Bind<ClickScoreViewFactory>().AsSingle();
        }
    }
}