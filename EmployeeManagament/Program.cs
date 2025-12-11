namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputeEmpWages Bridgelabz = new ComputeEmpWages("Bridgelabz",20,100,20);
            Bridgelabz.calculateWages();
            Console.WriteLine(Bridgelabz.toString());
            ComputeEmpWages Google = new ComputeEmpWages("Google", 50, 100, 20);
            Google.calculateWages();
            Console.WriteLine(Google.toString());
        }
    }
}
