using culebrita.Culebritas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;

namespace culebrita
{
    internal class Program
    {

        //convertirlo en un programa orietado a objetos 
        //emitir beep cuando coma la comida 
        //incrementar la velocidad conforme vaya avanzando 
        //modificar el uso de queue y reemplazarlo con la estructura de cola vista en clase
        //colalinal arreglo 
        //cola arraylist
        //cola lista enlazada
        // explicar qué pasa al alterar cada una de las lineas marcadas con las preguntas
        // se aprecia si pueden cambiar las reglas del juego o si le agrega cosas extra



        static void Main()
        {
            CulebritaColaCLista conLista = new CulebritaColaCLista();
            CulebritaColaCircular colaCircular = new CulebritaColaCircular();
            CulebritaColaLineal colaLineal = new CulebritaColaLineal();
            CulebritaColaArrayList colaArrayList = new CulebritaColaArrayList();


            Console.WriteLine("\t\tBIENVENIDO AL JUEGO DE LA CULEBRITA\n");
            
            
            Console.WriteLine("Puedes Elegir el tipo de estructura a Utilizar");
            Console.WriteLine("Escriba el numero de su opción");
            Console.WriteLine("1. Cola Arreglo Circular");
            Console.WriteLine("2. Cola Arreglo Lineal");
            Console.WriteLine("3. Cola Lista");
            Console.WriteLine("4. Cola ArrayList");
            Console.Write("---->");
            int opcion = Convert.ToInt32(Console.ReadLine());


            
            
            


            do
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        colaCircular.Jugar(); break;
                    case 2:
                        Console.Clear();
                        colaLineal.Jugar(); break;
                    case 3:
                        Console.Clear();
                        conLista.Jugar(); break;
                    case 4:
                        Console.Clear();
                        colaArrayList.Jugar(); break;

                    default:
                        Console.WriteLine("Hasta Pronto");
                        Console.ReadLine();
                        break;
                }
            } while (opcion <= 4);
        }
    }//end class
}













