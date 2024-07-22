using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.WalkerHudForms.Controllers;
using Sources.Presentations.UI.Buttons;
using Sources.PresentationsInterfaces.UI.Buttons;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation
{
    public class WalkerHudForm : FormBase<WalkerHudFormPresenter>, IWalkerHudForm
    {
        [SerializeField] private ButtonView _mainMenuButton;

        public IButtonView MainMenuButton => _mainMenuButton;
    }
}