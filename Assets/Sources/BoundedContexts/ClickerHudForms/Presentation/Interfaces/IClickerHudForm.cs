using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.Views;
using Sources.PresentationsInterfaces.UI.Buttons;

namespace Sources.BoundedContexts.ClickerHudForms.Presentation.Interfaces
{
    public interface IClickerHudForm : IView
    {
        IButtonView MainMenuButton { get; }
    }
}