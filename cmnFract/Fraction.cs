/*
 * Created by SharpDevelop.
 * User: Nicol
 * Date: 25.3.2021 г.
 * Time: 8:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace cmnFract
{
	public class Fraction
	{
		public int num, denom;
		public Fraction()
		{
			num = 0;
			denom = 1;
		}
		public Fraction(int n)
		{
			num = n;
			denom = 1;
		}
		public Fraction(int n, int d)
		{
			num = n;
			if(d == 0) throw new ArgumentException("Забранени неща!");
			denom = d;
			if(d < 0)
			{
				denom = (-1) * d;
				num *= (-1);
			}
		}
		public Fraction(Fraction other)
		{
			num = other.num;
			denom = other.denom;
		}
		private static int GCD(int a, int b)
		{
			int q;
            while (b != 0)
            {
                q = b;
                b = a % b;
                a = q;
            }
            return a;
		}
		public void Add(Fraction other)
		{
			int r;
			num = num * other.denom + other.num * denom;
			denom *= other.denom;
			r = GCD(num, denom);
			if(r > 1)
			{
				num /= r;
				denom /= r;
			}
		}
		public void Sub(Fraction other)
		{
			int r;
			num = num * other.denom - other.num * denom;
			denom *= other.denom;
			r = GCD(num, denom);
			if(r > 1)
			{
				num /= r;
				denom /= r;
			}
		}
		public void Mult(Fraction other)
		{
			int r;
			num *= other.num;
			denom *= other.denom;
			r = GCD(num, denom);
			if(r > 1)
			{
				num /= r;
				denom /= r;
			}
		}
		public void Div(Fraction other)
		{
			int r;
			num *= other.denom;
			denom *= other.num;
			r = GCD(num, denom);
			if(r > 1)
			{
				num /= r;
				denom /= r;
			}
		}
		public override string ToString()
		{
			if(denom == 1) return string.Format("{0}", num);
			return string.Format("{0}/{1}", num, denom);
		}
		public static Fraction operator + (Fraction f1, Fraction f2)
		{
			Fraction f = new Fraction(f1);
			f.Add(f2);
			return f;
		}
		public static Fraction operator - (Fraction f1, Fraction f2)
		{
			Fraction f = new Fraction(f1);
			f.Sub(f2);
			return f;
		}
		public static Fraction operator * (Fraction f1, Fraction f2)
		{
			Fraction f = new Fraction(f1);
			f.Mult(f2);
			return f;
		}
		public static Fraction operator / (Fraction f1, Fraction f2)
		{
			Fraction f = new Fraction(f1);
			f.Div(f2);
			return f;
		}
	}
}
