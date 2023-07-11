using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DromTest.ProjectUtils.Pages
{
    class AdvertPage : Form
    {
        private IButton BrandFilter =>
            ElementFactory.GetButton(By.XPath("//*[contains(@name, 'filters')]//input[@placeholder='Марка']"), "Car brand filter");
        private IButton ModelFilter =>
            ElementFactory.GetButton(By.XPath("//*[contains(@name, 'filters')]//input[@placeholder='Модель']"), "Car model filter");
        private IButton SubmitButton =>
            ElementFactory.GetButton(By.XPath("//*[contains(@name, 'filters')]//button[@type='submit']"), "Submit button");
        private IButton ModalBrandFilter =>
            ElementFactory.GetButton(By.XPath("//div[@data-ftid='component_select_dropdown']/div/div[3]"), "Modal brand filter");
        private IButton ModalModelFilter =>
            ElementFactory.GetButton(By.XPath("//*[@aria-label='Модель']//div[@data-ftid='component_select_dropdown']/div/div[3]"), "Modal model filter");
        private IButton StartYearFilter =>
            ElementFactory.GetButton(By.XPath("//div[@aria-label='Год от']"), "Car year start filter");
        private IButton ModalStartYearFilter =>
            ElementFactory.GetButton(By.XPath("//div[@aria-label='Год от']/div/div[3]"), "Modal start yesr filter");
        private IButton FirstAd =>
            ElementFactory.GetButton(By.XPath("//div[contains(@class, 'css-1nvf6xk eojktn00')]//a"), "First advert");

        private string firstAdvertNameXPath = "//div[contains(@class, 'css-1nvf6xk eojktn00')]//a//span[contains(text(), '{0}')]";

        public AdvertPage() : base(By.XPath("//*[contains(@name, 'filters')]"), "Field with filters")
        {
        }

        public void SpecifyBrand(string brand)
        {
            BrandFilter.Click();
            BrandFilter.SendKeys(brand);
            Thread.Sleep(1000);
        }

        public void AcceptBrandFilter()
        {
            ModalBrandFilter.State.WaitForClickable();
            ModalBrandFilter.Click();
        }

        public void SpecifyModel(string model)
        {
            ModelFilter.Click();
            ModelFilter.SendKeys(model);
            Thread.Sleep(1000);
        }

        public void AcceptModelFilter()
        {
            ModalModelFilter.State.WaitForClickable();
            ModalModelFilter.Click();
        }

        public void SubmitFilter()
        {
            SubmitButton.Click();
        }

        public void SpecifyStartYear()
        {
            StartYearFilter.Click();
        }

        public void AcceptStartYear()
        {
            ModalStartYearFilter.Click();
        }

        public void SelectFirstAd()
        {
            FirstAd.Click();
            Thread.Sleep(5000);
        }

        public bool IsAdsOfSelectedBrandDisplayed(string brand)
        {
            var brandAds = String.Format(firstAdvertNameXPath, brand);
            return ElementFactory.GetLabel(By.XPath(brandAds), "First advert name").State.WaitForDisplayed();
        }
    }
}

