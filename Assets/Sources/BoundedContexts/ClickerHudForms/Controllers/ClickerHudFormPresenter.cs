using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.ClickerHudForms.Controllers
{
    public class ClickerHudFormPresenter : PresenterBase
    {
        private readonly IClickerHudForm _view;

        public ClickerHudFormPresenter(IClickerHudForm view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public override void Enable()
        {
            base.Enable();
        }

        public override void Disable()
        {
            base.Disable();
        }
    }
}