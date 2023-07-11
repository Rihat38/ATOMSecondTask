using Aquality.Selenium.Browsers;
using DromTest.Configuration;
using DromTest.ProjectUtils;
using DromTest.ProjectUtils.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DromTest.TestCases
{
    class ViewAdDetailsTestCase: BaseTest
    {
        [Test]
        public void ViewAdDetailsTest()
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
            Steps.SpecifyStartYear();
            //Проверка на то, что дополнительный фильтр применился и в списке отображены автомобили Honda Civic 2023
            Assert.That(advPage.IsAdsOfSelectedBrandDisplayed(TestData.Year!), Is.True);
            advPage.SelectFirstAd();

            var adDetails = new DetailedInformationPage();
            //Проверка на то, что трансмиссия совпадает с запланированным значением
            Assert.That(adDetails.GetTransmissionValue().Equals(TestData.Transmission), Is.True);
            //Проверка на то, что привод совпадает с запланированным значением
            Assert.That(adDetails.GetDriveValue().Equals(TestData.Drive), Is.True);
            //Проверка на то, что тип кузова совпадает с запланированным значением
            Assert.That(adDetails.GetBodyTypeValue().Equals(TestData.BodyType), Is.True);
            //Проверка на то, что расположение руля совпадает с запланированным значением
            Assert.That(adDetails.GetSteeringWheelValue().Equals(TestData.Wheel), Is.True);
        }
    }
}
