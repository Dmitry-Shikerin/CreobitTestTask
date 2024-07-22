using Sources.BoundedContexts.Characters.Presentation;
using Sources.BoundedContexts.Finishes.Controllers;
using Sources.BoundedContexts.Finishes.Presentation.Views.Interfaces;
using Sources.Frameworks.MVPPassiveView.Presentations.Implementation.Views;
using UnityEngine;

namespace Sources.BoundedContexts.Finishes.Presentation.Views.Implementation
{
    public class FinishView : PresentableView<FinishPresenter>, IFinishView
    {
        [SerializeField] private CharacterTrigger _trigger;

        protected override void OnAfterEnable() =>
            _trigger.Entered += OnEntered;

        protected override void OnAfterDisable() =>
            _trigger.Entered -= OnEntered;

        private void OnEntered(CharacterView character) =>
            Presenter.Finish(character);
    }
}