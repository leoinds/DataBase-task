using System;
using System.Windows;
using System.Windows.Automation;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.Utility;
using TestStackWhiteFramework.Utils;

namespace TestStackWhiteFramework
{
    public abstract class BaseElement<T> where T : UIItem
    {
        public string Name { get; }
        private readonly SearchCriteria searchCriteria;

        protected BaseElement(string name, SearchCriteria searchCriteria)
        {
            //TestLogger.Log($"Creating of Element {name} by search criteria {searchCriteria}");
            Name = name;
            this.searchCriteria = searchCriteria;
        }

        protected T FindElement()
        {
            //TestLogger.Log($"Finding element {Name} by search criteria {searchCriteria}");
            return App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Get<T>(searchCriteria);
        }

        public void Click()
        {
            //TestLogger.Log($"Clicking to element {Name}");
            FindElement().Click();
        }
        public Point GetLocation()
        {
            //TestLogger.Log($"Getting location of element {Name}");
            return FindElement().Location;
        }
        public void WaitWhileBusy()
        {
            Retry.For(ShellIsBusy, isBusy => isBusy, TimeSpan.FromSeconds(30));
        }

        private bool ShellIsBusy()
        {
            var currentPropertyValue = App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).AutomationElement.GetCurrentPropertyValue(AutomationElement.HelpTextProperty);
            return currentPropertyValue != null && ((string)currentPropertyValue).Contains("Busy");
        }
    }
}
