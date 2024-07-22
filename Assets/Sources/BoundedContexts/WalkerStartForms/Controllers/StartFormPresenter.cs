using System;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.WalkerStartForms.Controllers
{
    public class StartFormPresenter : PresenterBase
    {
        private readonly IStartForm _view;

        public StartFormPresenter(IStartForm view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public override void Enable()
        {
            _view.StartButton.AddClickListener(StartGame);
        }

        public override void Disable()
        {
            _view.StartButton.RemoveClickListener(StartGame);
        }

        private void StartGame()
        {
            
        }
    }
}