using PaintTestStackWhite.Pages;
using System.Windows.Forms;
using TechTalk.SpecFlow;
using TestStackWhiteFramework;

namespace PaintTestStackWhite.StepDefinitions
{
    [Binding]
    public class PaintStepDefinitions
    {
        ModalPage modalPage = new ModalPage();
        private PaintPage paintPage;
        
        public PaintStepDefinitions()
        {
            paintPage = new PaintPage();
        }

        [Given(@"open the Paint")]
        public void GivenOpenThePaint()
        {
            App.ApplicationLaunch();
        }
        
        [When(@"user uploads an image")]
        public void WhenAUserUploadsAnImage()
        {
            paintPage.CopyOriginalImage();
            paintPage.CopyImage();
            paintPage.PasteImage();
        }
        
        [When(@"clicks the Select all button")]
        public void WhenClicksTheSelectAllButton()
        {
            paintPage.ClickSelectButton();
        }
        
        [When(@"clicks the Cut button")]
        public void WhenClicksTheCutButton()
        {
            paintPage.ClickButtonByText("Cut");
        }
        
        [When(@"сloses the paint")]
        public void WhenСlosesThePaint()
        {
            paintPage.CloseApp();
        }
        
        [When(@"declines to change the results")]
        public void WhenDeclinesToChangeTheResults()
        {
            paintPage.GetModalWindow();
            modalPage.ClickButtonByAutomationId("DoNotSaveButton", "CommandButton_7");
        }
        
        [Then(@"the original picture has not changed")]
        public void ThenTheOriginalPictureHasNotChanged()
        {
            paintPage.ResultCheck();
        }
    }
}
