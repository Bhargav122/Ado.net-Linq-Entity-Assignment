using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSyntax
{
	public class Program
	{
		public static void Main()
		{
			// Employee collection
			List<Employee> EmpList = new List<Employee>() {
				new Employee() { Empid = 1, Name = "Rahul", Age = 33} ,
				new Employee() { Empid = 2, Name = "Bhargav",  Age = 24 } ,
				new Employee() { Empid = 3, Name = "Mohan",  Age = 58 } ,
				new Employee() { Empid = 4, Name = "Charan" , Age = 35} ,
				new Employee() { Empid = 5, Name = "Rohit" , Age = 48 }
			};

			// LINQ  Method Syntax
			var Emps = EmpList.Where(e => e.Age > 40);

			Console.WriteLine("Emps With 10 years Experience:");

			foreach (dynamic Emp in Emps)
			{
				Console.WriteLine(Emp.Name);
			}
		}
	}

	public class Employee
	{

		public int Empid { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }

	}
}
