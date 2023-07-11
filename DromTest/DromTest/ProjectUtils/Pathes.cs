using System.Reflection;

namespace DromTest.ProjectUtils;

public static class Pathes
{
    private static readonly string Prefix;
    private static readonly char Separator;

    static Pathes()
    {
        var cd = Directory.GetCurrentDirectory();
        var name = Assembly.GetExecutingAssembly().GetName().Name;
        Prefix = Path.Combine(cd.Split(name)[0], name!);
        Separator = Path.DirectorySeparatorChar;
    }

    public static string GetConfigSettingFile() =>
        Prefix + $"{Separator}DromTest{Separator}Configuration{Separator}configsettings.json";
    public static string GetTestDataFile() =>
        Prefix + $"{Separator}DromTest{Separator}TestingData{Separator}testdata.json";
}