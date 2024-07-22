using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;
using Sources.InfrastructureInterfaces.Services.PauseServices;

namespace Sources.BoundedContexts.WalkerStartForms.Controllers
{
    public class StartFormPresenter : PresenterBase
    {
        private readonly IStartForm _view;
        private readonly IPauseService _pauseService;
        private readonly IFormService _formService;

        public StartFormPresenter(
            IStartForm view,
            IPauseService pauseService,
            IFormService formService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _pauseService = pauseService ?? throw new ArgumentNullException(nameof(pauseService));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public override void Enable()
        {
            _pauseService.Pause();
            _view.StartButton.AddClickListener(StartGame);
        }

        public override void Disable()
        {
            _view.StartButton.RemoveClickListener(StartGame);
            _pauseService.Continue();
        }

        private void StartGame()
        {
            _formService.Show<WalkerHudForm>();
            _view.StartTimer();
        }
    }
}