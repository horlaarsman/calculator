/*
 * Created by SharpDevelop.
 * User: HORLAARSMAN
 * Date: 8/29/2016
 * Time: 12:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace joking
{
	class Program
	{
		public static void Main(string[] args)
		{
			Int32 firstnumber;
			Int32 secondnumber;
			Double fdiv;
			Double sdiv;
			
			
			Console.WriteLine("This is a calculator");
			Console.WriteLine("__________________________________________________");
			Console.WriteLine("Please select your calculation method");
			Console.WriteLine("__________________________________________________");
			Console.WriteLine("Multiplication = x, Addition = add, Subtraction = sub, Division = div");

			string check = Console.ReadLine();
			Console.WriteLine("__________________________________________________");
			if (check == "x") {
				Console.WriteLine("You have choosen Multiplication");	
				Console.WriteLine("Enter first number to Multiply");
				firstnumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second name");
			secondnumber = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("The Answer is = ");
			Console.WriteLine(secondnumber * firstnumber);
			Console.WriteLine("press anykey to cancel");
			Console.ReadLine();
			Console.WriteLine("__________________________________________________");

			
			} else if (check == "add") {
				Console.WriteLine("You have choosen Addition");	
				Console.WriteLine("Enter first number to add");
				firstnumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second name");
			secondnumber = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("The Answer is = ");
			Console.WriteLine(secondnumber + firstnumber);
			Console.WriteLine("press anykey to cancel");
			Console.ReadLine();	
			Console.WriteLine("__________________________________________________");
			}
			else 
			
		if (check == "sub") {
				Console.WriteLine("You have choosen Substraction");	
				Console.WriteLine("Enter first number to Substract");
				fdiv = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second name");
			sdiv = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("The Answer is = ");
			Console.WriteLine(fdiv - sdiv);
			Console.WriteLine("press anykey to cancel");
			Console.ReadLine();
			Console.WriteLine("__________________________________________________");
			}
		
		else if (check == "div") {
				Double ffloat;
				Double lfloat;
				Console.WriteLine("You have choosen Division");
				Console.WriteLine("Enter first number to Divide");
				ffloat = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter second name");
				lfloat = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("The Answer is = ");
			Console.WriteLine(ffloat / lfloat);
			Console.WriteLine("press anykey to cancel");
			Console.ReadLine();
		Console.WriteLine("__________________________________________________");		     
			}
			else {
				Console.WriteLine("Your input is invalid");
				Console.WriteLine("Press anykey to quit");
				Console.ReadKey();
			}
		}
	}
}