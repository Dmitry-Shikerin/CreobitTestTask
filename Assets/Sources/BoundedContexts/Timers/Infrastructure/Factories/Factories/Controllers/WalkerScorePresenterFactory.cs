using Sources.BoundedContexts.Timers.Controllers;
using Sources.BoundedContexts.Timers.Domain;
using Sources.BoundedContexts.Timers.Presentation.Interfaces;

namespace Sources.BoundedContexts.Timers.Infrastructure.Factories.Factories.Controllers
{
    public class WalkerScorePresenterFactory
    {
        public WalkerScorePresenter Create(WalkerScore walkerScore, IWalkerScoreView view) =>
            new(walkerScore, view);
    }
}