using _6thDay_ZadanieDomowe;
int maxValue = -1;
Employee maxValueEmployee = null;
Employee employee1 = new Employee("kot", "Pies", 5);
Employee employee2 = new Employee("Jacek", "human", 46);
Employee employee3 = new Employee("Olga", "Human", 47);
List<Employee> employees = new List<Employee>()
    {
    employee1, employee2, employee3
    };
employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(7);
employee3.AddScore(7);
employee3.AddScore(4);
employee3.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(3);
employee2.AddScore(9);
foreach (var employee in employees)
{
    if (employee.Result > maxValue)
    {
        maxValue = employee.Result;
        maxValueEmployee = employee;
    }
}
Console.WriteLine("Najlepszy pracownik");
Console.WriteLine("Imie: " + maxValueEmployee.name);
Console.WriteLine("Nazwisko: " + maxValueEmployee.surname);
Console.WriteLine("Age: " + maxValueEmployee.age);
Console.WriteLine("Points: " + maxValueEmployee.Result);