﻿using System;
using System.Collections.Generic;

namespace LogProject
{
    public interface ICloudLogService
    {
        void Initialize(string secretKey);

        void LogEvent(string name, Dictionary<string, string> properties = null);

        void LogError(Exception ex, Dictionary<string, string> properties = null);
    }
}
