using FirstTaskTestStackWhite.Pages;
using NUnit.Framework;
using System.Threading;
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

        [Given(@"open the calculator and closing instances")]
        public void OpenTheApp()
        {
            App.ApplicationLaunch();
        }
        [When(@"enter 12")]
        public void Enter12()
        {
            calculatorPage.ClickOneButton();
            calculatorPage.ClickTwoButton();
            Thread.Sleep(300);
        }

        [When(@"add with 999")]
        public void Add999()
        {
            calculatorPage.ClickPlusButton();
            for (var i = 0; i<3; i++)
            {
                calculatorPage.ClickNineButton();
                Thread.Sleep(300);
            }
            calculatorPage.ClickEqualsButton();
        }

        [When(@"remember the result M plus")]
        public void RememberTheResult()
        {
            calculatorPage.ClickMPlusButton();
            Thread.Sleep(300);
        }

        [When(@"enter 19")]
        public void Enter19()
        {
            calculatorPage.ClickOneButton();
            calculatorPage.ClickNineButton();
            Thread.Sleep(300);
        }

        [When(@"add with a number in memory MR")]
        public void AddWithMemoryNumber()
        {
            calculatorPage.ClickPlusButton();
            calculatorPage.ClickMRButton();
            calculatorPage.ClickEqualsButton();
            Thread.Sleep(300);
        }

        [Then(@"result is 1030")]
        public void ResultCheck()
        {
            //Assert.AreEqual("1030", SearchCriteria.ByAutomationId("158").ToString());
            Assert.AreEqual("1030", calculatorPage.GetResult());
            Thread.Sleep(3000);
        }
    }
}
