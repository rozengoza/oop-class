using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppForFundamentals;

internal class Linq //Language Integrated Query 
{
    static double[] marks = [90.5, 40.2, 38.0, 42.1,22,33.1, 88.1, 7.0]; // "90.50"  into  string and to  two  decimal  place

    // get all marks  which surpass  the passmarks 40 
    static List<Student> students = [
     new ("Ram Bista", new DateTime(2004, 12, 12), "NIST", "BCE"),
    new ("Binisha Awale", new DateTime(1998, 04, 12), "NCIT", "BCT"),
    new ("Sita Silwal", new DateTime(1989, 02, 25), "ASCOL", "BIM"),
    new ("Laxman Shrestha", new DateTime(2005, 08, 23), "ISLINGTON", "BIT"),
    new("Hari Basnet", new DateTime(2000, 09, 12), "NCE", "BEX")
    ];

    public static void LearnLinq()
    {
        List<double> passMarks = [];
        foreach ( var mark in marks)
        {
            if( mark > 40 )
            {
                passMarks.Add(mark);
            }
        }

        //declarative
        //method syntax  for Linq
        var passMarks1 = marks.Where( mark => mark > 40 ); //Filter

        var result = marks.Select( x => x.ToString("F2"));
        
       // byte y = 32;
        //int e = y; //implicit casting

        // foreach (var mark in result)
        // {
        //     Console.WriteLine(mark);
        // }


        //Get all  passmarks converted to nearest integer

        var passMarks2 = marks.Where(mark => mark > 40).Select(mark => Math.Round(mark));

        /*foreach (var mark in passMarks2)
        {
            Console.WriteLine(mark);
        }*/

        //alternate syntax to  Linq || explicit syntax
        //Expresstion
        passMarks2 = from mark in marks //contextual keyword for Linq Query
                     where mark > 40
                     select Math.Round(mark);

         foreach( var mark in passMarks2)
        {

        Console.WriteLine(mark); 
        }
        //Get employees born after  2000 AD
        var employeesBornAfter2000 = students.Where(x => x.dob.Year > 2000);

        foreach(var employee in employeesBornAfter2000)
        {

        Console.WriteLine(employee.name); 
        }    
        //Get employees name with their  age and  order by age
        var emps = students
           .Select(x => new { Name = x.name, Age = x.CalculateAge() })
           .OrderBy(x => x.Age.Item2);

        foreach(var employee in emps)
        {
            Console.WriteLine($"{employee.Name}\t{employee.Age.Item1}");
        }

    }

}