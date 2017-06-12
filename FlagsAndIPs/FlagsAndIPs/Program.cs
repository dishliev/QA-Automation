
using FlagsAndIPs.Models;
using FlagsAndIPs.Pages.ContentPage;
using FlagsAndIPs.Pages.FlagpediaPage;
using FlagsAndIPs.Pages.NavigationPage;
using FlagsAndIPs.Pages.TargetPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FlagsAndIPs
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ChromeDriver driver = new ChromeDriver();

            driver.Url = @"https://www.countries-ofthe-world.com/";

            NavigationPage navPage = new NavigationPage(driver);

            navPage.AllCountry.Click();

            TargetPage targetPage = new TargetPage(driver);
            var countries = targetPage.NamesAllCountry;

            FlagpediaPage flagpediaPage = new FlagpediaPage(driver);

            var names = new List<string>();
            foreach (var countryName in countries)
            {
                if (countryName.Text.Length == 1)
                {
                    continue;
                }else {
               
                        names.Add(countryName.Text.Replace(" ", "-"));           
                 }

            }
            ContentPage contentPage = new ContentPage(driver);
            foreach (var a in names)
            {
                if (a == "Macedonia-(FYROM)")
                {

                    driver.Url = @"http://flagpedia.net/" + "Macedonia";
                } else if (a == "United-Kingdom-(UK)")
                {
                    driver.Url = @"http://flagpedia.net/" + "United-Kingdom";
                }
                else if (a == "Vatican-City-(Holy-See)")
                {
                    driver.Url = @"http://flagpedia.net/" + "Vatican-City";
                }
                else
                {
                    driver.Url = @"http://flagpedia.net/" + a;
                }
            
                Actions actions = new Actions(driver);
                actions.MoveToElement(flagpediaPage.CountryMap);
                actions.Perform();

                var countryInfo = new List<CountryInfo>();
              
                countryInfo.Add(new CountryInfo(contentPage.CountryName.Text,
                                                contentPage.CapitalName.Text,
                                                contentPage.Code.Text

                                                ));

                foreach (var counInfo in countryInfo) {
                    var screenshot = ((ITakesScreenshot)driver).GetScreenshot();

                   
                    screenshot.SaveAsFile($"{counInfo.CountryName}-{counInfo.CapitalName}-{counInfo.Code}" + ".jpeg", ScreenshotImageFormat.Jpeg);
                } }






        }
    }
}



