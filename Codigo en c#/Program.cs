using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una pila
        Stack<int> pila = new Stack<int>();

        // Operaciones básicas
        pila.Push(1); // Insertar elemento
        pila.Push(2);
        pila.Push(3);

        // Mostrar elementos
        Console.WriteLine("Elementos en la pila:");
        foreach (var elemento in pila)
        {
            Console.WriteLine(elemento);
        }

        // Eliminar elemento (LIFO - Last In First Out)
        int elementoEliminado = pila.Pop();
        Console.WriteLine($"Elemento eliminado: {elementoEliminado}");

        // Mostrar elementos después de la eliminación
        Console.WriteLine("Elementos en la pila después de la eliminación:");
        foreach (var elemento in pila)
        {
            Console.WriteLine(elemento);
        }
        Console.ReadKey();
    }
}

