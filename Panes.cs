using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Panes
    {
        public static void Panaderia ()
        {
            Queue<string> panesCola = new Queue<string>();

            panesCola.Enqueue("Baguette");
            panesCola.Enqueue("Ciabatta");
            panesCola.Enqueue("Focaccia");
            panesCola.Enqueue("integral");
            panesCola.Enqueue("centeno");
            panesCola.Enqueue("maíz");
            panesCola.Enqueue("de ajo");
            panesCola.Enqueue("chocolate");

            Console.WriteLine("Primer Pan a hacer:" + panesCola.Peek() + "");
            Console.WriteLine("Ultimo Pan a hacer:" + panesCola.Last() + "");
            Console.WriteLine("Total de Panes a hacer:" + panesCola.Count() + "\n");
            Console.WriteLine("Panes a hacer:");
            foreach (var panes in panesCola)
            {
                Console.WriteLine(panes);
            }

            Console.WriteLine("\nPreparando los panes: ");
            while (panesCola.Count > 0)
            {

                Console.WriteLine($"Pan de {panesCola.Dequeue()} ha sido preparado.");
                Console.WriteLine("Total de Panes a hacer:" + panesCola.Count() + "\n");
            }
        }

    }
}
