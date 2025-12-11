namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int empHours = 0;
            int empWages = 0;
            int emp_per_hours = 20;
            int totalWorkingDays = 20;
            int total_emp_wages = 0;
            for (int i = 0; i < totalWorkingDays; i++)
            {
                Random random = new Random();
                int empAttendence = random.Next(0, 3);
                switch (empAttendence)
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
                total_emp_wages += empWages;
                Console.WriteLine($"Employee Wages: {empWages}");
            }
            Console.WriteLine($"Toatl Employee Wages: {total_emp_wages}");
        }
    }
}
