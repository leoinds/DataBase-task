using TechTalk.SpecFlow;
using TestStackWhiteFramework;
using TestStackWhiteFramework.Utils;

namespace FirstTaskTestStackWhite.Hooks
{
    [Binding]
    public class AfterScenarioHook
    {
        [AfterScenario]
        public void Postcondition()
        {
            App.CloseProcesses(MyUtil.GetValueFromConfig().Path.ToString());
        }
    }
}
