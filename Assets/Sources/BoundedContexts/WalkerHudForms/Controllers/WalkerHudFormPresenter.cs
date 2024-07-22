using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.WalkerHudForms.Controllers
{
    public class WalkerHudFormPresenter : PresenterBase
    {
        private readonly IWalkerHudForm _view;

        public WalkerHudFormPresenter(IWalkerHudForm view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }
    }
}