using System;
using JetBrains.Annotations;
using Sources.BoundedContexts.ClickerScores.Controllers;
using Sources.BoundedContexts.ClickerScores.Domain;
using Sources.BoundedContexts.ClickerScores.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.ClickerScores.Presentations.Implementation;
using Sources.BoundedContexts.ClickerScores.Presentations.Interfaces;

namespace Sources.BoundedContexts.ClickerScores.Infrastructure.Factories.Views
{
    public class ClickScoreViewFactory
    {
        private readonly ClickScorePresenterFactory _presenterFactory;

        public ClickScoreViewFactory(ClickScorePresenterFactory presenterFactory)
        {
            _presenterFactory = presenterFactory ?? throw new ArgumentNullException(nameof(presenterFactory));
        }

        public IClickScoreView Create(ClickScore clickScore, ClickScoreView view)
        {
            ClickScorePresenter presenter = _presenterFactory.Create(clickScore, view);
            view.Construct(presenter);
            
            return view;
        }
    }
}