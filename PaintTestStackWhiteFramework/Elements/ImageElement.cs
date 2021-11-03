using System;
using System.IO;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStackWhiteFramework;
using TestStackWhiteFramework.Utils;
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
        public static void CopyFiles(string sourceDir, string backupDir)
        {
            try
            {
                string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
                foreach (string f in picList)
                {
                    string fName = f.Substring(sourceDir.Length + 1);
                    File.Copy(Path.Combine(sourceDir, MyUtil.GetValueFromConfig().ImageName.ToString()), Path.Combine(backupDir, MyUtil.GetValueFromConfig().CopyImageName.ToString()), true);
                }
            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }
        }
    }
}
