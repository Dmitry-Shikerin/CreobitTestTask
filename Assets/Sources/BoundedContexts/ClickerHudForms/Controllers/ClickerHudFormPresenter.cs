using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Interfaces;
using Sources.BoundedContexts.Ids.Domain.Constant;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.ClickerHudForms.Controllers
{
    public class ClickerHudFormPresenter : PresenterBase
    {
        private readonly IClickerHudForm _view;
        private readonly ISceneService _sceneService;

        public ClickerHudFormPresenter(
            IClickerHudForm view,
            ISceneService sceneService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
        }

        public override void Enable()
        {
            _view.MainMenuButton.AddClickListener(LoadMainMenuScene);
        }

        public override void Disable()
        {
            _view.MainMenuButton.RemoveClickListener(LoadMainMenuScene);
        }

        private void LoadMainMenuScene() =>
            _sceneService.ChangeSceneAsync(ModelId.MainMenu);
    }
}