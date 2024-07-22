using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.Timers.Presentation.Implementation;
using Sources.BoundedContexts.WalkerFinishForms.Controllers;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Interfaces;
using Sources.Presentations.UI.Buttons;
using Sources.PresentationsInterfaces.UI.Buttons;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerFinishForms.Presentation.Implementation
{
    public class FinishForm : FormBase<FinishFormPresenter>, IFinishForm
    {
        [SerializeField] private ButtonView _retryButton;
        [SerializeField] private ButtonView _mainMenuButton;

        public IButtonView RetryButton => _retryButton;
        public IButtonView MainMenuButton => _mainMenuButton;
    }
}