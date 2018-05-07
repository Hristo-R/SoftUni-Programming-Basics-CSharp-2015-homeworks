using System;

class EmployeeData
{
    static void Main()
    {
        string firstName;
        string lastName;
        byte age;
        char gender;
        long personalIDNumber;
        uint uniqueEmployeeNumber;

        firstName = "Amanda";
        lastName = "Jonson";
        age = 27;
        gender = 'f';
        personalIDNumber = 8306112507L;
        uniqueEmployeeNumber = 27563571U;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", personalIDNumber);
        Console.WriteLine("Unique Employee number: {0}", uniqueEmployeeNumber);
    }
}