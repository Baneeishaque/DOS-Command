using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DOS_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                ProcessStartInfo a = new ProcessStartInfo("cmd", "/c echo hai");
                a.RedirectStandardOutput = true;
                a.UseShellExecute = false;
                a.CreateNoWindow = true;
                Process b = new Process();
                b.StartInfo = a;
                b.Start();
                Console.WriteLine(b.StandardOutput.ReadToEnd());
                Console.ReadKey();
            }
            catch (Exception e)
            {

            }

        }
    }
}
