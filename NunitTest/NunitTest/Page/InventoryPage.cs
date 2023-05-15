using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Page
{
    internal class InventoryPage
    {
        internal class InventoryPage : BasePage
        {
            By CartIconLocator = By.ClassName("shopping_cart_link");

            public InventoryPage() : base()
            {
                Assert.IsTrue(CheckCartIconPresented());
            }

            public bool CheckCartIconPresented()
            {
                return ChromeDriver.FindElement(CartIconLocator).Displayed;
            }
        }
    }
}
