using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.Finishes.Controllers;
using Sources.BoundedContexts.Finishes.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.Finishes.Presentation.Views.Implementation;
using Sources.BoundedContexts.Finishes.Presentation.Views.Interfaces;

namespace Sources.BoundedContexts.Finishes.Infrastructure.Factories.Views
{
    public class FinishViewFactory
    {
        private readonly FinishPresenterFactory _presenterFactory;

        public FinishViewFactory(FinishPresenterFactory presenterFactory)
        {
            _presenterFactory = presenterFactory ?? throw new ArgumentNullException(nameof(presenterFactory));
        }

        public IFinishView Create(FinishView view)
        {
            FinishPresenter presenter = _presenterFactory.Create(view);
            view.Construct(presenter);
            
            return view;
        }
    }
}