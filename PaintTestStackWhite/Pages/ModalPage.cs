using TestStack.White.UIItems.Finders;
using TestStackWhiteFramework;

namespace PaintTestStackWhite.Pages
{
    public class ModalPage
    {
        private ButtonElement doNotSaveButton = new ButtonElement("DoNotSaveButton", SearchCriteria.ByAutomationId("CommandButton_7"));
        private ButtonElement NumberButton(string text, string automationId) => new ButtonElement($"{text}Button", SearchCriteria.ByAutomationId($"{automationId}"));

        public void ClickButtonByAutomationId(string text, string automationId)
        {
            NumberButton(text, automationId).Click();
        }
        public void ClickDoNotSaveButton()
        {
            doNotSaveButton.Click();
        }
    }
}
