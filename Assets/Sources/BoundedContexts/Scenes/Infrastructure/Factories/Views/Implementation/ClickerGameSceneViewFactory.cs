using System;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.ClickerHuds.Presentation;
using Sources.BoundedContexts.ClickerScores.Domain;
using Sources.BoundedContexts.ClickerScores.Infrastructure.Factories.Views;
using Sources.BoundedContexts.FormServices.Infrastructure.Factories;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation
{
    public class ClickerGameSceneViewFactory : ISceneViewFactory
    {
        private readonly ClickerGameHud _hud;
        private readonly ClickerFormServiceFactory _formServiceFactory;
        private readonly ClickScoreViewFactory _clickScoreViewFactory;

        public ClickerGameSceneViewFactory(
            ClickerGameHud hud,
            ClickerFormServiceFactory formServiceFactory,
            ClickScoreViewFactory clickScoreViewFactory)
        {
            _hud = hud ?? throw new ArgumentNullException(nameof(hud));
            _formServiceFactory = formServiceFactory ?? throw new ArgumentNullException(nameof(formServiceFactory));
            _clickScoreViewFactory = clickScoreViewFactory ?? 
                                     throw new ArgumentNullException(nameof(clickScoreViewFactory));
        }

        public void Create(IScenePayload payload)
        {
            ClickScore clickScore = new ClickScore();
            _clickScoreViewFactory.Create(clickScore, _hud.ClickScoreView);
            
            _formServiceFactory
                .Create()
                .Show<ClickerHudForm>();
        }
    }
}