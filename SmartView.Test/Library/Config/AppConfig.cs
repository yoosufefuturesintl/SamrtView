using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SmartView.Test.Library.Config
{
    class AppConfig
    {
        /// <summary>
        /// Get the value corresponding to the key from App.config settings
        /// </summary>
        /// <param name="key">The key name</param>
        /// <returns></returns>
        public static String GetValue(String key)
        {
            return ConfigurationSettings.AppSettings[key];
        }
    }
}
