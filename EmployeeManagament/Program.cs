namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empAttendence = random.Next(0, 2);
            int empHours = 0;
            int empWages = 0;
            int emp_per_hours = 20;
            
            if (empAttendence == 1)
            {
                empHours = 8;
            }
            else
            {
                empHours = 0;
            }
            empWages = empHours * emp_per_hours;
            Console.WriteLine($"Employee Wages: {empWages}");
        }
    }
}
