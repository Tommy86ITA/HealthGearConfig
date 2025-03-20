// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace HealthGearConfig.Models
{
    public class ConfigData
    {
        public required int ServerPort { get; set; }
        public required string DatabasePath { get; set; }
        public required string UploadFolderPath { get; set; }
        public required string AllowedHosts { get; set; }

        public static ConfigData CreateDefault()
        {
            return new ConfigData
            {
                ServerPort = 5001,
                DatabasePath = "C:\\ProgramData\\HealthGear\\healthgear.db",
                UploadFolderPath = "C:\\HealthGear\\Uploads",
                AllowedHosts = "localhost,0.0.0.0,[::]"
            };
        }
    }
}
