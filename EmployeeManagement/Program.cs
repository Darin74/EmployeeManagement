namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>();

            bool running = true;

            while (running)
            {
            Console.WriteLine("=== Employee Management ===");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. View employees");
            Console.WriteLine("3. Search employee");
            Console.WriteLine("4. Remove employee");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();


                    Console.WriteLine("Employee added: " + name);
                    employees.Add(name);
                }
                if (choice == "2")
                {
                    foreach (string employee in employees)
                    {
                        Console.WriteLine(employee);
                    }
                }
                if (choice == "3")
                {
                    Console.Write("Enter employee name to search: ");
                    string searchName = Console.ReadLine();

                    if (employees.Contains(searchName))
                    {
                        Console.WriteLine("Employee found: " + searchName);
                    }
                    else
                    {
                        Console.WriteLine("Employee not found.");
                    }
                }

                if (choice == "5")
                {
                    running = false;
                }
            
            }

        }
    }
}
