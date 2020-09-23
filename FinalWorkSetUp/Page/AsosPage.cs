using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using Xamarin.Essentials;

namespace FinalWorkAsos.Page
{
    public class AsosPage : BasePage
    {

        private const string PageAddress = "https://www.asos.com/";


        private IWebElement _accountIcon => Driver.FindElement(By.CssSelector(".\\_3iH_8F6"));
        private IWebElement _accountDropDownSignInButton => Driver.FindElement(By.CssSelector("#myaccount-dropdown > div > div > div > div > span > a:nth-child(1)"));
        //private IWebElement _accountDropDownSignInButton => Driver.FindElement(By.CssSelector(""));
        private IWebElement _accountEmailAddressField => Driver.FindElement(By.Id("EmailAddress"));
        private IWebElement _accountPasswordField => Driver.FindElement(By.Id("Password"));
        private IWebElement _accountSignInButton => Driver.FindElement(By.Id("signin"));
        private IWebElement _clickOutsideIframe => Driver.FindElement(By.CssSelector("#content"));

        // private IWebElement _popupButton => Driver.FindElement(By.Id("recaptcha-verify-button"));

        private IWebElement _searchBox => Driver.FindElement(By.Id("chrome-search"));
        private IWebElement _sortDropDownButton => Driver.FindElement(By.ClassName("_2pwX7b9"));
        private IWebElement _dropDownPriceHighToLow => Driver.FindElement(By.CssSelector("#plp > div > div:nth-child(2) > div > div > div > div.U1c-0Sq > ul > li:nth-child(1) > div > div > div > fieldset > div:nth-child(3) > label"));
        private IWebElement _runningShoesProduct => Driver.FindElement(By.CssSelector("#product-13211359"));
        private IWebElement _productPrice => Driver.FindElement(By.Id("current-price"));
        private IWebElement _productStock => Driver.FindElement(By.Id("current-price"));
        private SelectElement _sizeDropDown => new SelectElement(Driver.FindElement(By.CssSelector("#product-size > section > div > div.size-section > div.colour-size-select")));
        private IWebElement _sizeResult => Driver.FindElement(By.ClassName("product-size"));
        private IWebElement _stockMessage => Driver.FindElement(By.CssSelector("#product-size > section > div > div.grid-row.low-in-stock > span:nth-child(2)"));
        private IWebElement _submitSearchIcon => Driver.FindElement(By.CssSelector("#chrome-sticky-header > div._3wSz5e5 > div > div > form > div > button"));
        private IWebElement _accountSignInMessageText => Driver.FindElement(By.CssSelector("#myaccount-dropdown > div > div > div > div > span.tiqiyps"));
        private IWebElement _searchDeliveryAndReturnsBox => Driver.FindElement(By.CssSelector("#chrome-footer > footer > div._1pKlxSp > div._3RUU0vJ > div > details:nth-child(1) > a:nth-child(4)"));
        private IWebElement _returnsBox => Driver.FindElement(By.ClassName("dr-tabs_link"));
        private IWebElement _changeButton => Driver.FindElement(By.CssSelector("#creative > section > div.dr-country-selector > button"));
        private IWebElement _selectCountryBox => Driver.FindElement(By.CssSelector("#creative > section > div.dr-country-picker.dr-modal_overlay.smaller-height.is-active > div > div.dr-country-picker_search > input"));
        private IWebElement _submitItalyIcon => Driver.FindElement(By.CssSelector("#creative > section > div.dr-country-picker.dr-modal_overlay.is-active > div > div.dr-modal_content > ul > li > a"));
        private IWebElement _returnsPriceText => Driver.FindElement(By.CssSelector("#creative > div:nth-child(5) > article:nth-child(1) > section.dr-option_pricing.is-loaded > h3"));
        private IWebElement _quantityText => Driver.FindElement(By.CssSelector("#plp > div > div._3-pwX1m > div > p"));
        private IWebElement _brandDropDownButton => Driver.FindElement(By.CssSelector("#plp > div > div:nth-child(2) > div > div > div > div.U1c-0Sq > ul > li:nth-child(5) > div > button"));
        private IWebElement _brand7ForAllMankind => Driver.FindElement(By.CssSelector("#plp > div > div:nth-child(2) > div > div > div > div.U1c-0Sq > ul > li:nth-child(5) > div > div > div > ul > li:nth-child(1) > div > label"));
        private IWebElement _mugProduct => Driver.FindElement(By.CssSelector("#product-21624652 > a > div.ERlP6Bx > img"));
        private IWebElement _addToBagBox => Driver.FindElement(By.CssSelector("#product-add > div"));
        private IWebElement _bagIcon => Driver.FindElement(By.CssSelector("#miniBagDropdown"));
        private IWebElement _viewBagBox => Driver.FindElement(By.CssSelector("#minibag-dropdown > div > div > div._3mygsrG > div > div._58IUcq4 > div:nth-child(1) > a"));
        private IWebElement _openMenTab => Driver.FindElement(By.CssSelector("#chrome-sticky-header > div._3wSz5e5 > div > ul._1gfpvjl._2Q6RfP3 > li:nth-child(2) > a"));
        private IWebElement _menNewInTab => Driver.FindElement(By.CssSelector("#chrome-sticky-header > div:nth-child(2) > div:nth-child(2) > nav > div > div._3C_NQPb > button:nth-child(1)"));
        private IWebElement _viewAllButton => Driver.FindElement(By.CssSelector("#chrome-sticky-header > div:nth-child(2) > div:nth-child(2) > nav > div > div:nth-child(2) > div > div._2u0LGMW > ul > li._1g1PWkA._1rF5dEp > ul > li:nth-child(1) > a"));
        private IWebElement _heartIconInProductImage => Driver.FindElement(By.CssSelector("#product-21138704 > button"));
        private IWebElement _heartIconInSavedItemsLocation => Driver.FindElement(By.CssSelector("#chrome-sticky-header > div._3wSz5e5 > div > ul._3fERfnD > li:nth-child(2) > a"));
        private IWebElement _deleteSavedItem => Driver.FindElement(By.CssSelector("#saved-lists-app > main > div > div.loadedItemsWrapper_3QrER > section > ol > li > div > div > div > button.deleteButton_Za13-.deleteButton_2VxuB"));
        private IWebElement _noSavedItemsMessage => Driver.FindElement(By.CssSelector("#saved-lists-app > main > div > div > h2"));



        public AsosPage(IWebDriver webdriver) : base(webdriver)
        { }

        public AsosPage NavigateToPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }

        public AsosPage SelectFromAccountDropDown()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_accountIcon).Perform();
            return this;
        }

        public AsosPage ClickSignInButton()
        {
            _accountDropDownSignInButton.Click();
            return this;
        }
        public AsosPage SignInWithEmail(string email, string password)
        {
            _accountEmailAddressField.Click();
            _accountEmailAddressField.SendKeys(email);
            _accountPasswordField.Click();
            _accountPasswordField.SendKeys(password);

            // Driver.SwitchTo().DefaultContent();
            // GetWait().Until(ExpectedConditions.ElementToBeClickable(By.Id("signin")));

            _clickOutsideIframe.Click();     //make iFrame disapear
            _accountSignInButton.Click();

            return this;
        }

        public AsosPage CheckAccountSignInMessage(string messageText)
        {
            Assert.IsTrue(_accountSignInMessageText.Text.Contains(messageText), "Result is not as expected");
            return this;
        }


        public AsosPage SearchAdidasRunningShoesWomen(string text)
        {
            _searchBox.Click();
            _searchBox.SendKeys(text);
            _submitSearchIcon.Click();
            return this;
        }

        public AsosPage SelectFromSortDropDown()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_sortDropDownButton).Perform();
            _sortDropDownButton.Click();
            builder.MoveToElement(_dropDownPriceHighToLow).Perform();
            _dropDownPriceHighToLow.Click();

            Actions actions = new Actions(Driver);
            actions.MoveToElement(_runningShoesProduct).Perform();
            _runningShoesProduct.Click();
            return this;
        }


        public AsosPage ClickDeliveryReturnsButton()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_searchDeliveryAndReturnsBox).Perform();
            _searchDeliveryAndReturnsBox.Click();
            return this;
        }

        public AsosPage ClickReturnsButton()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_returnsBox).Perform();
            _returnsBox.Click();
            return this;
        }

        public AsosPage ClickChangeCountryButton()
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(_changeButton).Perform();
            _changeButton.Click();
            return this;
        }

        public AsosPage SelectCountryItaly(string country)
        {
            _selectCountryBox.Click();
            _selectCountryBox.SendKeys(country);
            _submitItalyIcon.Click();

            return this;
        }
        public AsosPage CheckDeliveryPriceText(string text)
        {
            Assert.IsTrue(_returnsPriceText.Text.Contains(text), "Result is not as expected");
            return this;
        }



        public AsosPage SearchMug(string searchText)
        {
            _searchBox.Click();
            _searchBox.SendKeys(searchText);
            _submitSearchIcon.Click();
            return this;
        }


        public AsosPage CheckQuantityResultText(string quantityResultText)
        {
            Assert.IsTrue(_quantityText.Text.Contains(quantityResultText), "Result is not as expected");
            return this;
        }

        public AsosPage SortBrand7ForAllMankind()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_brandDropDownButton).Perform();
            _brandDropDownButton.Click();
            builder.MoveToElement(_brand7ForAllMankind).Perform();
            _brand7ForAllMankind.Click();

            Actions actions = new Actions(Driver);
            actions.MoveToElement(_mugProduct).Perform();
            _mugProduct.Click();
            return this;
        }

        public AsosPage AddToShoppingBag()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_addToBagBox).Perform();
            _addToBagBox.Click();

            return this;
        }

        public AsosPage OpenMyBagMenu()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_bagIcon).Perform();
            _bagIcon.Click();
            return this;
        }

        public AsosPage ViewShoppingBag()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_viewBagBox).Perform();
            _viewBagBox.Click();
            return this;
        }

        public AsosPage OpenMenTab()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_openMenTab).Perform();
            _openMenTab.Click();
            return this;
        }
        public AsosPage SelectMenNewInTab()
        {
            _menNewInTab.Click();
            return this;
        }
        public AsosPage SelectViewAllProducts()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_viewAllButton).Perform();
            _viewAllButton.Click();
            return this;
        }

        public AsosPage SaveProductToSavedItems()
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_heartIconInProductImage).Perform();
            _heartIconInProductImage.Click();
            return this;
        }

        public AsosPage ViewSavedItemsAndDeleteFromList()     //failed
        {
            Actions builder = new Actions(Driver);
            builder.MoveToElement(_heartIconInSavedItemsLocation).Perform();
            _heartIconInSavedItemsLocation.Click();
            _deleteSavedItem.Click();
            return this;
        }
        public AsosPage CheckTextMessage(string textMessage)  //not checked
        {
            Assert.IsTrue(_noSavedItemsMessage.Text.Contains(textMessage), "Result is not as expected");
            return this;
        }


        //   public AsosPage SelectFromDropDownShoesSizeEu40ByValue(string size)
        //   {
        //Actions builder = new Actions(Driver);
        //builder.MoveToElement(_sizeDropDown).Perform();
        //       _sizeDropDown.SelectByValue(size);
        //_sizeDropDown.Click();
        //      return this;
        //     }
        // public AsosPage CheckSizeResult(string size) //perduodam i si metoda gauta/pasirinkta savaites diena
        //{

        //   Assert.IsTrue(_sizeResult.Text.Contains(size), $"No such size {size}"); 
        // return this;
        // }

        //   public AsosPage CheckPrice(string price)
        //       {
        //           Assert.IsTrue(_productPrice.Text.Contains(price), "Result is not as expected");
        //           return this;
        //       }


        //   public AsosPage CheckStock(string stock)
        //  {
        //      Assert.IsTrue(_stockMessage.Text.Contains(stock), "Result is not as expected");
        //       return this;
        //   }
    }
}
