﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Drawing;

namespace CodePractice
{
	public class Sum
	{

		public static int SumDigit(int number)
		{
			number=Math.Abs(number);
			return number;


		}

		////
		///Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits. <summary>
		/// Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.
		/// </summary>
		/// For example: (Input --> Output)
		/// 10 --> 99 --> 18-32 --> 5Let's assume that all numbers in the input will be integer values.
		///
	}
	public class Banjo
	{


		public static string AreYouPlayingBanjo(string name)
		{
			string result = "";
			if (name.ToLower().StartsWith('r'))
			{
				return result = name + " plays banjo";

			}
			else
			{
				return name + " does not play banjo";

			}


			//Implement me
		}

				////
				///Create a function which answers the question "Are you playing banjo?".If your name starts with the letter "R" or lower case "r", you are playing banjo!The function takes a name as its only argument, and returns one of the following strings:name + " plays banjo" 
				////name + " does not play banjo"
				///Names given are always valid strings.
				//
			}


	/// <summary>
	/// Clock shows h hours, m minutes and s seconds after midnight.

       //	Your task is to write a function which returns the time since midnight in milliseconds.

       //	Example:
     //h = 0
    //m = 1
//s = 1

//result = 61000
//Input constraints:

//0 <= h <= 23
//0 <= m <= 59
//0 <= s <= 59

	/// </summary>
	public static class Clock
	{
		public static int Past(int h, int m, int s) 
		{
			if(h>=0 && h<=23 && m>=0 && m<=59 && s>=0 && s <= 59)
			{
				return (h * 3600000) + (m * 60000) + (s * 1000);

			}
			throw new ArgumentException("Invalid input for hours, minutes, or seconds.");

		}
	}

}
