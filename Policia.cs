using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    
        class LlamadaEmergencia
        {
            public string Descripcion { get; set; }
            public int NivelPrioridad { get; set; } // 1 - alta prioridad, 2 - media, 3 - baja

            public LlamadaEmergencia(string descripcion, int prioridad)
            {
                Descripcion = descripcion;
                NivelPrioridad = prioridad;
            }
        }

        class ComparadorLlamadas : IComparer<LlamadaEmergencia>
        {
            public int Compare(LlamadaEmergencia x, LlamadaEmergencia y)
            {
                return x.NivelPrioridad.CompareTo(y.NivelPrioridad);
            }
        }

        class CentroDespacho
        {
            private PriorityQueue<LlamadaEmergencia, int> colaEmergencias = new PriorityQueue<LlamadaEmergencia, int>();

            // Recibir llamada de emergencia
            public void RecibirLlamada(LlamadaEmergencia llamada)
            {

            colaEmergencias.Enqueue(llamada, llamada.NivelPrioridad);
                Console.WriteLine($"Llamada recibida: {llamada.Descripcion}, Nivel de prioridad: {llamada.NivelPrioridad}");
            }

            // Atender llamadas de emergencia según prioridad
            public void AtenderLlamadas()
            {
            Console.WriteLine("\nAtendiendo llamadas de emergencia:");
                while (colaEmergencias.Count > 0)
                {
                    var llamada = colaEmergencias.Dequeue();
                    Console.WriteLine($"Atendiendo: {llamada.Descripcion}, Prioridad: {llamada.NivelPrioridad}");
                }
            }
        }

    
}
