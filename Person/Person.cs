namespace ABC;
//only one class for one file -best practise
class Person
{
    public Person() //paramterless constructor
    {
    }
    public Person(string n, DateTime d, long i) //parameterized constructor
    {
        this.name = n;
        this.nid = i;
        this.dob = d;
    }
    public string name;
    public long nid;
    public DateTime dob;
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {this.name}\n National Identifier: {this.nid}\n Date of Birth:{this.dob.ToString("dddd MMM dd, yyyy")}");
    }
    //PrintDetails prints all instance
    //this - current object
    public void PrintNameandDobDetails()
    {
        Console.WriteLine($"Name: {this.name}\n Date of Birth:{this.dob.ToString("dddd MMM dd, yyyy")}");
    }

    //Method overloading, dont change existing code, extend the existing code  instead
    public static string PrintDetails(Person person) => 
         $"Name: {person.name}\n National Identifier: {person.nid}\n Date of Birth:{person.dob.ToString("dddd MMM dd, yyyy")}";

}