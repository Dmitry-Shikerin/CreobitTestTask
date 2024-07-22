using System;
using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.MainMenuForms.Controllers;
using Sources.BoundedContexts.MainMenuForms.Presentation.Interfaces;
using Sources.Presentations.UI.Buttons;
using Sources.PresentationsInterfaces.UI.Buttons;
using UnityEngine;
using UnityEngine.UIElements;

namespace Sources.BoundedContexts.MainMenuForms.Presentation.Implementation
{
    public class MainMenuForm : FormBase<MainMenuFormPresenter>, IMainMenuForm
    {
        [SerializeField] private ButtonView _clickerButton;
        [SerializeField] private ButtonView _loadClickerAssetsButton;
        [SerializeField] private ButtonView _unLoadClickerAssetsButton;
        [SerializeField] private ButtonView _walkerButton;
        [SerializeField] private ButtonView _loadWalkerAssetsButton;
        [SerializeField] private ButtonView _unLoadWalkerAssetsButton;

        public IButtonView ClickerButton => _clickerButton;
        public IButtonView LoadClickerAssetsButton => _loadClickerAssetsButton;
        public IButtonView UnLoadClickerAssetsButton => _unLoadClickerAssetsButton;
        public IButtonView WalkerButton => _walkerButton;
        public IButtonView LoadWalkerAssetsButton => _loadWalkerAssetsButton;
        public IButtonView UnLoadWalkerAssetsButton => _unLoadWalkerAssetsButton;
    }
}