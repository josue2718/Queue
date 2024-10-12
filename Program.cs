using Queue;
using System;
using System.Collections;
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {

        Actividad.Menu();

    }
}

public class Actividad
{
    public static void Menu()
    {
        Console.Clear();


        while (true)
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción \n1-Panaderia \n2-Impresora 2 \n3-Policia");
            Console.Write("Opción: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Panes.Panaderia();
                        break;
                    case 2:
                        Console.Clear();
                        SistemaImpresion sistema = new SistemaImpresion(5); // Capacidad de la cola circular

                        // Enviar trabajos a la impresora
                        sistema.Enqueue("Reporte Financiero");
                        sistema.Enqueue("Informe de Ventas");
                        sistema.Enqueue("Resumen de Proyectos");

                        sistema.ImprimirDocumentos();
                        break;
                    case 3:
                        Console.Clear();
                        CentroDespacho centro = new CentroDespacho();

                        
                        centro.RecibirLlamada(new LlamadaEmergencia("Accidente de tráfico", 1));
                        centro.RecibirLlamada(new LlamadaEmergencia("Gato en el árbol", 3));
                        centro.RecibirLlamada(new LlamadaEmergencia("Incendio en una casa", 1));
                        centro.RecibirLlamada(new LlamadaEmergencia("Herida leve", 2));

                        centro.AtenderLlamadas();
                        break;
                       
                    default:
                        Console.WriteLine("Opción invalida");
                        Menu();
                        break;
                }
                Salir();
            }
            else
            {
                Console.WriteLine("\nEntrada no válida.");

            }
        }
    }

    public static void Salir()
    {
        while (true)
        {
            Console.Write("\n¿Quieres salir? Si(S) / No(N): ");
            string input1 = Console.ReadLine();

            if (input1.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Saliendo del programa...");
                Environment.Exit(0);
            }
            else if (input1.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, elige 'S' para salir o 'N' para continuar.");
            }
        }


    }

}
