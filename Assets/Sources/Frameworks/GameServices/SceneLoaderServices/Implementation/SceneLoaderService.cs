﻿using Cysharp.Threading.Tasks;
using Sources.InfrastructureInterfaces.Services.SceneLoaderService;
using UnityEngine.SceneManagement;

namespace Sources.Frameworks.GameServices.SceneLoaderServices.Implementation
{
    public class SceneLoaderService : ISceneLoaderService
    {
        public async UniTask LoadSceneAsync(string sceneName) =>
            await SceneManager.LoadSceneAsync(sceneName);
    }
}