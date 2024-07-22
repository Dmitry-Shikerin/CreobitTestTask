using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.Timers.Domain;
using Sources.BoundedContexts.Timers.Infrastructure.Factories.Factories.Controllers;
using Sources.BoundedContexts.Timers.Presentation.Implementation;
using Sources.BoundedContexts.Timers.Presentation.Interfaces;

namespace Sources.BoundedContexts.Timers.Infrastructure.Factories.Factories.Views
{
    public class WalkerScoreViewFactory
    {
        private readonly WalkerScorePresenterFactory _presenterFactory;

        public WalkerScoreViewFactory(WalkerScorePresenterFactory presenterFactory)
        {
            _presenterFactory = presenterFactory ?? throw new ArgumentNullException(nameof(presenterFactory));
        }

        public IWalkerScoreView Create(WalkerScore walkerScore, WalkerScoreView view)
        {
            var presenter = _presenterFactory.Create(walkerScore, view);
            view.Construct(presenter);

            return view;
        }
    }
}