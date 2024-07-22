using System;
using Sources.BoundedContexts.ClickerScores.Domain;
using Sources.BoundedContexts.ClickerScores.Presentations.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;
using UnityEngine;

namespace Sources.BoundedContexts.ClickerScores.Controllers
{
    public class ClickScorePresenter : PresenterBase
    {
        private readonly ClickScore _clickScore;
        private readonly IClickScoreView _view;

        public ClickScorePresenter(ClickScore clickScore, IClickScoreView view)
        {
            _clickScore = clickScore ?? throw new ArgumentNullException(nameof(clickScore));
            _view = view ?? throw new ArgumentNullException(nameof(view));
        }

        public override void Enable()
        {
            _view.ScoreText.SetText(_clickScore.Score.ToString());
            _view.ClickButton.AddClickListener(IncreaseScore);
        }

        public override void Disable()
        {
            _view.ClickButton.RemoveClickListener(IncreaseScore);
        }

        private void IncreaseScore()
        {
            _clickScore.Score++;
            _view.ScoreText.SetText(_clickScore.Score.ToString());
        }
    }
}