using NUnit.Framework;
using PaintTaskTestStackWhite.Elements;
using System;
using System.Drawing;
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
        public void CopyImage()
        {
            Thread thread = new Thread(() => Clipboard.SetImage(System.Drawing.Image.FromFile(pathToTheImage + MyUtil.GetValueFromConfig().ImageName.ToString())));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join();
        }
        public void PasteImage() 
        {
            var location = resizeButton.GetLocation();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).WaitWhileBusy();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X - 15, location.Y);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X, location.Y + 155);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X - 25, location.Y + 155);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.RightClick();
            Thread.Sleep(300); //если вставить явное ожидание через имя окна и WaitWhileBusy() пропускает шаг
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Location = new System.Windows.Point(location.X - 15, location.Y + 205);
            App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).Mouse.Click();


            //у меня не получилось вставить картинку из буфера обмена, я вставил ее через клики курсора
        }

        public Window GetModalWindow()
        {
            var modalWindow = App.GetWindow(MyUtil.GetValueFromConfig().WindowName.ToString()).ModalWindow(MyUtil.GetValueFromConfig().ModalWindowName.ToString());
            return modalWindow;
        }
        
        public void CopyOriginalImage()
        {
            ImageElement.CopyFiles(pathToTheImage, pathToTheImage);
        }

        public void ResultCheck()
        {
            Assert.AreEqual(0.0f, ImageElement.GetDifference(pathToTheImage + MyUtil.GetValueFromConfig().ImageName.ToString(), pathToTheImage + MyUtil.GetValueFromConfig().CopyImageName.ToString(), 3), "The image has been changed");           
        }
    }
}
