using Sources.BoundedContexts.WalkerHudForms.Controllers;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;

namespace Sources.BoundedContexts.WalkerHudForms.Infrastructure.Factories
{
    public class WalkerHudFormPresenterFactory
    {
        public WalkerHudFormPresenter Create(IWalkerHudForm view)
        {
            return new WalkerHudFormPresenter(view);
        }
    }
}