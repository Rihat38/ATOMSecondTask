using Aquality.Selenium.Browsers;
using DromTest.Configuration;
using DromTest.ProjectUtils;
using DromTest.TestingData;

namespace DromTest.TestCases;

public class BaseTest
{
    protected static Browser? Browser;
    protected static readonly Config Config = JsonBinderUtilities.ConfigBinder()!;
    protected static readonly TestData TestData = JsonBinderUtilities.TestDataBinder()!;

    [SetUp]
    public void Setup()
    {
        Browser = AqualityServices.Browser;
        Browser.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        Browser?.Quit();
    }
}