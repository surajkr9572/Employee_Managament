namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int empHours = 0;
            int empWages = 0;
            int emp_per_hours = 20;
            int total_emp_working_days = 0;
            
            int total_emp_wages = 0;
            int Max_working_hours = 100;
            int Max_emp_working_days = 20;
            int total_emp_working_hours = 0;
            while (total_emp_working_hours< Max_working_hours && total_emp_working_days< Max_emp_working_days)
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
                total_emp_working_days++;
                total_emp_working_hours += empHours;
                Console.WriteLine($"Days: {total_emp_working_days} Employee Hours: {total_emp_working_hours} Present {empHours}");
            }
            total_emp_wages = total_emp_working_hours * emp_per_hours;
            Console.WriteLine($"Toatl Employee Wages: {total_emp_wages}");
        }
    }
}
