using Sources.BoundedContexts.WalkerStartForms.Controllers;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Interfaces;

namespace Sources.BoundedContexts.WalkerStartForms.Infrastructure.Factories
{
    public class StartFormPresenterFactory
    {
        public StartFormPresenter Create(IStartForm view)
        {
            return new StartFormPresenter(view);
        }
    }
}