using System;
using System.Collections.Generic;

namespace BasketEngine.Tools
{
	/// <summary>
	/// General subroutines helpful for implementation of various algorithms
	/// </summary>
	public class GeneralTools
	{
		/// <summary>
		/// Swaps the values of the provided references of variables.
		/// </summary>
		/// <param name="a">First variable.</param>
		/// <param name="b">Second variable.</param>
		/// <typeparam name="T">Type of the variable.</typeparam>
		public static void Swap<T>(ref T a, ref T b)
		{
			T temp = a; 

			a = b;
			b = a; 
		}
	}
}