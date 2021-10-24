using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.Finders;
using TestStackWhiteFramework;


namespace FirstTaskTestStackWhite.Pages
{
    public class CalculatorPage
    {
        private ButtonElement okButton = new ButtonElement("okButton", SearchCriteria.ByAutomationId("1005"));
        //все объекты или только те что для теста нужны - все для теста

        private ButtonElement oneButton = new ButtonElement("oneButton", SearchCriteria.ByAutomationId("131"));
        private ButtonElement twoButton = new ButtonElement("twoButton", SearchCriteria.ByAutomationId("132"));
        private ButtonElement nineButton = new ButtonElement("nineButton", SearchCriteria.ByAutomationId("139"));
        private ButtonElement mPlusButton = new ButtonElement("mPlusButton", SearchCriteria.ByAutomationId("125"));
        private ButtonElement mRButton = new ButtonElement("mRButton", SearchCriteria.ByAutomationId("123"));
        private ButtonElement plusButton = new ButtonElement("plusButton", SearchCriteria.ByAutomationId("93"));
        private ButtonElement equalsButton = new ButtonElement("equalsButton", SearchCriteria.ByAutomationId("121"));
        private TextFieldElement resultField = new TextFieldElement("resultField", SearchCriteria.ByAutomationId("150"));

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
            return resultField.ToString();
        }

        public void CliclOkButton()
        {
            okButton.Click(); // клик описывается в base elements? - да
            //чем эти метода отличаются от тех что в base elements? 
        }
    }
}
