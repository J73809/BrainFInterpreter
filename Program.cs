namespace BrainFInterpreter;

class Program
{
    static void Main(string[] args)
    {
        string? mainCode;
        Interpreter interpreter = new Interpreter();
        
        Console.WriteLine("Enter the code: \n");
        mainCode = Console.ReadLine();
        Console.WriteLine("\nOutput: ");
        
        interpreter.Run(mainCode);
    }
}