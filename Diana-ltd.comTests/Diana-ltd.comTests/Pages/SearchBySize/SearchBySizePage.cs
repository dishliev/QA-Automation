using Diana_ltd.comTests.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diana_ltd.comTests.Pages.SearchBySize
{
    public partial class SearchBySizePage : BasePage
    {
       
        public SearchBySizePage(IWebDriver driver)
            : base(driver)
        {
            AccessExcelData.fileName = "TyreData.xlsx";
        }

        public string URL
        {
            get
            {
                return url;
            }
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.URL);
        }

        public void ChooseSummerTyres()
        {
            var builder = new Actions(this.Driver);

            var select = builder.Click(SummerTyres);

            select.Perform();
        }
        public void ChooseWinterTyres()
        {
            var builder = new Actions(this.Driver);

            var select = builder.Click(WinterTyres);

            select.Perform();
        }
        public void ChooseAllSeasonTyres()
        {
            var builder = new Actions(this.Driver);

            var select = builder.Click(AllSeasonTyres);

            select.Perform();
        }

        public void RunflatBoxSelect() {
           
            Runflat.Click();
            ButtonShowResults.Click();
        }
        public void XLBoxSelect()
        {

            XL.Click();
            ButtonShowResults.Click();
        }
        public void RUnflatAndXLBoxSelect()
        {
            Runflat.Click();
            XL.Click();
            ButtonShowResults.Click();
        }

        public void FillFormSearchTyre(SearchBySizeTyre tyre)
        {

          
                    WidthOptions.SelectByText(tyre.Width);
                    DiameterOptions.SelectByText(tyre.Diameter);
                    RatioOptions.SelectByText(tyre.Ratio);
                    BrandOptions.SelectByText(tyre.Brand);

                    ButtonShowResults.Click();
              
          
        }

      

        private void ClickOnElements(List<IWebElement> elements, string conditions)
        {

            var choices = conditions.Split();

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i].Equals("true"))
                {
                    elements[i].Click();
                }
            }
        }


        private void Type(IWebElement element, string text)
        {
            string fieldEmpty = "String.Empty";

            element.Click();
            if (!text.Equals(fieldEmpty))
            {

                element.SendKeys(text);


            }
        }




    }
}
