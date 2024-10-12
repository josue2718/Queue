using System;

namespace Queue
{
    class SistemaImpresion
    {
        private string[] cola;
        private int frente;
        private int fin;
        private int tamaño;

        public SistemaImpresion(int capacidad)
        {
            cola = new string[capacidad];
            frente = 0;
            fin = 0;
            tamaño = 0;
        }

        
        public void Enqueue(string documento)
        {
            cola[fin] = documento; 
            fin = (fin + 1) % cola.Length; 
            tamaño++;
            Console.WriteLine($"Documento '{documento}' añadido a la cola de impresión.");
        }

        
        public string Dequeue()
        {
            if (tamaño == 0)
            {
                Console.WriteLine("La cola está vacía, no hay documentos para imprimir.");
                return null;
            }

            string documentoImpreso = cola[frente];
            frente = (frente + 1) % cola.Length; 
            tamaño--;

            return documentoImpreso;
        }

       
        public void ImprimirDocumentos()
        {
          
            Console.WriteLine("\nIniciando proceso de impresión...");
            while (tamaño > 0) 
            {
                var documentoImpreso = Dequeue();
                if (documentoImpreso != null)
                {
                    Console.WriteLine($"Imprimiendo documento: {documentoImpreso}");
                }
            }
        }
    }
}
