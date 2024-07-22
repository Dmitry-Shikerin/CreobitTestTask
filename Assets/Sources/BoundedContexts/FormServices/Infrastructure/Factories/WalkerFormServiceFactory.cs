using System;
using Infrastructure.Services.Forms;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.WalkerHudForms.Controllers;
using Sources.BoundedContexts.WalkerHudForms.Infrastructure.Factories;
using Sources.BoundedContexts.WalkerHudForms.Presentation.Implementation;
using Sources.BoundedContexts.WalkerHuds.Presentation;

namespace Sources.BoundedContexts.FormServices.Infrastructure.Factories
{
    public class WalkerFormServiceFactory
    {
        private readonly WalkerGameHud _hud;
        private readonly FormService _formService;
        private readonly WalkerHudFormPresenterFactory _walkerHudFormPresenterFactory;

        public WalkerFormServiceFactory(
            WalkerGameHud hud,
            FormService formService,
            WalkerHudFormPresenterFactory walkerHudFormPresenterFactory)
        {
            _hud = hud ?? throw new ArgumentNullException(nameof(hud));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _walkerHudFormPresenterFactory = walkerHudFormPresenterFactory ?? throw new ArgumentNullException(nameof(walkerHudFormPresenterFactory));
        }

        public IFormService Create()
        {
            Form<WalkerHudForm, WalkerHudFormPresenter> walkerHudForm = new
                Form<WalkerHudForm, WalkerHudFormPresenter>(
                    _walkerHudFormPresenterFactory.Create, _hud.WalkerHudForm);
            _formService.Add(walkerHudForm);
            
            return _formService;
        }
    }
}