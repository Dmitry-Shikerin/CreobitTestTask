
using System;
using PresentationInterfaces.Views.Forms.Common;
using Sources.Frameworks.MVPPassiveView.Controllers.Interfaces.Presenters;
using UnityEngine;

namespace Presentation.Views.Forms.Common
{
    public class Form<TFormView, TFormPresenter> : IForm
        where TFormView : FormBase<TFormPresenter>
        where TFormPresenter : IPresenter
    {
        private readonly TFormView _formView;

        public Form(Func<TFormView, TFormPresenter> presenterFactory, TFormView formView)
        {
            _formView = formView ? formView : throw new ArgumentNullException(nameof(formView));

            var formPresenter = presenterFactory.Invoke(_formView);

            _formView.Construct(formPresenter);

            Name = _formView.GetType().Name;
        }

        public string Name { get; }

        public void Show() =>
            _formView.Show();

        public void Hide() =>
            _formView.Hide();

        public void SetParent(Transform parentTransform) =>
            _formView.SetParent(parentTransform);

        public void SetLocalePosition(Vector3 position)
        {
            throw new NotImplementedException();
        }

        public void SetPosition(Vector3 position)
        {
            throw new NotImplementedException();
        }

        public void SetRotation(Vector3 rotation)
        {
            throw new NotImplementedException();
        }

        public void SetRotation(Quaternion rotation)
        {
            throw new NotImplementedException();
        }

        public void SetTransformPosition(Transform position)
        {
            // _formView.SetTransformPosition(position);
            
        }

        public void Destroy() =>
            _formView.Destroy();
    }
}