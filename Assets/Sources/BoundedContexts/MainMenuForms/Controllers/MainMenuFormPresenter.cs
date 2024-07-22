using System;
using Sources.BoundedContexts.MainMenuForms.Presentation.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.MainMenuForms.Controllers
{
    public class MainMenuFormPresenter : PresenterBase
    {
        private readonly IMainMenuForm _view;

        public MainMenuFormPresenter(IMainMenuForm view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }
    }
}