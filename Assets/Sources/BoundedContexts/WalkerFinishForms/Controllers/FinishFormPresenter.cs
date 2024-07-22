using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.WalkerFinishForms.Controllers
{
    public class FinishFormPresenter : PresenterBase
    {
        private readonly IFinishForm _view;

        public FinishFormPresenter(IFinishForm view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }
    }
}