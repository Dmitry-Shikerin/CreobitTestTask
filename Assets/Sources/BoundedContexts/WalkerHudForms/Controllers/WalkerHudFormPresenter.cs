using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.Ids.Domain.Constant;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.WalkerHudForms.Controllers
{
    public class WalkerHudFormPresenter : PresenterBase
    {
        private readonly IWalkerHudForm _view;
        private readonly ISceneService _sceneService;

        public WalkerHudFormPresenter(
            IWalkerHudForm view,
            ISceneService sceneService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
        }

        public override void Enable()
        {
            _view.MainMenuButton.AddClickListener(LoadMainMenu);
        }

        public override void Disable()
        {
            _view.MainMenuButton.RemoveClickListener(LoadMainMenu);
        }

        private void LoadMainMenu()
        {
            _sceneService.ChangeSceneAsync(ModelId.MainMenu);
        }
    }
}