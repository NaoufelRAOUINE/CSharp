using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoConsole10
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoTask();
            //DemoAppelSyncsurMethodAsync();
            DemoAppelAsynchrone();
        }

        private async static void DemoAppelAsynchrone()
        {
            Console.WriteLine("Appel asynchrone lancé");
            Traitement tr2 = new Traitement();
            long result = await tr2.ComputeAsync();
            Console.WriteLine("fin de l'appel async");
        }

        private static void DemoAppelSyncsurMethodAsync()
        {
            Traitement tr2 = new Traitement();
            long result=tr2.ComputeAsync().Result;
            Console.WriteLine("La thread principale vous parle");
            Console.WriteLine(result); 
        }

        private static void DemoTask()
        {
            Console.WriteLine("Debut de traitement");
            CancellationTokenSource tokenSourceAnnulation = new CancellationTokenSource();
            CancellationToken jetonAnnuler = tokenSourceAnnulation.Token;
            Task<long> tacheCalcul = new Task<long>(
                () => CalculAsync(jetonAnnuler)


                );

            tacheCalcul.Start();


            do
            {
                if (tacheCalcul.IsCompleted)
                {
                    Console.WriteLine(tacheCalcul.Result);
                }
            } while (Console.ReadLine() != "");
            tokenSourceAnnulation.Cancel();
            //tacheCalcul.Wait();
            //Console.WriteLine(tacheCalcul.Result);
            Console.WriteLine("Fin de traitement");
            Console.ReadLine();
        }

        static long CalculAsync(CancellationToken jeton)
        {
            Traitement tr1 = new Traitement();
            return tr1.Calculer(jeton);
        }
    }
}
