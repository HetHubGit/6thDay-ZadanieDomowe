using _6thDay_ZadanieDomowe;




        int maxVal = -1;
        Employee maxValEmp = null;

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
            if (employee.Result > maxVal)
            {
                maxVal = employee.Result;
                maxValEmp = employee;
            }
        }
        Console.WriteLine("Najlepszy pracownik");
        Console.WriteLine("Imie: " + maxValEmp.name);
        Console.WriteLine("Nazwisko: " + maxValEmp.surname);
        Console.WriteLine("Age: " + maxValEmp.age);
        Console.WriteLine("Points: " + maxValEmp.Result);
     

       
    
