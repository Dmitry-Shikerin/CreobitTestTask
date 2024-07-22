using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.Ids.Domain.Constant;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;
using Sources.InfrastructureInterfaces.Services.PauseServices;

namespace Sources.BoundedContexts.WalkerFinishForms.Controllers
{
    public class FinishFormPresenter : PresenterBase
    {
        private readonly IFinishForm _view;
        private readonly IPauseService _pauseService;
        private readonly IFormService _formService;
        private readonly ISceneService _sceneService;

        public FinishFormPresenter(
            IFinishForm view,
            IPauseService pauseService,
            IFormService formService,
            ISceneService sceneService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _pauseService = pauseService ?? throw new ArgumentNullException(nameof(pauseService));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
        }

        public override void Enable()
        {
            _pauseService.Pause();
            _view.RetryButton.AddClickListener(RetryGame);
            _view.MainMenuButton.AddClickListener(LoadMainMenu);
        }

        public override void Disable()
        {
            _pauseService.Continue();
            _view.RetryButton.RemoveClickListener(RetryGame);
            _view.MainMenuButton.RemoveClickListener(LoadMainMenu);
        }

        private void RetryGame()
        {
            
        }

        private void LoadMainMenu()
        {
            _sceneService.ChangeSceneAsync(ModelId.MainMenu);
        }
    }
}