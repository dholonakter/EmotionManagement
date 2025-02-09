namespace ConsoleApp1;

public class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");
		List<double> list1 = new List<double>()
		{
			8, 10.7, 17.1, 11.2, 13.5, 9.9,14.9, 9.4, 9.4, 3.1, 12.7
		};
		checkpeak(list1);
		Console.WriteLine(nbPeaks);

	}
	static int nbPeaks = 0;

	static void checkpeak(List<double> list)
	{
		for (int i = 1; i < list.Count - 1; i++)
		{
			double current_value = list[i]; 
			double left_value = list[i - 1]; 
			double right_value = list[i + 1]; 
			
			double value = current_value - left_value; 
			double value2 = current_value - right_value; 

			if (value >= 5 & value2 >= 5)
			{
				nbPeaks++;
			}
			else if (value <= -5)
			{

				if (value2 <= -5)
				{

					nbPeaks++;


				}
			}
            Console.WriteLine();
        }

	}




}



