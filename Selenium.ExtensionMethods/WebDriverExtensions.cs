namespace Scorchio.Selenium.ExtensionMethods
{
    using System;
    using System.Collections.ObjectModel;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    /// <summary>
    /// WebDriver Extension Methods.
    /// </summary>
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Determines whether the specified by has element.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="by">The by.</param>
        /// <returns>
        ///   <c>true</c> if the specified by has element; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasElement(
            this IWebDriver @this, 
            By by)
        {
            try
            {
                @this.FindElement(by);
            }
            catch (NoSuchElementException)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the body text.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <returns></returns>
        public static string GetBodyText(this IWebDriver @this)
        {
            return @this.FindElement(By.TagName("body")).Text;
        }

        /// <summary>
        /// Gets all web elements.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<IWebElement> GetAllWebElements(this IWebDriver @this)
        {
            return @this.FindElements(By.CssSelector("*"));
        }

        /// <summary>
        /// Gets all input elements.
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<IWebElement> GetAllInputElements(this IWebDriver @this)
        {
            return @this.FindElements(By.TagName("input"));
        }

        /// <summary>
        /// Elements the is present.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="by">The by.</param>
        /// <returns></returns>
        public static bool ElementIsPresent(
            this IWebDriver @this, 
            By by)
        {
            try
            {
                return @this.FindElement(by).Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Waits the until element is present.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="by">The by.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns></returns>
        public static bool WaitUntilElementIsPresent(
            this IWebDriver @this,
            By by, 
            int timeout = 10)
        {
            WebDriverWait wait = new WebDriverWait(@this, TimeSpan.FromSeconds(timeout));
            return wait.Until(d => d.ElementIsPresent(by));
        }

        /// <summary>
        /// Clicks the button.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="buttonId">The button identifier.</param>
        public static void ClickButton(
            this IWebDriver @this, 
            string buttonId)
        {
            @this.FindElement(By.Id(buttonId)).Click();
        }

        /// <summary>
        /// Clicks the link.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="linkText">The link text.</param>
        public static void ClickLink(
            this IWebDriver @this, 
            string linkText)
        {
            @this.FindElement(By.LinkText(linkText)).Click();
        }

        /// <summary>
        /// Determines whether the specified by is checked.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="by">The by.</param>
        /// <returns>
        ///   <c>true</c> if the specified by is checked; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsChecked(
            this IWebDriver @this, 
            By by)
        {
            return @this.FindElement(by).Selected;
        }
    }
}
