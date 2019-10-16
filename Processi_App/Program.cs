using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processi_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione dei processi");
            //File di testo
            Process.Start("Notepad.exe ");
            //File di testo all'interno del programma
            Process.Start("Notepad.exe", @"\\dc01srv\_Condivisa\INF\4 B\Martina Biagioni\Informatica\Processi_Gestione\Processi_App\Hello_World.txt");
            //Link di una pagina su internet
            Process.Start(@"https://www.youtube.com/?gl=IT&hl=it");

            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.StartInfo.Arguments = @"\\dc01srv\_Condivisa\INF\4 B\Martina Biagioni\Informatica\Processi_Gestione\Processi_App\Hello_World.txt";
            app.Start();

            var processes = Process.GetProcesses();
            foreach (var p in processes)
            {
                if (p.ProcessName == "notepad")
                {
                    p.Kill();
                }
            }
            Console.WriteLine("Programma Terminato!");
            Console.ReadLine();
        }
    }
}
