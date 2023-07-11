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
    class DetailedInformationPage : Form
    {
        private ILabel Transmission =>
            ElementFactory.GetLabel(By.XPath("//div[@class='css-0 epjhnwz1']//div[2]//tr[4]/td"), "Transmission characteristic");
        private ILabel Drive =>
            ElementFactory.GetLabel(By.XPath("//div[@class='css-0 epjhnwz1']//div[2]//tr[5]/td"), "Drive characteristic");
        private ILabel BodyType =>
            ElementFactory.GetLabel(By.XPath("//div[@class='css-0 epjhnwz1']//div[2]//tr[6]/td"), "Body type characteristic");
        private ILabel SteeringWheel =>
            ElementFactory.GetLabel(By.XPath("//div[@class='css-0 epjhnwz1']//div[2]//tr[8]/td"), "Steering wheel characteristic");
        public DetailedInformationPage() : base(By.XPath("/div[@class='css-0 epjhnwz1']"), "Table with characteristics")
        {
        }

        public string GetTransmissionValue()
        {
            return Transmission.GetText();
        }

        public string GetDriveValue()
        {
            return Drive.GetText();
        }

        public string GetBodyTypeValue()
        {
            return BodyType.GetText();
        }

        public string GetSteeringWheelValue()
        {
            return SteeringWheel.GetText();
        }
    }
}
