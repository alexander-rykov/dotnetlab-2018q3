using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Examples.GodObject
{
  public class Employee
  {
    public Employee(string name, string address)
    {
      _name = name;
      _address = address;
    }

    private string _name;
    private string _address;

    public List<Person> Friends { get; set; }

    public Car Car { get; set; }

    public string GetName()
    {
      return this._name;
    }

    public string GetAddress()
    {
      return this._address;
    }

    public void AddEmployeeToDb()
    {
      throw new NotImplementedException();
    }

    public List<Employee> GetEmployees()
    {
      throw new NotImplementedException();
    }

    public string GetTelephoneNumberFromDb()
    {
      throw new NotImplementedException();
    }

    public int CulculateEmployeeSalary()
    {
      throw new NotImplementedException();
    }

    public void CallAPolice()
    {
      throw new NotImplementedException();
    }
  }

  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }
  }

  public class Car
  {
    public string CarMark { get; set; }
  }
}
