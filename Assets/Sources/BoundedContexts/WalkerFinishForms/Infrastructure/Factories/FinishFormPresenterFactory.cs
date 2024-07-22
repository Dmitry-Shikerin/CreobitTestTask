using Sources.BoundedContexts.Finishes.Presentation.Views.Implementation;
using Sources.BoundedContexts.WalkerFinishForms.Controllers;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Interfaces;

namespace Sources.BoundedContexts.WalkerFinishForms.Infrastructure.Factories
{
    public class FinishFormPresenterFactory
    {
        public FinishFormPresenter Create(IFinishForm view) =>
            new(view);
    }
}