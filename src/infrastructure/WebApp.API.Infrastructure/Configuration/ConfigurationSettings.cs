using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.API.Infrastructure.Configuration
{
    public static class ConfigurationSettings
    {
        private static ApiConfigurationSettings _apiConfigurationSettings = new ApiConfigurationSettings();

        public static ApiConfigurationSettings ApiConfigurationSettings
        {
            get
            {
                return _apiConfigurationSettings;
            }
            set
            {
                _apiConfigurationSettings = value;
            }
        }
    }
}
