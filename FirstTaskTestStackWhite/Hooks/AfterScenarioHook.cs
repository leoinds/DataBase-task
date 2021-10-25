using TechTalk.SpecFlow;
using TestStackWhiteFramework;

namespace FirstTaskTestStackWhite.Hooks
{
    [Binding]
    public class AfterScenarioHook
    {
        [AfterScenario]
        public void Postcondition()
        {
            //App.CloseProcesses("calc.exe");
            App.CloseProcesses(ConfigurationData.name);
            App.CloseApplication();
        }
    }
}
