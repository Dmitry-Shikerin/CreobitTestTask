using Sources.BoundedContexts.Timers.Controllers;
using Sources.BoundedContexts.Timers.Presentation.Interfaces;
using Sources.Frameworks.MVPPassiveView.Presentations.Implementation.UI.Texts;
using Sources.Frameworks.MVPPassiveView.Presentations.Implementation.Views;
using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.UI.Texts;
using UnityEngine;

namespace Sources.BoundedContexts.Timers.Presentation.Implementation
{
    public class WalkerScoreView : PresentableView<WalkerScorePresenter>, IWalkerScoreView
    {
        [SerializeField] private TextView _bestScoreText;
        [SerializeField] private TextView _currentScoreText;
        
        public ITextView BestScoreText => _bestScoreText;
        public ITextView CurrentScoreText => _currentScoreText;
        
        public void StartTimer() =>
            Presenter.StartTimer();

        public void StopTimer() =>
            Presenter.StopTimer();
    }
}