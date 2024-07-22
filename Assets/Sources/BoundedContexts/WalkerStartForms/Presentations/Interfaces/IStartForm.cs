using Sources.PresentationsInterfaces.UI.Buttons;

namespace Sources.BoundedContexts.WalkerStartForms.Presentations.Interfaces
{
    public interface IStartForm
    {
        IButtonView StartButton { get; }

        void StartTimer();
    }
}