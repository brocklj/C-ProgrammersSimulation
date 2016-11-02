using System.Collections.Generic;
namespace XA01
{ 
 public abstract class Employee
    {
       public string Name { get; private set; }
        public int DailyWage { get; private set; }
     public Employee(string name, int dailyWage)
        {
            Name = name;
            DailyWage = dailyWage;
        }
     
    }
}