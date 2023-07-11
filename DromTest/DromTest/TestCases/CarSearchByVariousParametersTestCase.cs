using DromTest.Configuration;
using DromTest.ProjectUtils;
using DromTest.ProjectUtils.Pages;
using DromTest.TestCases;

namespace DromTest.TestCases;

class CarSearchByVariousParametersTestCase : BaseTest
{
    [Test]
    public void CarSearchByVariousParametersTest()
    {
        Browser!.GoTo(Config.AppUrl);
        var mainPage = new MainPage();
        mainPage.ClickAdvertButton();
        var advPage = new AdvertPage();
        Steps.SpecifyCarBrand();
        //Проверка на то, что отобразились автомобили марки Honda
        Assert.That(advPage.IsAdsOfSelectedBrandDisplayed(TestData.Brand!), Is.True);
        Steps.SpecifyCarModel();
        //Проверка на то, что дополнительный фильтр применился и в списке отображены автомобили Honda Civic
        Assert.That(advPage.IsAdsOfSelectedBrandDisplayed(TestData.Brand + " " + TestData.Model!), Is.True);
    }
}
