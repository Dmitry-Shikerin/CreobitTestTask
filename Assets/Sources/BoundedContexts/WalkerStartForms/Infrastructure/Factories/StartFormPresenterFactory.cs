using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.WalkerStartForms.Controllers;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Interfaces;
using Sources.InfrastructureInterfaces.Services.PauseServices;

namespace Sources.BoundedContexts.WalkerStartForms.Infrastructure.Factories
{
    public class StartFormPresenterFactory
    {
        private readonly IFormService _formService;
        private readonly IPauseService _pauseService;

        public StartFormPresenterFactory(
            IFormService formService,
            IPauseService pauseService)
        {
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _pauseService = pauseService ?? throw new ArgumentNullException(nameof(pauseService));
        }

        public StartFormPresenter Create(IStartForm view)
        {
            return new StartFormPresenter(view, _pauseService, _formService);
        }
    }
}