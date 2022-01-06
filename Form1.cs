using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Part01Var1_1
{
	public partial class Lab1_Var1 : Form
	{
		public Lab1_Var1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var r = int.Parse(this.textRadiusofCircle.Text);
			var a = int.Parse(this.textSideofSquare.Text);
			var outMessage0 = Logic.NonNegativity(r, a);
			
			var Sci = Logic.AreaCircle(r);
			var Ssq = Logic.AreaSquare(a);
			var outMessage1 = Logic.Compare(Ssq, Sci);

			if (r <= 0 || a <= 0)
            		{
				MessageBox.Show(outMessage0);
			}
        		else
            		{
				MessageBox.Show(outMessage1);
			}
		}
	}

	public class Logic
	{
		public static string NonNegativity(int r, int a) //проверка на неотрицательность значений
		{
			string outMessage0 = "";
			if (r <= 0 && a <= 0)
			{
				outMessage0 = ("Некорректное значение " + r + " для радиуса круга.\nНекорректное значение " + a + " для стороны квадрата.\nПовторите попытку.");
			}
			else if (r <= 0)
			{
				outMessage0 = ("Некорректное значение " + r + " для радиуса круга.\nПовторите попытку.");
			}
			else if (a <= 0)
			{
				outMessage0 = ("Некорректное значение " + a + " для стороны квадрата.\nПовторите попытку.");
			}
			else
			{
			}
			return outMessage0;
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

}
