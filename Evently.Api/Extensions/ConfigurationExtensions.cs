namespace Evently.Api.Extensions;

public static class ConfigurationExtensions
{
    internal static void AddModuleConfiguration(this IConfigurationBuilder configurationBuilder, string[] modules)
    {
        foreach (var module in modules)
        {
            configurationBuilder.AddJsonFile($"modules.{module}.json",false,true);
            configurationBuilder.AddJsonFile($"modules.{module}.Developmnet.json",true,true);
        }
    }
}