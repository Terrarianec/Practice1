using System;
using System.Collections.Generic;

namespace Lib_9
{
	public class Dream
	{
		private static Random _random = new Random(0); // Немного предсказуемости

		/// <summary>
		/// Формирует n целых чисел в диапазоне 2-14 и находит сумму чисел меньше 8
		/// </summary>
		/// <param name="n">Количество сгенерированных чисел</param>
		/// <param name="numbers">Все сгенерированные числа</param>
		/// <returns>Сумма сгенерированных n чисел меньше 8</returns>
		public static int GetSumOfNIntegers(int n, List<int> numbers)
		{
			int sum = 0;

			while (n-- > 0)
			{
				int num = _random.Next(2, 15);

				if (num < 8)
				{
					sum += num;
				}

				numbers.Add(num);
			}

			return sum;
		}
	}
}
