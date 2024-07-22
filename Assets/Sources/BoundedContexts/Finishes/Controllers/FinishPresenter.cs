using System;
using Sources.BoundedContexts.Characters.Presentation;
using Sources.BoundedContexts.Finishes.Presentation.Views.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.Finishes.Controllers
{
    public class FinishPresenter : PresenterBase
    {
        private readonly IFinishView _view;

        public FinishPresenter(IFinishView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public void Finish(CharacterView character)
        {
            
        }
    }
}