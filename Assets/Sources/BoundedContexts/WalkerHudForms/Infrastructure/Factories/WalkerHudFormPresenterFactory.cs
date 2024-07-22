using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.WalkerHudForms.Controllers;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;

namespace Sources.BoundedContexts.WalkerHudForms.Infrastructure.Factories
{
    public class WalkerHudFormPresenterFactory
    {
        private readonly ISceneService _sceneService;

        public WalkerHudFormPresenterFactory(ISceneService sceneService)
        {
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
        }

        public WalkerHudFormPresenter Create(IWalkerHudForm view)
        {
            return new WalkerHudFormPresenter(view, _sceneService);
        }
    }
}