using System;
using Infrastructure.Services.Forms;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Presentation.Views.Forms.Common;
using Sources.BoundedContexts.WalkerFinishForms.Controllers;
using Sources.BoundedContexts.WalkerFinishForms.Infrastructure.Factories;
using Sources.BoundedContexts.WalkerFinishForms.Presentation.Implementation;
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
        private readonly FinishFormPresenterFactory _finishFormPresenterFactory;

        public WalkerFormServiceFactory(
            WalkerGameHud hud,
            FormService formService,
            WalkerHudFormPresenterFactory walkerHudFormPresenterFactory,
            FinishFormPresenterFactory finishFormPresenterFactory)
        {
            _hud = hud ?? throw new ArgumentNullException(nameof(hud));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _walkerHudFormPresenterFactory = walkerHudFormPresenterFactory ?? 
                                             throw new ArgumentNullException(nameof(walkerHudFormPresenterFactory));
            _finishFormPresenterFactory = finishFormPresenterFactory ?? 
                                          throw new ArgumentNullException(nameof(finishFormPresenterFactory));
        }

        public IFormService Create()
        {
            Form<WalkerHudForm, WalkerHudFormPresenter> walkerHudForm = new
                Form<WalkerHudForm, WalkerHudFormPresenter>(
                    _walkerHudFormPresenterFactory.Create, _hud.WalkerHudForm);
            _formService.Add(walkerHudForm);
            
            Form<FinishForm, FinishFormPresenter> finishForm = new
                Form<FinishForm, FinishFormPresenter>(
                    _finishFormPresenterFactory.Create, _hud.FinishForm);
            _formService.Add(finishForm);
            
            return _formService;
        }
    }
}