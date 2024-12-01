using System.Drawing;
using System.Runtime.InteropServices.JavaScript;

namespace CodePractice
{
	public enum Color
	{
		white,
		yellow,
		purple,
		red
	}
	public class Ghost
	{
      public Color GhostColor { get; set; }

	}


	/// <summary>
	/// create a class ghost
	/// 
	/// ghost objects are instantiated without any arguments.
	/// ghost objects are given a random color attribute of
	/// "white" or "yellow" or "purple" or "red" when instantiated
	/// ghost = new ghost();
	/// ghost.color //=> "white" or "yellow" or "purple" or "red"
	/// </summary>
	public class Program
	{
		static void Main(string[] args)
		{
			Ghost ghost = new Ghost();
			Random rand = new Random();
			Type type = typeof(Color);
			Array values=type.GetEnumValues();
			int colorIndex=rand.Next(values.Length);
			ghost.GhostColor = (Color)values.GetValue(colorIndex);
			Console.WriteLine($"The ghost's color is: {ghost.GhostColor}");
            Console.WriteLine("please write down your input");
            string name=Console.ReadLine();
			Banjo.AreYouPlayingBanjo(name);
			//Color Ghost


		}
		
	}
}
