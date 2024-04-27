namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>(5);

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Top element: " + stack.Peek()); 

            Console.WriteLine("Popped element: " + stack.Pop()); 
            Console.WriteLine("Top element after pop: " + stack.Peek()); 
        }
    }
}