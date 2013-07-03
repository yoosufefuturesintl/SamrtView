using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace SmartView.Test.Library.Application
{
    public class Applications{

    public static void CloseAllApplication(String application)
        {
            Process[] appWindows = Process.GetProcessesByName(application);

            foreach (Process window in appWindows)
            {
                window.Kill();
                
            }
        }



    

    public static void WaitForApplicationMemory(String application, int memory)
        {
            Process[] appWindows = Process.GetProcessesByName(application);
          
            int memorySize = 0;

            TextWriter tw  = new StreamWriter("D:\\QA\\mem.txt");
            for(int time = 1;time < 5000; time++ )
            {           
                   
                    memorySize = Int32.Parse(appWindows[0].PagedMemorySize.ToString())/1024;

                    Thread.Sleep(100);
                    tw.WriteLine("memory Size" + memorySize);
                //if(memory < memorySize){
                //    tw.WriteLine("break ======================================= " + memorySize);
                //    break;
                //}
               
            }
            tw.Close();
           
        }



    }
}
