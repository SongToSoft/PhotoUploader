using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PhotoUploader
{
    class Program
    {
        static void SetGithubAvatar()
        {
            FileManager fileManager = new FileManager();
            string uploadFile = fileManager.GetRandomFile();
            Console.WriteLine("Change Avatar on: " + uploadFile);
            WebWrapper webWrapper = new WebWrapper();
            webWrapper.OpenBrowser("https://github.com/settings/profile");
            webWrapper.FillFieldByName("login", "login");
            webWrapper.FillFieldByName("password", "password");
            webWrapper.ClickOnElementByName("commit");
            webWrapper.ClickOnElementByPath("//img[@class='avatar rounded-2']/..");
            webWrapper.UploadFile("//input[@class='manual-file-chooser width-full ml-0 js-manual-file-chooser']", uploadFile);
            Thread.Sleep(5000);
            webWrapper.ClickOnElementByPath("//button[@type='submit'][@name='op'][@value='save'][@class='btn btn-primary btn-block']");
            webWrapper.CloseBrowser();
        }

        static void Main(string[] args)
        {
            SetGithubAvatar();
            Console.WriteLine("End of programm");
        }
    }
}
