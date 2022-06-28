using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2484618#content
/* 
 * Constructor is a method that is called when an instance of a class is created
 * Constructor is created to put an object in an early state which means
   to initialize fields in a class
 * Constructor isn't always needed
 * Constructor needs to have the same name as the class
 * It also does not have a return type
  
 * Constructor overload is used to make initialization of that class easier
 */
namespace Constructors;

public class Customer
{
    public Customer() //constructor without parameters C# compiler will create default values
    {

    }
}
public class Customer1
{
    public string Name; // name field
    public Customer1(string name)
    {
        this.Name = name;
    }
}
public class Customer2 // Constructor overload - same name of a constructor with
                       // different signatures
                       // different constructors are used depending on parameters
{
    public Customer2()
    {

    }
    public Customer2(string name)
    {

    }
    public Customer2(int id, string name)
    {

    }
}
class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer1("John");
    }
}