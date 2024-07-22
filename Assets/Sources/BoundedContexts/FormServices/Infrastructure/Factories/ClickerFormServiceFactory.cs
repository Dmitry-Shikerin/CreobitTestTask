using System;
using Infrastructure.Services.Forms;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.ClickerHudForms.Controllers;
using Sources.BoundedContexts.ClickerHudForms.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.ClickerHuds.Presentation;

namespace Sources.BoundedContexts.FormServices.Infrastructure.Factories
{
    public class ClickerFormServiceFactory
    {
        private readonly ClickerGameHud _clickerGameHud;
        private readonly FormService _formService;
        private readonly ClickerHudFormPresenterFactory _clickerHudFormPresenterFactory;

        public ClickerFormServiceFactory(
            ClickerGameHud clickerGameHud,
            FormService formService,
            ClickerHudFormPresenterFactory clickerHudFormPresenterFactory)
        {
            _clickerGameHud = clickerGameHud ?? throw new ArgumentNullException(nameof(clickerGameHud));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _clickerHudFormPresenterFactory = clickerHudFormPresenterFactory ?? 
                                              throw new ArgumentNullException(nameof(clickerHudFormPresenterFactory));
        }

        public IFormService Create()
        {
            Form<ClickerHudForm, ClickerHudFormPresenter> clickerHudForm =
                new Form<ClickerHudForm, ClickerHudFormPresenter>(
                    _clickerHudFormPresenterFactory.Create, _clickerGameHud.ClickerHudForm);
            _formService.Add(clickerHudForm);
            
            return _formService;
        }
    }
}