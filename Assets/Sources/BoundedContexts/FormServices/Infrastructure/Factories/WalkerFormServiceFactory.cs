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
using Sources.BoundedContexts.WalkerStartForms.Controllers;
using Sources.BoundedContexts.WalkerStartForms.Infrastructure.Factories;
using Sources.BoundedContexts.WalkerStartForms.Presentations.Implementation;

namespace Sources.BoundedContexts.FormServices.Infrastructure.Factories
{
    public class WalkerFormServiceFactory
    {
        private readonly WalkerGameHud _hud;
        private readonly FormService _formService;
        private readonly WalkerHudFormPresenterFactory _walkerHudFormPresenterFactory;
        private readonly FinishFormPresenterFactory _finishFormPresenterFactory;
        private readonly StartFormPresenterFactory _startFormPresenterFactory;

        public WalkerFormServiceFactory(
            WalkerGameHud hud,
            FormService formService,
            WalkerHudFormPresenterFactory walkerHudFormPresenterFactory,
            FinishFormPresenterFactory finishFormPresenterFactory,
            StartFormPresenterFactory startFormPresenterFactory)
        {
            _hud = hud ?? throw new ArgumentNullException(nameof(hud));
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _walkerHudFormPresenterFactory = walkerHudFormPresenterFactory ?? 
                                             throw new ArgumentNullException(nameof(walkerHudFormPresenterFactory));
            _finishFormPresenterFactory = finishFormPresenterFactory ?? 
                                          throw new ArgumentNullException(nameof(finishFormPresenterFactory));
            _startFormPresenterFactory = startFormPresenterFactory ?? throw new ArgumentNullException(nameof(startFormPresenterFactory));
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
            
            Form<StartForm, StartFormPresenter> startForm = new
                Form<StartForm, StartFormPresenter>(
                    _startFormPresenterFactory.Create, _hud.StartForm);
            _formService.Add(startForm);
            
            return _formService;
        }
    }
}