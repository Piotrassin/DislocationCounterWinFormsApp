
using System.Configuration;

namespace DislocationCounterWinForms
{
    public static class ConfigConstants
    {
        public static int DefaultThresholdValue { get; set; } = Int32.Parse(ConfigurationManager.AppSettings["defaultThresholdValue"] ?? throw new ConfigurationException("configuration file invalid"));
        public static decimal DefaultMaxErrorValue { get; set; } = decimal.Parse(ConfigurationManager.AppSettings["defaultMaxErrorValue"] ?? throw new ConfigurationException("configuration file invalid"));
        public static decimal DefaultMinViableAreaValue { get; set; } = decimal.Parse(ConfigurationManager.AppSettings["defaultMinViableAreaValue"] ?? throw new ConfigurationException("configuration file invalid"));
        public static decimal DefaultMaxViableAreaValue { get; set; } = decimal.Parse(ConfigurationManager.AppSettings["defaultMaxViableAreaValue"] ?? throw new ConfigurationException("configuration file invalid"));
        public static decimal MaximumViableAreaValue { get; set; } = decimal.Parse(ConfigurationManager.AppSettings["maximumViableAreaValue"] ?? throw new ConfigurationException("configuration file invalid"));
        public static decimal MinimumViableAreaValue { get; set; } = decimal.Parse(ConfigurationManager.AppSettings["minimumViableAreaValue"] ?? throw new ConfigurationException("configuration file invalid"));
    }
}
