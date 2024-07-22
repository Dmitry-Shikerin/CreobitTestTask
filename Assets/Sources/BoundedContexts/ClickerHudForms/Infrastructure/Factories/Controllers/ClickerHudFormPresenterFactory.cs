using System;
using InfrastructureInterfaces.Services.Forms;
using JetBrains.Annotations;
using Sources.BoundedContexts.ClickerHudForms.Controllers;
using Sources.BoundedContexts.ClickerHudForms.Presentation.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;

namespace Sources.BoundedContexts.ClickerHudForms.Infrastructure.Factories.Controllers
{
    public class ClickerHudFormPresenterFactory
    {
        private readonly IFormService _formService;
        private readonly ISceneService _sceneService;

        public ClickerHudFormPresenterFactory(IFormService formService, ISceneService sceneService)
        {
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
        }
        
        public ClickerHudFormPresenter Create(IClickerHudForm view) =>
            new(view, _sceneService);
    }
}