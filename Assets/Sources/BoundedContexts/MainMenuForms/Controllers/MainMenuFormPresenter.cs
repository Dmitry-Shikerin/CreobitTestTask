using System;
using Sources.BoundedContexts.ClicckerAssets.Infrastructure.Services;
using Sources.BoundedContexts.Ids.Domain.Constant;
using Sources.BoundedContexts.MainMenuForms.Presentation.Interfaces;
using Sources.BoundedContexts.WalkerAssets.Infrastructure.Services;
using Sources.Frameworks.GameServices.AddressablesInfr.Storages.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Services.Interfaces;
using Sources.Frameworks.MVPPassiveView.Controllers.Implementation;

namespace Sources.BoundedContexts.MainMenuForms.Controllers
{
    public class MainMenuFormPresenter : PresenterBase
    {
        private readonly IMainMenuForm _view;
        private readonly ISceneService _sceneService;
        private readonly IAddressableStorage _addressableStorage;

        public MainMenuFormPresenter(
            IMainMenuForm view,
            ISceneService sceneService,
            IAddressableStorage addressableStorage)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _sceneService = sceneService ?? throw new ArgumentNullException(nameof(sceneService));
            _addressableStorage = addressableStorage ?? throw new ArgumentNullException(nameof(addressableStorage));
        }

        public override void Enable()
        {
            _view.ClickerButton.AddClickListener(LoadClickerScene);
            _view.LoadClickerAssetsButton.AddClickListener(LoadClickerAssets);
            _view.UnLoadClickerAssetsButton.AddClickListener(UnLoadClickerAssets);
            _view.WalkerButton.AddClickListener(LoadWalkerScene);
            _view.LoadWalkerAssetsButton.AddClickListener(LoadWalkerAssets);
            _view.UnLoadWalkerAssetsButton.AddClickListener(UnLoadWalkerAssets);
        }

        public override void Disable()
        {
            _view.ClickerButton.RemoveClickListener(LoadClickerScene);
            _view.LoadClickerAssetsButton.RemoveClickListener(LoadClickerAssets);
            _view.UnLoadClickerAssetsButton.RemoveClickListener(UnLoadClickerAssets);
            _view.WalkerButton.RemoveClickListener(LoadWalkerScene);
            _view.LoadWalkerAssetsButton.RemoveClickListener(LoadWalkerAssets);
            _view.UnLoadWalkerAssetsButton.RemoveClickListener(UnLoadWalkerAssets);

        }

        private void LoadClickerScene()
        {
            //TODO сделать проверку на наличие ассетов
            _sceneService.ChangeSceneAsync(ModelId.Clicker);
        }

        private void LoadClickerAssets()
        {
            //TODO сделать проверку на подключение к интернету
            _addressableStorage.LoadAsset<ClickerAssetProvider>();
        }

        private void UnLoadClickerAssets() =>
            _addressableStorage.Release<ClickerAssetProvider>();

        private void LoadWalkerScene()
        {
            _sceneService.ChangeSceneAsync(ModelId.Walker);
        }

        private void LoadWalkerAssets()
        {
            //TODO сделать проверку на подключение к интернету
            _addressableStorage.LoadAsset<WalkerAssetProvider>();
        }

        private void UnLoadWalkerAssets()
        {
            _addressableStorage.Release<WalkerAssetProvider>();
        }
    }
}