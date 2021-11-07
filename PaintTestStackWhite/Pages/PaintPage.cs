using System;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStackWhiteFramework;
using TestStackWhiteFramework.Utils;

namespace PaintTestStackWhite.Pages
{
    public class PaintPage 
    {

        private static readonly string pathToTheImage = AppDomain.CurrentDomain.BaseDirectory + @"/Resources/";
        public static string PathToTheImage
        {
            get
            {
                return pathToTheImage;
            }
        }

        private ButtonElement resizeButton = new ButtonElement("ResizeButton", SearchCriteria.ByControlType(ControlType.Button).AndByText("Resize"));
        private ButtonElement cutButton = new ButtonElement("CutButton", SearchCriteria.ByControlType(ControlType.Button).AndByText("Cut"));
        private ButtonElement helpButton = new ButtonElement("HelpButton", SearchCriteria.ByControlType(ControlType.Button).AndByText("Help"));
        private ButtonElement ButtonByText(string name) => new ButtonElement($"{name}Button", SearchCriteria.ByControlType(ControlType.Button).AndByText($"{name}"));

        public void ClickButtonByText(string name)
        {
            ButtonByText(name).Click();
        }
        public void CloseApp()
        {
            var location = helpButton.GetLocation();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X, location.Y - 25);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();
        }
        public void ClickSelectButton()
        {
            var location = resizeButton.GetLocation();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X - 25, location.Y + 35);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).WaitWhileBusy();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X - 25, location.Y + 155);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();
        }
        public void CopyImageToTheClipboard(string pictureName)
        {
            Thread thread = new Thread(() => Clipboard.SetImage(System.Drawing.Image.FromFile(pathToTheImage + pictureName)));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
        }
        public void PasteImage() 
        {
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).WaitWhileBusy();
            var location = cutButton.GetLocation();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X - 25, location.Y + 15);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();
        }

        public Window GetModalWindow()
        {
            var modalWindow = App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).ModalWindow(MyUtil.GetValueFromConfig().ModalWindowName.ToString());
            return modalWindow;
        }

        public void CopyOriginalImage(string pictureName)
        {
            MyUtil.CopyFiles(pathToTheImage, pathToTheImage, pictureName);
        }

    }
}
