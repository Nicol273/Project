/*
 * Created by SharpDevelop.
 * User: Nicol
 * Date: 25.3.2021 г.
 * Time: 8:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cmnFract
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Въведете първата дроб");
			Console.Write("Числител: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Знаменател: ");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Въведете втората дроб");
			Console.Write("Числител: ");
			int c = int.Parse(Console.ReadLine());
			Console.Write("Знаменател: ");
			int d = int.Parse(Console.ReadLine());
			Fraction f1 = new Fraction(a, b);
			Fraction f2 = new Fraction(c, d);
			Console.WriteLine("{0} + {1} = {2}", f1, f2, f1 + f2);
			Console.WriteLine("{0} - {1} = {2}", f1, f2, f1 - f2);
			Console.WriteLine("{0} . {1} = {2}", f1, f2, f1 * f2);
			Console.WriteLine("{0} : {1} = {2}", f1, f2, f1 / f2);
			Console.ReadKey(true);
			Console.WriteLine("Въведете естествено числа A и B (A < B)");
			Console.Write("A: ");
			int A = int.Parse(Console.ReadLine());
			Console.Write("B: ");
			int B = int.Parse(Console.ReadLine());
			Fraction[] allFracts = new Fraction[B-A+1];
			int m = A;
			for(int i = 0; i < B-A+1; i++)
			{
				allFracts[i] = new Fraction(1, m);
				m++;
			}
			/*foreach(Fraction f in allFracts)
			{
				Console.WriteLine(f);
			}*/
			Fraction subTotal = new Fraction();
			for(int i = 0; i < allFracts.Length; i++)
			{
				subTotal = new Fraction(subTotal + allFracts[i]);
				Console.Write(allFracts[i]);
				if(i < allFracts.Length - 1) Console.Write(" + ");
			}
			Console.WriteLine(" = " + subTotal);
			Console.ReadKey(true);
		}
	}
}