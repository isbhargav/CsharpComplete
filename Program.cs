using System;

namespace CsharpComplete
{
	public class Customer
	{
		string firstname, LastName;
		double total;
		//Constructor
		public void abc_Customer(string f, string l, double t)
		{
			this.firstname = f;
			this.LastName = l;
			this.total = t;
		}
		public string printDetails()
		{
			return firstname + " " + LastName + " " + total.ToString();
		}

	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			//     Customer c = new Customer("Bharagv","Lad",200.21);
			Customer a = new Customer();
			Console.WriteLine(a.printDetails());
		}
	}
}
