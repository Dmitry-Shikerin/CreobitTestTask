using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Views;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.WalkerHuds.Presentation;
using Sources.BoundedContexts.WalkerRoots.Presentation;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Implementation;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;
using UnityEngine;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation
{
    public class WalkerGameSceneViewFactory : ISceneViewFactory
    {
        private readonly WalkerRootGameObjects _root;
        private readonly WalkerGameHud _hud;
        private readonly WalkerFormServiceFactory _formServiceFactory;
        private readonly FinishViewFactory _finishViewFactory;

        public WalkerGameSceneViewFactory(
            WalkerRootGameObjects root,
            WalkerGameHud hud,
            WalkerFormServiceFactory formServiceFactory,
            FinishViewFactory finishViewFactory)
        {
            _root = root ?? throw new ArgumentNullException(nameof(root));
            _hud = hud ?? throw new ArgumentNullException(nameof(hud));
            _formServiceFactory = formServiceFactory ?? 
                                  throw new ArgumentNullException(nameof(formServiceFactory));
            _finishViewFactory = finishViewFactory ?? throw new ArgumentNullException(nameof(finishViewFactory));
        }

        public void Create(IScenePayload payload)
        {
            _formServiceFactory
                .Create()
                .Show<StartForm>();

            _finishViewFactory.Create(_root.FinishView);
        }
    }
}