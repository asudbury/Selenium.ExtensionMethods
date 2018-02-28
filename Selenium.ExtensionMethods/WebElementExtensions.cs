namespace Scorchio.Selenium.ExtensionMethods
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    using System;

    /// <summary>
    /// WebElement Extensions.
    /// </summary>
    public static class WebElementExtensions
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <returns></returns>
        public static string GetValue(this IWebElement @this)
        {
           return @this.GetAttribute("value"); 
        }

        /// <summary>
        /// Gets the CSS class.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <returns></returns>
        public static string GetCssClass(this IWebElement @this)
        {
            return @this.GetAttribute("class");
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <returns></returns>
        public static string GetText(this IWebElement @this)
        {
            return @this.Text;
        }

        /// <summary>
        /// Enters the text, clearing any content first.
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
        /// Press the enter key.
        /// </summary>
        /// <param name="this">The this.</param>
        public static void PressEnter(
            this IWebElement @this)
        {
            @this.SendKeys(Keys.Return);
        }

        /// <summary>
        /// Clears the field.
        /// </summary>
        /// <param name="this">The this.</param>
        public static void Clear(this IWebElement @this)
        {
            if (@this.TagName == "input" || 
                @this.TagName == "textarea")
            {
                @this.Clear();
            }
            else
            {
                @this.SendKeys(Keys.LeftControl + "a");
                @this.SendKeys(Keys.Delete);
            }
        }

        /// <summary>
        /// Sets the focus to the input field.
        /// </summary>
        /// <param name="this">The this.</param>
        public static void SetInputFocus(this IWebElement @this)
        {
            if (@this.TagName == "input")
            {
                @this.SendKeys(string.Empty);
            }
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
