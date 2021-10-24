using FirstTaskTestStackWhite.Pages;
using System;
using TechTalk.SpecFlow;

namespace FirstTaskTestStackWhite.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private CalculatorPage calculatorPage;
        public CalculatorStepDefinitions()
        {
            calculatorPage = new CalculatorPage();
        }
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"click the OK button")]
        public void GivenClickTheOKButton()
        {
            calculatorPage.CliclOkButton();
            //тут метода с пейджс? - да
            //тут объект всегда калкпейдж? - да
            //т.е. мы пишем обертку для метода в бейзэлемнтс, после чего пишем метод в пейджс, и с этим методом взаимодействуем в степдефинишенах- да
        }

    }
}
