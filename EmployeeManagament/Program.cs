namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empAttendence = random.Next(0, 2);
            if (empAttendence == 1)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
