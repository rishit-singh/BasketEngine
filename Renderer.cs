using System;
using BasketEngine.Cartesian; 

namespace BasketEngine.Renderer
{
	public class Renderer
	{	
		public static bool IsRunning;

		public static bool RenderLoop(Cartesian2D cartesian)
		{
			Renderer.IsRunning = true;

			while (Renderer.IsRunning)
			{
				Console.Clear();
				Renderer.Render(cartesian);
			}

			Console.WriteLine();

			return true; 
		}

		/// <summary>
		/// Breaks the rendering loop
		/// </summary>
		public static void Terminate()
		{
			Renderer.IsRunning = false;
		}
		
		public static void Render(Cartesian2D cartesian)
		{
			for (double y = cartesian.Resolution.Y ; y >= -cartesian.Resolution.Y; y -= 0.1f)	//	Y-axis
			{	
				for (double x = -cartesian.Resolution.X; x <= cartesian.Resolution.X; x += 0.1f)	//	X - Axis
					for (int i = 0; i < cartesian.Characters.Length; i++)
					{
						if (cartesian.Characters[i].Position.X == x && cartesian.Characters[i].Position.Y == y)	//	Checks if the current loop postion is same as one of the vectors.
						{
							Console.ForegroundColor = cartesian	.Characters[i].Color;	//	Changes the foreground color 
							Console.BackgroundColor = cartesian.Characters[i].BackgroundColor;	//	Changes the foreground color 

							Console.Write(cartesian.Characters[i].CharacterValue);	//	Prints the value
						}
					}	

				Console.WriteLine(); 	
			}

			Console.WriteLine();	//	temporary			
		}
	}
}