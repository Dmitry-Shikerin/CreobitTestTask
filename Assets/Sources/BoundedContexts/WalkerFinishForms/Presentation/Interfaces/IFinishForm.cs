using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.Views;
using Sources.PresentationsInterfaces.UI.Buttons;

namespace Sources.BoundedContexts.WalkerFinishForms.Presentation.Interfaces
{
    public interface IFinishForm : IView
    {
        IButtonView RetryButton { get; }
        IButtonView MainMenuButton { get; }
    }
}