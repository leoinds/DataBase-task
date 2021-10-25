using TechTalk.SpecFlow;
using TestStackWhiteFramework;

namespace FirstTaskTestStackWhite.Hooks
{
    [Binding]
    public class BeforeScenarioHook
    {
        [BeforeScenario]
        public void Precondition()
        {
            //App.CloseProcesses("calc.exe");
            App.CloseProcesses(ConfigurationData.name);
        }
    }
}
