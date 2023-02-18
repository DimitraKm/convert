namespace convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print();
        }
        static int sum(int a, int b)
        {
            return a + b; 
        }
        
        static int substract(int a, int b)
        {
            return a - b;
            
        }
        static int devide(int a, int b)
        {
            return a / b;
           
        }
        static int multiply (int a, int b)
        {
            return a * b;
            
        }
        static void print()
        {
            Console.WriteLine(sum(5, 2));
            Console.WriteLine(multiply(2, 4));
        }
        
    }
}