using System.Text.Json;
using DromTest.Configuration;
using DromTest.TestingData;

namespace DromTest.ProjectUtils;

public static class JsonBinderUtilities
{
    public static Config? ConfigBinder()
    {
        var json = File.ReadAllText(Pathes.GetConfigSettingFile());
        return JsonSerializer.Deserialize<Config>(json);
    }

    public static TestData? TestDataBinder()
    {
        var json = File.ReadAllText(Pathes.GetTestDataFile());
        return JsonSerializer.Deserialize<TestData>(json);
    }
}