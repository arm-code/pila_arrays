using System;

public class Stack
{
    private int[] array;
    private int tope;

    public Stack(int size)
    {
        array = new int[size];
        tope = -1;
    }

    // add an element
    public void Push(int value)
    {
        if (tope == array.Length - 1)
        {
            Console.WriteLine("La pila esta llena!!");
            return;
        }
        tope++;
        array[tope] = value;
    }

    // Delete an element
    public int Pop()
    {
        if (tope == -1)
        {
            Console.WriteLine("La pila esta vacia!!");
            return int.MinValue;
        }
        Console.WriteLine("elemento eliminado!");
        return array[tope--];
    }

    //Print the top
    public int PrintTope()
    {
        if (tope == -1)
        {
            Console.WriteLine("La pila esta vacia!!");
            return 0;
        }
        return array[tope];
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La pila esta vacia!!");
        }
        else
        {
            Console.WriteLine("Elementos de la pila: ");
            for (int i = 0; i <= tope; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }

    public bool IsEmpty()
    {
        return tope == -1;
    }


}