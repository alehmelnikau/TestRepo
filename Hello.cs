using System;
using System.Diagnostics;
using System.IO;
555
777
    888
namespace BinContent
{
    class Program
    {
        static void Main(string[] args)
        {
            String directory;

            //Process.Start("cmd.exe", "/C " + "format g: /q /v:Test");

            //var process = Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe ", "Format-Volume -DriveLetter G -Full");

            //var process = Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe ", "Get-Partition –DiskNumber 3");            

            //process.WaitForExit();

            //process = Process.Start(@"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe ", "Remove-Partition -DiskNumber 3 -PartitionNumber 1");

            //process.WaitForExit();

            //Console.ReadKey();

            //return;

            /*
            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/C " + "format g: /q /v:Test";
            p.StartInfo.CreateNoWindow = true;
            p.Start();

            */

            directory = $"{Guid.NewGuid()}";

            for (int k = 0; k < 28; k++)
            {                
                Directory.CreateDirectory($"G:\\{directory}");                

                Console.WriteLine($"{k}");

                string path = $"G:\\{directory}\\{Guid.NewGuid()}.bin";

                File.Copy("D:\\binary_512M.bin", path);

                //WriteToFile(path);
            }

            directory = $"{Guid.NewGuid()}";
            Directory.CreateDirectory($"G:\\{directory}");

            Console.WriteLine($"28");

            for (int j = 0; j < 479; j++)
            {
                string path = $"G:\\{directory}\\{Guid.NewGuid()}.bin";

                File.Copy("D:\\binary_1M.bin", path);

                //WriteToFile(path);

            }

        }

        static void WriteToFile( string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < 256 * 1024 * 512; i++)
                {
                    writer.Write(0xFFFFFFFF);
                }
            }
        }
    }
}
