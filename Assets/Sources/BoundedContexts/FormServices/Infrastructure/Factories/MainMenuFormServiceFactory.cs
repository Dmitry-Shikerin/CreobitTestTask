using System;
using Infrastructure.Services.Forms;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.MainMenuForms.Controllers;
using Sources.BoundedContexts.MainMenuForms.Infrastructure.Factories.Controllers;
using Sources.BoundedContexts.MainMenuForms.Presentation.Implementation;
using Sources.BoundedContexts.MainMenuHuds.Presentation.Views;

namespace Sources.BoundedContexts.FormServices.Infrastructure.Factories
{
    public class MainMenuFormServiceFactory
    {
        private readonly MainMenuHud _mainMenuHud;
        private readonly FormService _formService;
        private readonly MainMenuFormPresenterFactory _mainMenuFormPresenterFactory;

        public MainMenuFormServiceFactory(
            MainMenuHud mainMenuHud,
            FormService formService,
            MainMenuFormPresenterFactory mainMenuFormPresenterFactory)
        {
            _mainMenuHud = mainMenuHud ?? throw new ArgumentNullException(nameof(mainMenuHud));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _mainMenuFormPresenterFactory = mainMenuFormPresenterFactory ?? throw new ArgumentNullException(nameof(mainMenuFormPresenterFactory));
        }
        
        public IFormService Create()
        {
            Form<MainMenuForm, MainMenuFormPresenter> mainMenuForm =
                new Form<MainMenuForm, MainMenuFormPresenter>(
                    _mainMenuFormPresenterFactory.Create, _mainMenuHud.MainMenuForm);
            _formService.Add(mainMenuForm);
            
            
            return _formService;
        }
    }
}