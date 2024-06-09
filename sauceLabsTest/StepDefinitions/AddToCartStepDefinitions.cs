﻿using sauceDemoTest.PageObjects;

namespace sauceDemoTest.StepDefinitions
{
    [Binding]
    public class addToCartStepDefinitions
    {
        private readonly BasePageObject _loginPageObject;
        private readonly InventoryPageObject _productPageObject;

        public addToCartStepDefinitions(BasePageObject loginPageObject, InventoryPageObject productPageObject)
        {
            _loginPageObject = loginPageObject;
            _productPageObject = productPageObject;
        }


        [When(@"I add (.*) to the cart")]
        public void WhenIAddItemToTheCart(String item)
        {
            _productPageObject.clickAddToCartButton(item);
        }

        // This step definition is used to verify that the item was added to the cart
        // Assertion is on the product page object
        [Then(@"the cart is updated with the (.*)")]
        public void ThenTheCartIsUpdatedWithTheItem(String item)
        {
            _productPageObject.confirmItemCanBeRemoved(item);
        }

    }
}