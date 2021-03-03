using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WinForms_WindowsServices
{
    public partial class MyCustomService : ServiceBase
    {
        private Timer timer = new Timer();
        private DateTime _schedule = DateTime.Now.AddMilliseconds(15000);

        public MyCustomService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("Service started at_" + DateTime.Now);
            timer.Elapsed += new ElapsedEventHandler(onElapsedTime);
            timer.Interval = 10000;
            timer.Enabled = true;
        }

        private void onElapsedTime(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now >= _schedule)
            {
                WriteToFile("Service recalled at " + DateTime.Now);
            }
            else
            {
                WriteToFile("Service waiting for the Schedule Time at " + DateTime.Now);
            }
        }

        protected override void OnStop()
        {
            WriteToFile("Service got stopped at " + DateTime.Now);
        }

        public void WriteToFile(string messege)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLogs_"
                + DateTime.Now.ToShortDateString().Replace("/", "-") + ".txt";
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLineAsync(messege);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLineAsync(messege);
                }
            }
        }
    }
}