using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Sources.App.Core;
using Sources.BoundedContexts.Ids.Domain.Constant;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Controllers.Interfaces;
using Sources.ControllersInterfaces.Scenes;
using Sources.Frameworks.GameServices.AddressablesInfr.Storages.Implementation;
using Sources.Frameworks.GameServices.AddressablesInfr.Storages.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Services.Implementation;
using Sources.InfrastructureInterfaces.Services.SceneLoaderService;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace Sources.App.Factories
{
    public class AppCoreFactory
    {
        public AppCore Create()
        {
            ProjectContext projectContext = Object.FindObjectOfType<ProjectContext>();
            
            AppCore appCore = new GameObject(nameof(AppCore)).AddComponent<AppCore>();
            AddressableStorage addressableStorage = new GameObject(nameof(AddressableStorage))
                .AddComponent<AddressableStorage>();
            projectContext.Container.Bind<IAddressableStorage>().FromInstance(addressableStorage);
            projectContext.Container.Inject(addressableStorage);

            // CurtainView curtainView =
            //     Object.Instantiate(Resources.Load<CurtainView>(PrefabPath.Curtain)) ??
            //     throw new NullReferenceException(nameof(CurtainView));
            // projectContext.Container.Bind<ICurtainView>().To<CurtainView>().FromInstance(curtainView);
            // curtainView.Hide();
            
            Dictionary<string, Func<object, SceneContext, UniTask<IScene>>> sceneFactories =
                new Dictionary<string, Func<object, SceneContext, UniTask<IScene>>>();
            SceneService sceneService = new SceneService(sceneFactories);
            projectContext.Container.BindInterfacesAndSelfTo<SceneService>().FromInstance(sceneService);
            
            sceneFactories[ModelId.MainMenu] = (payload, sceneContext) =>
                sceneContext.Container.Resolve<ISceneFactory>().Create(payload);
            sceneFactories[ModelId.ClickerGame] = (payload, sceneContext) =>
                sceneContext.Container.Resolve<ISceneFactory>().Create(payload);
            sceneFactories[ModelId.WalkerGame] = (payload, sceneContext) =>
                sceneContext.Container.Resolve<ISceneFactory>().Create(payload);

            // sceneService.AddBeforeSceneChangeHandler(async _ => await curtainView.ShowCurtain());
            
            sceneService.AddBeforeSceneChangeHandler(async sceneName =>
                await projectContext.Container.Resolve<ISceneLoaderService>().LoadSceneAsync(sceneName));
            
            appCore.Construct(sceneService);

            return appCore;
        }
    }
}