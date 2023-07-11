using Aquality.Selenium.Browsers;
using DromTest.Configuration;
using DromTest.ProjectUtils.Pages;
using DromTest.TestingData;

namespace DromTest.ProjectUtils
{
    class Steps
    {
        private static TestData _testData;
        private static TestData GetTestData
        {
            get
            {
                if (_testData == null)
                    _testData = JsonBinderUtilities.TestDataBinder()!;
                return _testData;
            }
        }

        public static void SpecifyCarBrand()
        {
            var advertPage = new AdvertPage();
            Assert.That(advertPage.State.WaitForDisplayed(), Is.True);
            advertPage.SpecifyBrand(GetTestData.Brand!);
            advertPage.AcceptBrandFilter();
            advertPage.SubmitFilter();
        }

        public static void SpecifyCarModel()
        {
            var advertPage = new AdvertPage();
            advertPage.SpecifyModel(GetTestData.Model!);
            advertPage.AcceptModelFilter();
            advertPage.SubmitFilter();
        }

        public static void SpecifyStartYear() 
        {
            var advertPage = new AdvertPage();
            advertPage.SpecifyStartYear();
            advertPage.AcceptStartYear();
            advertPage.SubmitFilter();
        }
    }
}
