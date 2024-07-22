using Sources.BoundedContexts.ClickerScores.Controllers;
using Sources.BoundedContexts.ClickerScores.Presentations.Interfaces;
using Sources.Frameworks.MVPPassiveView.Presentations.Implementation.UI.Texts;
using Sources.Frameworks.MVPPassiveView.Presentations.Implementation.Views;
using Sources.Frameworks.MVPPassiveView.Presentations.Interfaces.PresentationsInterfaces.UI.Texts;
using Sources.Presentations.UI.Buttons;
using Sources.PresentationsInterfaces.UI.Buttons;
using UnityEngine;

namespace Sources.BoundedContexts.ClickerScores.Presentations.Implementation
{
    public class ClickScoreView : PresentableView<ClickScorePresenter>, IClickScoreView
    {
        [SerializeField] private ButtonView _clickButton;
        [SerializeField] private TextView _scoreText;
        
        public IButtonView ClickButton => _clickButton;
        public ITextView ScoreText => _scoreText;
    }
}