using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.Characters.Presentation;
using Sources.BoundedContexts.Finishes.Presentation.Views.Interfaces;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Implementation;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.Finishes.Controllers
{
    public class FinishPresenter : PresenterBase
    {
        private readonly IFinishView _view;
        private readonly IFormService _formService;

        public FinishPresenter(
            IFinishView view,
            IFormService formService)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public void Finish(CharacterView character)
        {
            _formService.Show<FinishForm>();
        }
    }
}