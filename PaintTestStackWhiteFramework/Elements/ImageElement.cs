using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStackWhiteFramework;
using XnaFan.ImageComparison;

namespace PaintTaskTestStackWhite.Elements
{
    public class ImageElement : BaseElement <Image>
    {
        public ImageElement(string name, SearchCriteria searchCriteria) : base(name, searchCriteria)
        {

        }

        public static float GetDifference(string image1Path, string image2Path, byte threshold)
        {
            return ImageTool.GetPercentageDifference(image1Path, image2Path, threshold);
        }
    }
}
