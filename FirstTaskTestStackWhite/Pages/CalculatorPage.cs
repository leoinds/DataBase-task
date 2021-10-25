using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStackWhiteFramework;
using TestStackWhiteFramework.Utils;

namespace FirstTaskTestStackWhite.Pages 
{
    public class CalculatorPage
    {
        private ButtonElement oneButton = new ButtonElement("oneButton", SearchCriteria.ByAutomationId("131"));
        private ButtonElement twoButton = new ButtonElement("twoButton", SearchCriteria.ByAutomationId("132"));
        private ButtonElement nineButton = new ButtonElement("nineButton", SearchCriteria.ByAutomationId("139"));
        private ButtonElement mPlusButton = new ButtonElement("mPlusButton", SearchCriteria.ByAutomationId("125"));
        private ButtonElement mRButton = new ButtonElement("mRButton", SearchCriteria.ByAutomationId("123"));
        private ButtonElement plusButton = new ButtonElement("plusButton", SearchCriteria.ByAutomationId("93"));
        private ButtonElement equalsButton = new ButtonElement("equalsButton", SearchCriteria.ByAutomationId("121"));
        private TextFieldElement resultField = new TextFieldElement("resultField", SearchCriteria.ByAutomationId("150"));
        private TextFieldElement result = new TextFieldElement("resultField", SearchCriteria.ByAutomationId("158"));

        public void ClickOneButton()
        {
            oneButton.Click();
        }
        public void ClickTwoButton()
        {
            twoButton.Click();
        }
        public void ClickPlusButton()
        {
            plusButton.Click();
        }
        public void ClickNineButton()
        {
            nineButton.Click();
        }
        public void ClickEqualsButton()
        {
            equalsButton.Click();
        }
        public void ClickMPlusButton()
        {
            mPlusButton.Click();
        }
        public void ClickMRButton()
        {
            mRButton.Click();
        }
        public string GetResult()
        {
            return
                //App.GetWindow("Calculator").Get<Label>(SearchCriteria.ByAutomationId("150")).Name.ToString();
                App.GetWindow(MyUtil.GetWindowName().ToString()).Get<Label>(SearchCriteria.ByAutomationId("150")).Name.ToString();
        }
    }
}
