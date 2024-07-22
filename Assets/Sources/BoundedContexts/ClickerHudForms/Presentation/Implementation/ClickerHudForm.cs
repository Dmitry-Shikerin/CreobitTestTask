using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.ClickerHudForms.Controllers;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Interfaces;
using Sources.Presentations.UI.Buttons;
using Sources.PresentationsInterfaces.UI.Buttons;
using UnityEngine;

namespace Sources.BoundedContexts.ClickerHudForms.Presentation.Implementation
{
    public class ClickerHudForm : FormBase<ClickerHudFormPresenter>, IClickerHudForm
    {
        [SerializeField] private ButtonView _mainMenuButton;

        public IButtonView MainMenuButton => _mainMenuButton;
    }
}