<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [WebDriverExtensions](#T-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions')
  - [ClickButton(this,buttonId)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ClickButton-OpenQA-Selenium-IWebDriver,System-String- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.ClickButton(OpenQA.Selenium.IWebDriver,System.String)')
  - [ClickLink(this,linkText)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ClickLink-OpenQA-Selenium-IWebDriver,System-String- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.ClickLink(OpenQA.Selenium.IWebDriver,System.String)')
  - [ElementIsPresent(this,by)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ElementIsPresent-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.ElementIsPresent(OpenQA.Selenium.IWebDriver,OpenQA.Selenium.By)')
  - [GetAllElements()](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetAllElements-OpenQA-Selenium-IWebDriver- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.GetAllElements(OpenQA.Selenium.IWebDriver)')
  - [GetAllInputElements()](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetAllInputElements-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.GetAllInputElements(OpenQA.Selenium.IWebDriver,OpenQA.Selenium.By)')
  - [GetBodyText(this)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetBodyText-OpenQA-Selenium-IWebDriver- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.GetBodyText(OpenQA.Selenium.IWebDriver)')
  - [GetElements(this,by)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetElements-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.GetElements(OpenQA.Selenium.IWebDriver,OpenQA.Selenium.By)')
  - [HasElement(this,by)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-HasElement-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.HasElement(OpenQA.Selenium.IWebDriver,OpenQA.Selenium.By)')
  - [IsChecked(this,by)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-IsChecked-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.IsChecked(OpenQA.Selenium.IWebDriver,OpenQA.Selenium.By)')
  - [SaveScreenShot(this,filePath)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-SaveScreenShot-OpenQA-Selenium-IWebDriver,System-String- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.SaveScreenShot(OpenQA.Selenium.IWebDriver,System.String)')
  - [WaitUntilElementIsPresent(this,by,timeout)](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-WaitUntilElementIsPresent-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By,System-Int32- 'Scorchio.Selenium.ExtensionMethods.WebDriverExtensions.WaitUntilElementIsPresent(OpenQA.Selenium.IWebDriver,OpenQA.Selenium.By,System.Int32)')
- [WebElementExtensions](#T-Scorchio-Selenium-ExtensionMethods-WebElementExtensions 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions')
  - [Clear(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-Clear-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.Clear(OpenQA.Selenium.IWebElement)')
  - [EnterText(this,text)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-EnterText-OpenQA-Selenium-IWebElement,System-String- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.EnterText(OpenQA.Selenium.IWebElement,System.String)')
  - [GetCssClass(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetCssClass-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.GetCssClass(OpenQA.Selenium.IWebElement)')
  - [GetText(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetText-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.GetText(OpenQA.Selenium.IWebElement)')
  - [GetValue(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetValue-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.GetValue(OpenQA.Selenium.IWebElement)')
  - [IsDisplayed(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-IsDisplayed-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.IsDisplayed(OpenQA.Selenium.IWebElement)')
  - [PressEnter(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-PressEnter-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.PressEnter(OpenQA.Selenium.IWebElement)')
  - [SetInputFocus(this)](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-SetInputFocus-OpenQA-Selenium-IWebElement- 'Scorchio.Selenium.ExtensionMethods.WebElementExtensions.SetInputFocus(OpenQA.Selenium.IWebElement)')

<a name='assembly'></a>
# Scorchio.Selenium.ExtensionMethods [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions'></a>
## WebDriverExtensions [#](#T-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.Selenium.ExtensionMethods

##### Summary

WebDriver Extension Methods.

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ClickButton-OpenQA-Selenium-IWebDriver,System-String-'></a>
### ClickButton(this,buttonId) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ClickButton-OpenQA-Selenium-IWebDriver,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Clicks the button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| buttonId | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The button identifier. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ClickLink-OpenQA-Selenium-IWebDriver,System-String-'></a>
### ClickLink(this,linkText) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ClickLink-OpenQA-Selenium-IWebDriver,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Clicks the link.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| linkText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The link text. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ElementIsPresent-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By-'></a>
### ElementIsPresent(this,by) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-ElementIsPresent-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Elements the is present.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| by | [OpenQA.Selenium.By](#T-OpenQA-Selenium-By 'OpenQA.Selenium.By') | The by. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetAllElements-OpenQA-Selenium-IWebDriver-'></a>
### GetAllElements() `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetAllElements-OpenQA-Selenium-IWebDriver- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets all elements.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetAllInputElements-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By-'></a>
### GetAllInputElements() `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetAllInputElements-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets all input elements.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetBodyText-OpenQA-Selenium-IWebDriver-'></a>
### GetBodyText(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetBodyText-OpenQA-Selenium-IWebDriver- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the body text.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetElements-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By-'></a>
### GetElements(this,by) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-GetElements-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the elements.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| by | [OpenQA.Selenium.By](#T-OpenQA-Selenium-By 'OpenQA.Selenium.By') | The by. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-HasElement-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By-'></a>
### HasElement(this,by) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-HasElement-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether the specified by has element.

##### Returns

`true` if the specified by has element; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| by | [OpenQA.Selenium.By](#T-OpenQA-Selenium-By 'OpenQA.Selenium.By') | The by. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-IsChecked-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By-'></a>
### IsChecked(this,by) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-IsChecked-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether the specified by is checked.

##### Returns

`true` if the specified by is checked; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| by | [OpenQA.Selenium.By](#T-OpenQA-Selenium-By 'OpenQA.Selenium.By') | The by. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-SaveScreenShot-OpenQA-Selenium-IWebDriver,System-String-'></a>
### SaveScreenShot(this,filePath) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-SaveScreenShot-OpenQA-Selenium-IWebDriver,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Saves the screen shot.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| filePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file path. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-WaitUntilElementIsPresent-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By,System-Int32-'></a>
### WaitUntilElementIsPresent(this,by,timeout) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebDriverExtensions-WaitUntilElementIsPresent-OpenQA-Selenium-IWebDriver,OpenQA-Selenium-By,System-Int32- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Waits the until element is present.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebDriver](#T-OpenQA-Selenium-IWebDriver 'OpenQA.Selenium.IWebDriver') | The this. |
| by | [OpenQA.Selenium.By](#T-OpenQA-Selenium-By 'OpenQA.Selenium.By') | The by. |
| timeout | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The timeout. |

<a name='T-Scorchio-Selenium-ExtensionMethods-WebElementExtensions'></a>
## WebElementExtensions [#](#T-Scorchio-Selenium-ExtensionMethods-WebElementExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.Selenium.ExtensionMethods

##### Summary

WebElement Extensions.

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-Clear-OpenQA-Selenium-IWebElement-'></a>
### Clear(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-Clear-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Clears the field.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-EnterText-OpenQA-Selenium-IWebElement,System-String-'></a>
### EnterText(this,text) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-EnterText-OpenQA-Selenium-IWebElement,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Enters the text, clearing any content first.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The text. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetCssClass-OpenQA-Selenium-IWebElement-'></a>
### GetCssClass(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetCssClass-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the CSS class.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetText-OpenQA-Selenium-IWebElement-'></a>
### GetText(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetText-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the text.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetValue-OpenQA-Selenium-IWebElement-'></a>
### GetValue(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-GetValue-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-IsDisplayed-OpenQA-Selenium-IWebElement-'></a>
### IsDisplayed(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-IsDisplayed-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is displayed.

##### Returns

`true` if the specified this is displayed; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-PressEnter-OpenQA-Selenium-IWebElement-'></a>
### PressEnter(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-PressEnter-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Press the enter key.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |

<a name='M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-SetInputFocus-OpenQA-Selenium-IWebElement-'></a>
### SetInputFocus(this) `method` [#](#M-Scorchio-Selenium-ExtensionMethods-WebElementExtensions-SetInputFocus-OpenQA-Selenium-IWebElement- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sets the focus to the input field.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [OpenQA.Selenium.IWebElement](#T-OpenQA-Selenium-IWebElement 'OpenQA.Selenium.IWebElement') | The this. |
