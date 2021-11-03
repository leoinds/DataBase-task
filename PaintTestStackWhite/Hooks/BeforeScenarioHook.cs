using TechTalk.SpecFlow;
using TestStackWhiteFramework;
using TestStackWhiteFramework.Utils;

namespace FirstTaskTestStackWhite.Hooks
{
    [Binding]
    public class BeforeScenarioHook
    {
        [BeforeScenario]
        public void Precondition()
        {
            App.CloseProcesses(MyUtil.GetValueFromConfig().Path.ToString());
        }
    }
}
