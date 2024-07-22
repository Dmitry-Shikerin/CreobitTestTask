using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.Views;
using Sources.PresentationsInterfaces.UI.Buttons;

namespace Sources.BoundedContexts.MainMenuForms.Presentation.Interfaces
{
    public interface IMainMenuForm : IView
    {
        IButtonView ClickerButton { get; }
        IButtonView LoadClickerAssetsButton { get; }
        IButtonView UnLoadClickerAssetsButton { get; }
        IButtonView WalkerButton { get; }
        IButtonView LoadWalkerAssetsButton { get; }
        IButtonView UnLoadWalkerAssetsButton { get; }
    }
}