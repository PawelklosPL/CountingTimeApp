

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;

namespace CountingTimeApp
{
    public class ProcessList
    {
        public List<GridViewObject> processes = new List<GridViewObject>();

        public ProcessList()
        {
            processes = GetAllProcess();
        }

        public List<GridViewObject> GetAllProcess()
        {

        

            List<GridViewObject> processes = new List<GridViewObject>();
            var allProcesses = System.Diagnostics.Process.GetProcesses();

            ProcessStartInfo start = new ProcessStartInfo();

     
              
                var process = Process.GetCurrentProcess(); // Or whatever method you are using
                string fullPath = process.MainModule.FileName;
                Console.WriteLine(fullPath+"");
            foreach (var process2 in allProcesses)
            {
                try
                {
                    if (!process2.HasExited && process2.MainModule.FileName is string)
                    {
                        //if(process2.MainModule.FileName is string)
                       // Console.WriteLine(process2.MainModule.FileName);

                        processes.Add(new GridViewObject()
                        {
                            Name = process2.ProcessName,
                            StartTime = DateTime.Now.Subtract(process2.StartTime).ToString(@"hh\.mm\.ss"),
                            Path = process2.MainModule.FileName,
                            MainWindowTitle = process2.MainWindowTitle
                        });
                    }
                }
                catch (Win32Exception ex)
                {
                }
            }
            return processes;
        }
     


    }
}
