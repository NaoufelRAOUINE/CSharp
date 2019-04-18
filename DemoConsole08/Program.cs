using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole08
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient clientWS = new HttpClient();
            clientWS.BaseAddress = new Uri("http://services.groupkt.com/state/get/IND/all");
            clientWS.DefaultRequestHeaders.Clear();
            clientWS.DefaultRequestHeaders.Accept
                .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            List<Etat> etats = null;
            HttpResponseMessage response = clientWS.GetAsync("http://services.groupkt.com/state/get/IND/all").Result;
            etats = response.Content.ReadAsAsync((typeof<List<Etat>>).Result;
            foreach (var etat in etats)
            {
                Console.WriteLine(etat);
            }

        }
    }
}
