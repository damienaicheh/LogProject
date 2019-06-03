using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace LogProject
{
    public class CloudLogService : ICloudLogService
    {
        public void Initialize(string secretKey)
        {
            Microsoft.AppCenter.AppCenter.Start(secretKey, typeof(Analytics), typeof(Crashes));
        }

        public void LogEvent(string name, Dictionary<string, string> properties = null)
        {
            Analytics.TrackEvent(name, properties);
        }

        public void LogError(Exception ex, Dictionary<string, string> properties = null)
        {
            Crashes.TrackError(ex, properties);
        }
    }
}
