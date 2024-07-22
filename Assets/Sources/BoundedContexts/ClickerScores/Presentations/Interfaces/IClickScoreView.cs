using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.UI.Texts;
using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.Views;
using Sources.PresentationsInterfaces.UI.Buttons;

namespace Sources.BoundedContexts.ClickerScores.Presentations.Interfaces
{
    public interface IClickScoreView : IView
    {
        IButtonView ClickButton { get; }
        ITextView ScoreText { get; }
    }
}