using TechTalk.SpecFlow;
using TestStackWhiteFramework;

namespace FirstTaskTestStackWhite.Hooks
{
    [Binding]
    public class BeforeScenarioHook
    {
        [BeforeScenario]
        public void Postcondition()
        {
            App.CloseProcesses("calc.exe");
        }
    }
}
