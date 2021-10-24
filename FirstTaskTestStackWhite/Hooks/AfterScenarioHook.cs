using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestStackWhiteFramework;

namespace FirstTaskTestStackWhite.Hooks
{
    public class AfterScenarioHook
    {
        App.CloseProcesses(processName);
        //здесь должно юзаться метод закрытие инстансев из класса app? - да
        //с каким объектом -это статик метод
        //аттрибуты перед методами и классами, еще не читад про них - б ефор сценарио и афтер сценарио хук

    }
}
