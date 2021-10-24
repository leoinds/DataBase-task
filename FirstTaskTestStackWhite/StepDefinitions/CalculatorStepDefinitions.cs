using FirstTaskTestStackWhite.Pages;
using System;
using TechTalk.SpecFlow;
using TestStackWhiteFramework;

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
        [BeforeScenario]
        [Given(@"open the calculator and closing instances")]
        public void OpenTheApp()
        {
            App.ApplicationLaunch();
        }

        [When(@"enter 12")]
        public void Enter12()
        {

        }

        [When(@"add with 999")]
        public void Add999()
        {

        }

        [When(@"remember the result M plus")]
        public void RememberTheResult()
        {

        }

        [When(@"enter 19")]
        public void Enter19()
        {

        }

        [When(@"add with a number in memory MR")]
        public void AddWithMemoryNumber()
        {

        }

        [AfterScenario]
        [Then(@"result is 1030")]
        public void ResultCheck()
        {

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
