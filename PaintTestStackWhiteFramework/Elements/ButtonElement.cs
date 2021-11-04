using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using System;

namespace TestStackWhiteFramework
{
    public class ButtonElement : BaseElement<Button>
    {
        public ButtonElement(string name, SearchCriteria searchCriteria) : base(name, searchCriteria)
        {

        }
    }
}
