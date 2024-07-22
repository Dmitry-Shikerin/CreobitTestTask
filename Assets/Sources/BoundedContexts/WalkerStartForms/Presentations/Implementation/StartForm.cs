using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.WalkerStartForms.Controllers;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Interfaces;
using Sources.Presentations.UI.Buttons;
using Sources.PresentationsInterfaces.UI.Buttons;
using UnityEngine;

namespace Sources.BoundedContexts.WalkerStartForms.Presentations.Implementation
{
    public class StartForm : FormBase<StartFormPresenter>, IStartForm
    {
        [SerializeField] private ButtonView _startButton;
        
        public IButtonView StartButton => _startButton;
    }
}