using ABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFundamentals.FileHandling
{
    internal class FileHandler
    {
        //deserialization
        public List<Person> ReadFile()
        {
            string filePath = @"C:\Users\shrestha.rozen\Desktop\oop\final\OOPFundamentals\FileHandler\Employees.csv";
            var fileContent = File.ReadAllText(filePath);
            /*Console.WriteLine(fileContent); */
            //display only name and dob of all people in employees.csv
            var eachLineOfCSV = fileContent.Split(["\n", "\r"], StringSplitOptions.RemoveEmptyEntries);
            /*Console.WriteLine(eachLineOfCSV[0]);*/
            var employees = new List<Person>();
            foreach(var line in eachLineOfCSV.Skip(1))
            {
                var data = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
                var name = data[0];
                 DateTime.TryParse(data[1], out DateTime dateOfBirth);
                var dob = dateOfBirth;
                long.TryParse(data[2], out long nationalId);
                var nid = nationalId;
                var employee = new Person(name, dob, nid);
                employees.Add(employee);
            }


            foreach( var emp in employees)
            {
                emp.PrintDetails();
            }
            return employees;
        }

        public void WriteFile()
        {
            string filePath = @"C:\Users\shrestha.rozen\Desktop\oop\final\OOPFundamentals\FileHandler\People.txt";
            File.WriteAllText(filePath, "This file contains people information.\nThis is created using WriteFile method.");

        }
        //write the above employees collection into file


        //serialization :- writing a List of text into a file
        public void WriteEmployeesFile(List<Person> employees)
        {
            string filePath = @"C:\Users\shrestha.rozen\Desktop\oop\final\OOPFundamentals\FileHandler\Employees.txt";
            var employeeCollection =employees.Select(Person.PrintDetails); //Function bhitra function as an arguement
            File.WriteAllLines(filePath, employeeCollection);

        }
    }
}
