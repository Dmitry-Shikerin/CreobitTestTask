using System;
using Infrastructure.Services.Forms;
using InfrastructureInterfaces.Services.Forms;
using Sources.Frameworks.GameServices.Scenes.Services.Implementation;

namespace Infrastructure.Factories.Services.Forms
{
    public class GameplayFormServiceFactory
    {
        private readonly FormService _formService;

        public GameplayFormServiceFactory(
            SceneService sceneService,
            FormService formService)
        {
            _formService = formService ?? throw new ArgumentNullException(nameof(formService));
        }

        public IFormService Create()
        {
            // var hudForm = new Form<HudFormView, HudFormPresenter>(
            //     _hudFormPresenterFactory.Create,
            //     hud.GameplayFormsContainer.HudFormView);
            //
            // _formService.Add(hudForm);
            //
            // Form<PauseMenuFormView, PauseMenuFormPresenter> pauseForm =
            //     new Form<PauseMenuFormView, PauseMenuFormPresenter>(
            //         _pauseMenuFormPresenterFactory.Create,
            //         hud.GameplayFormsContainer.PauseMenuFormView);
            //
            // _formService.Add(pauseForm);
            //
            // Form<UpgradeFormView, UpgradeFormPresenter> upgradeForm =
            //     new Form<UpgradeFormView, UpgradeFormPresenter>(
            //         _upgradeFormPresenterFactory.Create,
            //         hud.GameplayFormsContainer.UpgradeFormView);
            //
            // _formService.Add(upgradeForm);
            //
            // Form<TutorialFormView, TutorialFormPresenter> tutorialForm =
            //     new Form<TutorialFormView, TutorialFormPresenter>(
            //         _tutorialFormPresenterFactory.Create,
            //         hud.GameplayFormsContainer.TutorialFormView);
            //
            // _formService.Add(tutorialForm);
            //
            // Form<LoadFormView, LoadFormPresenter> loadForm = new Form<LoadFormView, LoadFormPresenter>(
            //     _loadFormPresenterFactory.Create,
            //     hud.GameplayFormsContainer.LoadFormView);
            //
            // _formService.Add(loadForm);
            //
            // Form<GameOverFormView, GameOverFormPresenter> gameOverForm =
            //     new Form<GameOverFormView, GameOverFormPresenter>(
            //         _gameOverFormPresenterFactory.Create,
            //         hud.GameplayFormsContainer.GameOverFormView);
            //
            // _formService.Add(gameOverForm);
            //
            // Form<SettingFormView, SettingFormPresenter> settingForm =
            //     new Form<SettingFormView, SettingFormPresenter>(
            //         _settingFormPresenterFactory.Create,
            //         hud.GameplayFormsContainer.SettingFormView);
            //
            // _formService.Add(settingForm);
            //
            // IPlayerUpgradeView playerCharismaUpgradeView = _playerUpgradeViewFactory.Create(
            //         playerUpgrade.Charisma, player.Wallet, hud.PlayerUpgradeViewsContainer.CharismaUpgradeView);
            // IPlayerUpgradeView playerInventoryUpgradeView = _playerUpgradeViewFactory.Create(
            //     playerUpgrade.Inventory, player.Wallet, hud.PlayerUpgradeViewsContainer.InventoryUpgradeView);
            // IPlayerUpgradeView playerMovementUpgradeView = _playerUpgradeViewFactory.Create(
            //         playerUpgrade.Movement, player.Wallet, hud.PlayerUpgradeViewsContainer.MovementUpgradeView);
            //
            // _audioSourceUIFactory.Create(
            //     playerUpgrade.Charisma, hud.CongratulationUpgradeAudioSourceContainer.Charisma);
            // _audioSourceUIFactory.Create(
            //     playerUpgrade.Inventory, hud.CongratulationUpgradeAudioSourceContainer.Inventory);
            // _audioSourceUIFactory.Create(
            //     playerUpgrade.Movement, hud.CongratulationUpgradeAudioSourceContainer.Movement);
            //
            // _buttonUIFactory.Create(
            //     hud.TavernUpgradePointButtons.CharismaButtonUI, playerCharismaUpgradeView.Upgrade);
            // _buttonUIFactory.Create(
            //     hud.TavernUpgradePointButtons.InventoryButtonUI, playerInventoryUpgradeView.Upgrade);
            // _buttonUIFactory.Create(
            //     hud.TavernUpgradePointButtons.MovementButtonUI, playerMovementUpgradeView.Upgrade);
            // _buttonUIFactory.Create(
            //     hud.TavernUpgradePointButtons.AdvertisementButtonUI, () =>
            //     {
            //         hud.TavernUpgradePointButtons.AdvertisementButtonUI.Hide();
            //         _videoAdService.ShowVideo(hud.TavernUpgradePointButtons.AdvertisementButtonUI.Show);
            //     });
            //
            // _buttonUIFactory.Create(hud.PauseMenuButton, hud.GameplayFormsContainer.HudFormView.ShowPauseMenu);
            //
            // _buttonUIFactory.Create(
            //     hud.PauseMenuButtonContainer.AdvertisementButton, () =>
            //     {
            //         hud.PauseMenuButtonContainer.AdvertisementButton.Hide();
            //         _videoAdService.ShowVideo(hud.PauseMenuButtonContainer.AdvertisementButton.Show);
            //     });
            // _buttonUIFactory.Create(hud.PauseMenuButtonContainer.MainMenuButton, async () =>
            //     {
            //         _formService.Show<HudFormView>();
            //
            //         saveAction.Invoke();
            //         _leaderboardScoreSetter.SetPlayerScore(player.Wallet.Score.GetValue);
            //
            //         await _sceneService.ChangeSceneAsync(SceneName.MainMenu);
            //     });
            // _buttonUIFactory.Create(hud.PauseMenuButtonContainer.SaveButton, saveAction.Invoke);
            // _buttonUIFactory.Create(
            //     hud.PauseMenuButtonContainer.CloseButton,
            //     hud.GameplayFormsContainer.PauseMenuFormView.ShowHudFormView);
            // _buttonUIFactory.Create(
            //     hud.PauseMenuButtonContainer.TutorialButton,
            //     hud.GameplayFormsContainer.PauseMenuFormView.ShowTutorialFormView);
            // _buttonUIFactory.Create(
            //     hud.PauseMenuButtonContainer.SettingsButton,
            //     hud.GameplayFormsContainer.PauseMenuFormView.ShowSettingsFormView);
            //
            // _buttonUIFactory.Create(
            //     hud.TutorialFormButtonContainer.CloseButton,
            //     hud.GameplayFormsContainer.TutorialFormView.ShowPauseMenu);
            //
            // _buttonUIFactory.Create(
            //     hud.LoadFormButtonContainer.CloseButton,
            //     hud.GameplayFormsContainer.LoadFormView.ShowHudForm);
            //
            // _buttonUIFactory.Create(hud.GameOverFormButtonContainer.BackToMainMenuButton, async () =>
            //     {
            //         _formService.Show<HudFormView>();
            //
            //         await _sceneService.ChangeSceneAsync(SceneName.MainMenu);
            //     });
            //
            // _buttonUIFactory.Create(
            //     hud.SettingFormButtonContainer.BackToMainMenu,
            //     hud.GameplayFormsContainer.SettingFormView.BackToMainMenu<PauseMenuFormView>);
            // _buttonUIFactory.Create(
            //     hud.SettingFormButtonContainer.IncreaseVolume,
            //     hud.GameplayFormsContainer.SettingFormView.IncreaseVolume);
            // _buttonUIFactory.Create(
            //     hud.SettingFormButtonContainer.TornDownVolume,
            //     hud.GameplayFormsContainer.SettingFormView.TurnDownVolume);
            //
            // _buttonUIFactory.Create(hud.TavernUpgradePointButtons.CloseButtonUI, () =>
            //     {
            //         saveAction.Invoke();
            //
            //         hud.GameplayFormsContainer.UpgradeFormView.ShowHudForm();
            //     });
            //
            // _textUIFactory.Create(hud.GameOverTextContainer.ScoreText, player.Wallet.Score);

            return _formService;
        }
    }
}