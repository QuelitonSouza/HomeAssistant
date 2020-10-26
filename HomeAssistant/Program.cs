using HomeAssistant.Config;
using HomeAssistant.Dto;
using HomeAssistant.Enums;
using HomeAssistant.Services;
using System;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using System.Windows.Forms;



namespace HomeAssistant
{
    public class Program
    {
        static void Main(string[] args)
        {

            ServiceBase.Run(new LoggingService());

            //var resultAuth = new WriterAndReadAuth().ReadAuth();
            //if (resultAuth == null)
            //{
            //    resultAuth = new WebClientApi().auth();
            //    new WriterAndReadAuth().WriterAuth(resultAuth);
            //}

            //var resultDevices = new WriterAndReadDevices().ReadDevices();
            //if (resultDevices == null)
            //{
            //    resultDevices = new WebClientApi(resultAuth).GetDevices(resultAuth);
            //    new WriterAndReadDevices().WriterDevices(resultDevices);
            //}

            //var resultDevice = new WebClientApi(resultAuth).ChangeStatusDevice(resultAuth, resultDevices, TypeStatusDeviceEnum.off);
            //Thread.Sleep(TimeSpan.FromSeconds(10));
            //resultDevice = new WebClientApi(resultAuth).ChangeStatusDevice(resultAuth, resultDevices, TypeStatusDeviceEnum.on);


            //Console.WriteLine("Hello Kitten!");
            //NotifyIcon icon = new NotifyIcon();
            //icon.Icon = new System.Drawing.Icon("./Img/home.ico");
            //icon.Visible = true;
            //icon.BalloonTipText = "Hello from My Kitten";
            //icon.BalloonTipTitle = "Cat Talk";
            //icon.BalloonTipIcon = ToolTipIcon.Info;
            //icon.ShowBalloonTip(2000);
            //Console.Read();

        }

        
    }
}
