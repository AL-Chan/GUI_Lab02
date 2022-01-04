using System;
namespace FirstApp
{
	class ProgramIF
	{
		static void Main(string[] args)
		{
			// I
			int r = int.Parse(Console.ReadLine()); //чтение значения радиуса круга
			int a = int.Parse(Console.ReadLine()); //чтение значения стороны квадрата

			//II
			string outMessage0r = "";
			string outMessage0a = "";
		
			if (r <= 0)
			    { 
    			    outMessage0r = ("Некорректное значение " + r + " для радиуса круга! Введите заново.");
    				Console.WriteLine(outMessage0r);
			    }
			else
			    {
			    }
			
			if (a <= 0)
                {
                    outMessage0a = ("Некорректное значение " + a + " для стороны квадрата! Введите заново.");
                    Console.WriteLine(outMessage0a);
                }
            else
                {
                }
             
                    if (a<=0 || r<=0) // проверка на неотрицательность значений
                    {
                        return;
                    }
                    else
                    {
                        goto Result;
                    }
            
            //
            Result:
			var Ssq = a * a; // формула площади квадрата
			var Sci = 3.14 * (r * r); // формула площади круга

			string outMessage1 = "";
            
			if (Ssq < Sci)  // условие
			{
				outMessage1 = ("Площадь круга больше площади квадрата. Sci > Ssq");
			}
			else
			{
				outMessage1 = ("Площадь квадрата больше площади круга. Ssq > Sci");
			}
			///III 
            //Console.WriteLine(outMessage0);
			Console.WriteLine(outMessage1);
			Console.ReadLine();

		}
	}
}