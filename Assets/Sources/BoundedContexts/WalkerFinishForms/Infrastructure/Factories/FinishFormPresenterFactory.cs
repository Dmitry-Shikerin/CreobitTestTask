using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.Finishes.Presentation.Views.Implementation;
using Sources.BoundedContexts.WalkerFinishForms.Controllers;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;
using Sources.InfrastructureInterfaces.Services.PauseServices;

namespace Sources.BoundedContexts.WalkerFinishForms.Infrastructure.Factories
{
    public class FinishFormPresenterFactory
    {
        private readonly IPauseService _pauseService;
        private readonly IFormService _formService;
        private readonly ISceneService _sceneService;

        public FinishFormPresenterFactory(
            IPauseService pauseService,
            IFormService formService,
            ISceneService sceneService)
        {
            _pauseService = pauseService ?? throw new ArgumentNullException(nameof(pauseService));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
        }

        public FinishFormPresenter Create(IFinishForm view) =>
            new(view, _pauseService, _formService, _sceneService);
    }
}