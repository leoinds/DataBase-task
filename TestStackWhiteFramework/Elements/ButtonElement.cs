using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace TestStackWhiteFramework
{
    public class ButtonElement : BaseElement<Button>
    {
        public ButtonElement(string name, SearchCriteria searchCriteria) : base (name, searchCriteria)
        {

        }
        //здесь еще могут быть уникальные для класса методы
    }
}
