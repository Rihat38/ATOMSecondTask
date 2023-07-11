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
    class MainPage : Form
    {
        private IButton AdvertButton =>
            ElementFactory.GetButton(By.XPath("//*[@class='css-vsx4mr e18vbajn0']/a"), "Advert button");
        public MainPage() : base(By.XPath("//*[@class='css-1f36sr9 e1m0rp604']"), "Announcement page navigation bar")
        {
        }

        public void ClickAdvertButton()
        {
            AdvertButton.ClickAndWait();
        }
    }
}
