public class Program
{


    public static void Main(String[] args)
    {

        Stack stack = new Stack(5);
        while (true)
        {
            Console.WriteLine("\nMenu de opciones:");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Print Tope");
            Console.WriteLine("4. Print pila");

            int option = int.Parse(Console.ReadLine());

            switch(option){
                case 1:
                    Console.WriteLine("ingrese dato a guardar!!");
                    int data = int.Parse(Console.ReadLine());
                    stack.Push(data);
                    break;
                case 2:                    
                    stack.Pop();
                    break;
                case 3:
                    Console.WriteLine(stack.PrintTope());                    
                    break;
                case 4:
                    stack.PrintStack();
                    break;
                default:
                    Console.WriteLine("opcion no valida!!");
                    break;
            }
        }
    }
}