namespace EmployeeManagament
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ComputeEmpWages compute_emp_wages=new ComputeEmpWages("Bridgelabz",20,100,20);
            compute_emp_wages.calculateWages();

        }
    }
}
