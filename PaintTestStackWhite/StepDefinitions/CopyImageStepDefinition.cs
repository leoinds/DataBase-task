using PaintTaskTestStackWhite.Elements;
using PaintTestStackWhite.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestStackWhiteFramework.Utils;

namespace PaintTestStackWhite.StepDefinitions
{
    [Binding]
    class CopyImageStepDefinition
    {
        private PaintPage paintPage;
        public CopyImageStepDefinition()
        {
            paintPage = new PaintPage();
        }
        public string PictureName => MyUtil.GetValueFromConfig().ImageName.ToString();
        //[When(@"user copies an image (.*)")]
        //public void WhenAUserUploadsAnImage(string pictureName)
        //{
        //    paintPage.CopyOriginalImage();
        //    paintPage.CopyImageToTheClipboard(pictureName);
        //}
        [When(@"user copies an image (.*)")]
        public void WhenAUserUploadsAnImage(string pictureName)
        {
            paintPage.CopyOriginalImage(pictureName);
            paintPage.CopyImageToTheClipboard(pictureName);
        }
    }
}
