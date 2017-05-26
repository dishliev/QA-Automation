using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.SearchBySize
{
    public partial class SearchBySizePage
    {
      
        public IWebElement JeepTyreType
        {
            get
            {
               return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1\"]/div/ul/li[2]/a"));
            }
        }
        public IWebElement CarTyreType
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1\"]/div/ul/li[1]/a"));
            }
        }
        public IWebElement LightTruckTyreType
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1\"]/div/ul/li[3]/a"));
            }
        }
        public IWebElement TruckTyreType
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1\"]/div/ul/li[4]/a"));
            }
        }
        public IWebElement SummerTyres
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[1]/ul/li[1]/a"));
            }
        }
        public IWebElement WinterTyres
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[1]/ul/li[2]/a"));
            }
        }
        public IWebElement AllSeasonTyres
        {
            get                                          
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[1]/ul/li[3]/a"));
            }
        }
        public IWebElement Width
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"listTireWidth\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"listTireWidth\"]"));
            }
        }
        public SelectElement WidthOptions
        {
            get
            {
                return new SelectElement(Width);
            }
        }
        
        public IWebElement Diameter
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"listDiameter\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"listDiameter\"]"));
            }
        }
        public SelectElement DiameterOptions
        {
            get
            {
                return new SelectElement(Diameter);
            }
        }
        public IWebElement Ratio
        {
            get
            {
              
                WebDriverWait wait1 = new WebDriverWait(Driver, new TimeSpan(10));
                wait1.IgnoreExceptionTypes(typeof(StaleElementReferenceException));

                return wait1.Until(d => d.FindElement(By.XPath("//*[@id=\"listAspectRatio\"]")));
             
            }
        }
        public SelectElement RatioOptions
        {
            get
            {
                return new SelectElement(Ratio);
            }
        }
        public IWebElement Brand
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"listTireBrand\"]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"listTireBrand\"]"));
            }
        }
         public SelectElement BrandOptions
        {
            get
            {
                return new SelectElement(Brand);
            }
        }
        public IWebElement Runflat
        {
            get
            {
                this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"tab-1-inner\"]/div[7]/label[1]")));
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[7]/label[1]"));
            }
        }
        public IWebElement XL
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[7]/label[2]"));
            }
        }
        public IWebElement ButtonShowResults
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/a"));
            }
        }
        public IWebElement TyreSizeResult
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sb-site\"]/div[2]/div[2]/div[2]/div[3]/div[1]/div[4]"));
            }
        }
        public IWebElement SummerTyreCheckBoxClass
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[1]/ul/li[1]"));
            }
        }
        public IWebElement WinterTyreCheckBoxClass
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[1]/ul/li[2]"));
            }
        }
        public IWebElement AllSeasonTyreCheckBoxClass
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"tab-1-inner\"]/div[1]/ul/li[3]"));
            }
        }
        public IWebElement RunflatAndXLSearchResult
        {
            get
            {
                return this.Driver.FindElement(By.XPath("//*[@id=\"sb-site\"]/div[2]/div[2]/div[2]/div[6]/div[1]/div[3]/a"));
            }
        }
    }
}
