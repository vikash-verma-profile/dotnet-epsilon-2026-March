namespace Day_2
{

    class Employee
    {
        //fields
        int Id;
        string EmployeeName;
        //properties
        //functions/methods
        public Employee GetData()
        {
            Console.WriteLine("Please enter employee record:");
            Employee employee = new Employee();
            employee.Id = Convert.ToInt32(Console.ReadLine());
            employee.EmployeeName = Console.ReadLine();
            return employee;
        }

        public void Display(Employee[] employeeList)
        {
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee.Id}-{employee.EmployeeName}");
            }
        }
        //constructors
        //destructors
        //indexers
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] employeeList = new Employee[3];
            Employee emp = new Employee();
            for (int i = 0; i < employeeList.Length; i++)
            {
                employeeList[i] = emp.GetData();
            }

            emp.Display(employeeList);

        }
    }
}
