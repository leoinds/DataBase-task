using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;

namespace TestStackWhiteFramework
{
    public class ButtonElement : BaseElement<Button>
    {
        public ButtonElement(string name, SearchCriteria searchCriteria) : base (name, searchCriteria)
        {

        }
        //что еще должно быть в классе кроме конструктора - уникальные для класса
        //должны ли быть все классы или только те что нужны для задания - только для теста
    }
}
