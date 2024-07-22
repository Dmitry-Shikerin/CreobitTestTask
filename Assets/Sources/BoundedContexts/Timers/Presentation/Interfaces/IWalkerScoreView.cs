using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.UI.Texts;

namespace Sources.BoundedContexts.Timers.Presentation.Interfaces
{
    public interface IWalkerScoreView
    {
        ITextView BestScoreText { get; }
        ITextView CurrentScoreText { get; }
        
        void StartTimer();
        void StopTimer();
    }
}