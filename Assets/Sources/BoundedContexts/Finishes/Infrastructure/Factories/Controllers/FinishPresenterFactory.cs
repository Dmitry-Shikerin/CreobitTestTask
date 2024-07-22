using Sources.BoundedContexts.Finishes.Controllers;
using Sources.BoundedContexts.Finishes.Presentation.Views.Interfaces;

namespace Sources.BoundedContexts.Finishes.Infrastructure.Factories.Controllers
{
    public class FinishPresenterFactory
    {
        public FinishPresenter Create(IFinishView view)
        {
            return new FinishPresenter(view);
        }
    }
}