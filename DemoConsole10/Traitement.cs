using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoConsole10
{
    class Traitement
    {
        public long Calculer(CancellationToken j)
        {
            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            for (int i = 0; i < 10; i++)
            {
                if (j.IsCancellationRequested)
                {
                    return -1;
                }
                     Thread.Sleep(1000);
                     Console.WriteLine("Nous avons réalisé {0} secondes de traitement",i+1);
                
               
            }
            chrono.Stop();
            return chrono.ElapsedMilliseconds;
        }


        public async Task<long> ComputeAsync()
        {
            Console.WriteLine("La méthodeComputeAsync a été appelée");

            Task<long> t = new Task<long>(
                () =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Thread.Sleep(1000);
                    }
                    return 123;
                }
                );
            t.Start();
            return t.Result;
        }
    }
}
