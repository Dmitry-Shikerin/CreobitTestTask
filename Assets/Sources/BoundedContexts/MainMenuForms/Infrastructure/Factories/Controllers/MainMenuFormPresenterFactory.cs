using System;
using Sources.BoundedContexts.MainMenuForms.Controllers;
using Sources.BoundedContexts.MainMenuForms.Presentation.Interfaces;
using Sources.Frameworks.GameServices.AddressablesInfr.Storages.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;

namespace Sources.BoundedContexts.MainMenuForms.Infrastructure.Factories.Controllers
{
    public class MainMenuFormPresenterFactory
    {
        private readonly ISceneService _sceneService;
        private readonly IAddressableStorage _addressableStorage;

        public MainMenuFormPresenterFactory(
            ISceneService sceneService,
            IAddressableStorage addressableStorage)
        {
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
            _addressableStorage = addressableStorage ?? throw new ArgumentNullException(nameof(addressableStorage));
        }

        public MainMenuFormPresenter Create(IMainMenuForm view) =>
            new(view, _sceneService, _addressableStorage);
    }
}