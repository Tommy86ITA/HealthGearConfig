// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using HealthGearConfig.Models;

namespace HealthGearConfig.Services
{
    public class StartupManager
    {
        private readonly ConfigFileManager _configManager;

        public bool IsServiceInstalled { get; private set; }
        public bool IsServiceRunning { get; private set; }
        public ConfigData Settings => _configManager.Settings!;

        public StartupManager()
        {
            _configManager = new ConfigFileManager();
            Initialize();
        }

        private void Initialize()
        {
            // Verifica se il servizio è installato
            IsServiceInstalled = ServiceManager.IsServiceInstalled();

            if (IsServiceInstalled)
            {
                try
                {
                    // Verifica lo stato del servizio solo se installato
                    IsServiceRunning = ServiceManager.IsServiceRunning();
                }
                catch (InvalidOperationException)
                {
                    IsServiceRunning = false;
                }
            }
            else
            {
                IsServiceRunning = false;
            }

            // Carica la configurazione
            _configManager.LoadConfig();
        }
    }
}
