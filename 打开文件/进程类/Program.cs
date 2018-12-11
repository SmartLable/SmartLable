using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 进程类
{
    class Program
    {
        static void Main(string[] args)
        {

            Process[] procs = Process.GetProcesses();
            Process procs1 = new Process();

            //foreach (var item in procs)
            //{
            //    item.Kill();
            //    Console.WriteLine(item);
            //}
            ProcessStartInfo s1 = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\潘剑工作总结0712.docx");
            Process.Start("mspaint");
            Process.Start("Notepad");

            // Process.Start(s1);
 
            procs1.StartInfo = s1;
            procs1.Start();

            Console.ReadKey();
        }
    }
}
