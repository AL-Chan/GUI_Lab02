using System;
namespace FirstApp
{
	public class Logic
	{
		public static string NonNegativity(int r, int a) //проверка на неотрицательность значений
		{
			string outMessage0r = "";
			string outMessage0a = "";
			
			if (r <= 0 && a <= 0) // для двух отрицательных значений
			{
				outMessage0r = ("Некорректное значение " + r + " для радиуса круга. Повторите попытку.");
				Console.WriteLine(outMessage0r);
				outMessage0a = ("Некорректное значение " + a + " для стороны квадрата. Повторите попытку.");
				Console.WriteLine(outMessage0a);
				Environment.Exit(0);
			}
			else
			{
			}

			if (r <= 0) // для отрицательного радиуса
			{
				outMessage0r = ("Некорректное значение " + r + " для радиуса круга. Введите заново.");
				Console.WriteLine(outMessage0r);
				Environment.Exit(0);
			}
			else
			{
			}

			if (a <= 0) // для двух отрицательной стороны
			{
				outMessage0a = ("Некорректное значение " + a + " для стороны квадрата. Введите заново.");
				Console.WriteLine(outMessage0a);
				Environment.Exit(0);

			}
			else
			{
			}

			return outMessage0r;
			return outMessage0a;
		}

		public static int AreaSquare(int a)
		{
			var Ssq = a * a; // формула площади квадрата
			return Ssq;
		}

		public static double AreaCircle(int r)
		{
            double s = 3.14 * (r * r);
            var Sci = s; // формула площади круга
			return Sci;
		}

		public static string Compare(int Ssq, double Sci) //тут дабл для отображения цифр после запятой
		{
			string outMessage1 = "";

			if (Ssq < Sci)  // условие
			{
				outMessage1 = (Sci + " > " + Ssq + "\nПлощадь круга больше площади квадрата.");
			}
			else
			{
				outMessage1 = (Ssq + " > " + Sci + "\nПлощадь квадрата больше площади круга.");
			}
			return outMessage1;
		}
	}

	class ProgramIF
	{
		static void Main(string[] args)
		{
			// I
			int r = int.Parse(Console.ReadLine()); //чтение значения радиуса круга
			int a = int.Parse(Console.ReadLine()); //чтение значения стороны квадрата

			// II

			var outMessage0r = Logic.NonNegativity(r, a);
			var Sci = Logic.AreaCircle(r);
			var Ssq = Logic.AreaSquare(a);
			var outMessage1 = Logic.Compare(Ssq, Sci);

			/// III 
			Console.WriteLine(outMessage1);
			Console.ReadLine();

		}
	}
}
