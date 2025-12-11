namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empAttendence = random.Next(0, 3);
            int empHours = 0;
            int empWages = 0;
            int emp_per_hours = 20;

            switch(empAttendence)
            {
                case 1:
                    empHours = 4;
                    break;
                case 2:
                    empHours = 8;
                    break;
                default:
                    empHours = 0;
                    break;
            }
            
            empWages = empHours * emp_per_hours;
            Console.WriteLine($"Employee Wages: {empWages}");
        }
    }
}
