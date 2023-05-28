using Core.Selenium;
using Core.Wrappers;
using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Page
{
    public class InventoryPage : BasePage
    {
        //private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        private static readonly By CartIconLocator = By.ClassName("shopping_cart_link");
        private static readonly By FilterDropdownLocator = By.ClassName("product_sort_container");
        private static readonly By MenuButtonLocator = By.Id("react-burger-menu-btn");

        public InventoryPage(IBrowser browser) : base(browser) { }



        public IWebElement? CartIcon
        {
            get
            {
                return _browser?.Driver?.FindElement(CartIconLocator);
            }
            private set { }
        }

        public IWebElement? FilterDropdown
        {
            get
            {
                return _browser?.Driver?.FindElement(FilterDropdownLocator);
            }
            private set { }
        }

        public IWebElement? MenuButton
        {
            get
            {
                return _browser?.Driver?.FindElement(MenuButtonLocator);
            }
            private set { }
        }


        public InventoryPage ClickCartIcon()
        {
            CartIcon?.Click();

            return this;
        }
        public InventoryPage ClickFilterDropdown()
        {
            FilterDropdown?.Click();
            return this;
        }
        public InventoryPage ClickMenuButton()
        {
            MenuButton?.Click();

            return this;
        }

        public override bool IsPageOpened()
        {
            throw new NotImplementedException();
        }

        protected override void OpenPage()
        {
            throw new NotImplementedException();
        }
    }
}