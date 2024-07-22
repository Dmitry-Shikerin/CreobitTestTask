using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.Finishes.Controllers;
using Sources.BoundedContexts.Finishes.Presentation.Views.Interfaces;

namespace Sources.BoundedContexts.Finishes.Infrastructure.Factories.Controllers
{
    public class FinishPresenterFactory
    {
        private readonly IFormService _formService;

        public FinishPresenterFactory(IFormService formService)
        {
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public FinishPresenter Create(IFinishView view)
        {
            return new FinishPresenter(view, _formService);
        }
    }
}