using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace startwow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                
                string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Cache\";
                //string filter = "*.zip";
                bool direxist = Directory.Exists(folder);
                if (direxist)
                {
                    Console.WriteLine("Folder found: " + folder);
                    Directory.Delete(folder,true);
                    Console.WriteLine("Folder deleted: " + folder);

                    Process.Start("wow.exe");
                }

                else
                {
                    Console.WriteLine("Folder not found!");

                    Process.Start("wow.exe");
                    Console.Read();
                }
               

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.Message);
            }
        }
    }
}
