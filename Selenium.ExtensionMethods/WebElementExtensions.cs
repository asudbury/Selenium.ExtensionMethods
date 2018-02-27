namespace Scorchio.Selenium.ExtensionMethods
{
    using OpenQA.Selenium;
    using System;

    /// <summary>
    /// WebElement Extensions.
    /// </summary>
    public static class WebElementExtensions
    {
        /// <summary>
        /// Enters the text.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <param name="text">The text.</param>
        public static void EnterText(
            this IWebElement @this,
            string text)
        {
            @this.Clear();
            @this.SendKeys(text);
        }

        /// <summary>
        /// Determines whether this instance is displayed.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <returns>
        ///   <c>true</c> if the specified this is displayed; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDisplayed(this IWebElement @this)
        {
            bool result;

            try
            {
                result = @this.Displayed;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}
