using System;
using Sources.BoundedContexts.Ids.Domain.Constant;
using Sources.BoundedContexts.Scenes.Domain;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Domain.Implementation;
using Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Interfaces;
using Sources.Frameworks.GameServices.Scenes.Domain.Interfaces;

namespace Sources.BoundedContexts.Scenes.Infrastructure.Factories.Views.Implementation
{
    public class GameplaySceneViewFactory : ISceneViewFactory
    {
        private readonly GameplayModelsCreatorService _gameplayModelsCreatorService;
        private readonly GameplayModelsLoaderService _gameplayModelsLoaderService;

        public GameplaySceneViewFactory(
            GameplayModelsCreatorService gameplayModelsCreatorService,
            GameplayModelsLoaderService gameplayModelsLoaderService)
        {
            _gameplayModelsCreatorService = gameplayModelsCreatorService ?? 
                                            throw new ArgumentNullException(nameof(gameplayModelsCreatorService));
            _gameplayModelsLoaderService = gameplayModelsLoaderService ?? 
                                           throw new ArgumentNullException(nameof(gameplayModelsLoaderService));
        }

        public void Create(IScenePayload payload)
        {
            GameplayModel gameplayModel = Load(payload);
        }

        private GameplayModel Load(IScenePayload payload)
        {
            if (payload != null && payload.CanLoad)
                return _gameplayModelsLoaderService.Load();
            
            return _gameplayModelsCreatorService.Load();
        }
    }
}