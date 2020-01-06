using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoUploader
{
    class Program
    {
        static void SetGithubAvatar()
        {
            WebWrapper webWrapper = new WebWrapper();
            webWrapper.OpenSite("https://github.com/settings/profile");
            webWrapper.FillFieldByName("login", "login");
            webWrapper.FillFieldByName("password", "password");
            webWrapper.ClickOnElementByName("commit");
            webWrapper.ClickOnElementByPath("//img[@class='avatar rounded-2']/..");
            //webWrapper.ClickOnElementByPath("//label[@class='dropdown-item text-normal']");

            webWrapper.UploadFile("//input[@class='manual-file-chooser width-full ml-0 js-manual-file-chooser']", @"C:\Users\Admin\Pictures\prism runner logo\logo 72.png");

            //webWrapper.ClickOnElementByClassName("btn-primary");
            //webWrapper.ClickOnElementByPath("//button[contains(text(), 'Set new profile picture')]"); 
            //webWrapper.ClickOnElementByName("op");
            //webWrapper.ClickOnElementByPath("//button[contains(.,'Set new profile picture')]");
            //webWrapper.ClickOnElementByClassName("btn.btn-primary.btn-block");
            //webWrapper.ClickOnElementByCssSelector("btn btn-primary btn-block");
            //webWrapper.ClickOnElementByPath("//*[contains(text(),'Set new profile picture')]");
            //webWrapper.ClickOnElementByPath("//button[@value='save']/..");
            //webWrapper.ClickOnElementByLinkText("      Set new profile picture    ");
            //webWrapper.ClickOnElementByCssSelector("button.btn.btn-primary.btn-block");
            //webWrapper.ClickOnElementByPath("//button[@value='save']/html/body/details/details-dialog/form/div[2]/button");
            //webWrapper.ClickOnElementByCssSelector("body > details > details-dialog > form > div.Box-footer > button");
            webWrapper.ClickOnElementByPath("//button[@type='submit'][@name='op'][@value='save'][@class='btn btn-primary btn-block']");
        }

        static void Main(string[] args)
        {
            SetGithubAvatar();
            Console.WriteLine("End of programm");
            Console.ReadKey();
        }
    }
}
