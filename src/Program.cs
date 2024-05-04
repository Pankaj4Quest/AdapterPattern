using AdapterPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        LegacyEmployeeManager legacyEmployeeManager = new LegacyEmployeeManager();
        Console.WriteLine("OLD legacy code called\n\n");
        Console.WriteLine(legacyEmployeeManager.GetAllEmployees());
        Console.WriteLine();
        INewEmployeeManager newEmployeeManager = new Adapter();
        Console.WriteLine("New code called with adapter\n\n");
        Console.WriteLine(newEmployeeManager.GetAllEmployees());
        Console.ReadKey();
    }
}