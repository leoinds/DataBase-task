using NUnit.Framework;
using PaintTaskTestStackWhite.Elements;
using PaintTestStackWhite.Pages;
using System.Windows.Forms;
using TechTalk.SpecFlow;
using TestStackWhiteFramework;
using TestStackWhiteFramework.Utils;

namespace PaintTestStackWhite.StepDefinitions
{
    [Binding]
    public class PaintStepDefinitions
    {

        private PaintPage paintPage;
        private ModalPage modalPage;
        public PaintStepDefinitions()
        {
            paintPage = new PaintPage();
            modalPage = new ModalPage();
        }

        [Given(@"open the Paint")]
        public void GivenOpenThePaint()
        {
            App.ApplicationLaunch();
        }
        
        [When(@"user inserts an image from the clipboard")]
        public void WhenAUserUploadsAnImage()
        {
            paintPage.PasteImage();
        }
        
        [When(@"user clicks Select all button")]
        public void WhenClicksTheSelectAllButton()
        {
            paintPage.ClickSelectButton();
        }
        
        [When(@"user clicks the (.*) button")]
        public void WhenClicksTheCutButton(string button)
        {
            paintPage.ClickButtonByText(button);
        }
        
        [When(@"user сloses the paint")]
        public void WhenСlosesThePaint()
        {
            paintPage.CloseApp();
        }
        
        [When(@"user declines to change the results")]
        public void WhenDeclinesToChangeTheResults()
        {
            paintPage.GetModalWindow();
            modalPage.ClickDoNotSaveButton();
        }
        
        [Then(@"the original picture (.*) has not changed")]
        public void ThenTheOriginalPictureHasNotChanged(string pictureName)
        {
            Assert.AreEqual(0.0f, ImageElement.GetDifference(PaintPage.PathToTheImage + pictureName, PaintPage.PathToTheImage + MyUtil.GetValueFromConfig().CopyImageName.ToString(), 3), "The image has been changed");
        }
    }
}
