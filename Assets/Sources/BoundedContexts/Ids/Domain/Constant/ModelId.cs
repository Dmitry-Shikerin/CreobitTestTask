﻿using System;
using System.Collections.Generic;
using Sources.Frameworks.GameServices.Volumes.Domain.Models.Implementation;

namespace Sources.BoundedContexts.Ids.Domain.Constant
{
    public static class ModelId
    {
        //gameModels
        public const string HealthUpgrade = "HealthUpgrade";
        public const string AttackUpgrade = "AttackUpgrade";
        public const string NukeUpgrade = "NukeUpgrade";
        public const string FlamethrowerUpgrade = "FlamethrowerUpgrade";
        public const string PlayerWallet = "PlayerWallet";
        public const string Bunker = "Bunker";
        public const string EnemySpawner = "EnemySpawner";
        public const string SpawnAbility = "SpawnAbility";
        public const string NukeAbility = "NukeAbility";
        public const string FlamethrowerAbility = "FlamethrowerAbility";
        public const string KillEnemyCounter = "KillEnemyCounter";

        //commonModels
        public const string ClickerGame = "ClickerGame";
        public const string WalkerGame = "WalkerGame";
        public const string ScoreCounter = "ScoreCounter";
        public const string MainMenu = "MainMenu";
        public const string SavedLevel = "SavedLevel";
        public const string Volume = "Volume";
        public const string GameData = "GameData";
        public const string Tutorial = "Tutorial";
        public const string Gameplay = "Gameplay";

        public static IReadOnlyList<string> DeletedModelsIds { get; } = new List<string>()
        {
            PlayerWallet,
            KillEnemyCounter,
        };
        
        public static IReadOnlyList<string> ModelsIds { get; } = new List<string>()
        {
            ScoreCounter,
            SavedLevel,
            GameData,
            Gameplay,
            Volume,
            PlayerWallet,
            KillEnemyCounter,
            Tutorial,
        };

        public static IReadOnlyDictionary<string, Type> Types { get; } = new Dictionary<string, Type>()
        {
            [Volume] = typeof(Volume),
        };
    }
}