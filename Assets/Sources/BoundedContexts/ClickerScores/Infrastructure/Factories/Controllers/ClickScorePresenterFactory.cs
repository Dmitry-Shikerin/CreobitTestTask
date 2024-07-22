using Sources.BoundedContexts.ClickerScores.Controllers;
using Sources.BoundedContexts.ClickerScores.Domain;
using Sources.BoundedContexts.ClickerScores.Presentations.Interfaces;

namespace Sources.BoundedContexts.ClickerScores.Infrastructure.Factories.Controllers
{
    public class ClickScorePresenterFactory
    {
        public ClickScorePresenter Create(ClickScore clickScore, IClickScoreView view)
        {
            return new ClickScorePresenter(clickScore, view);
        }
    }
}