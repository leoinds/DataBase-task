using System.Diagnostics;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestStackWhiteFramework
{
    public static class App
    {
        private static Application application;
        public static void CloseProcesses(string processName)
        {
           //TestLogger.Log($"Closing processes {processName}");
           Process[] processes = Process.GetProcessesByName(processName);

           foreach (Process process in processes)
               {
                  Application.Attach(process).Close();
               }
        }
        public static Window GetWindow(string app)
        {
            return application.GetWindow(app, InitializeOption.NoCache);
        }

        public static Application ApplicationLaunch()
        { 
            if (application == null)
            {
                //application = Application.Launch(@"D:\Calc\calc.exe");
                application = Application.Launch(ConfigurationData.name);
            }

            return application;
        }
        public static void CloseApplication()
        {
                application.Kill();
        }
    }
}
