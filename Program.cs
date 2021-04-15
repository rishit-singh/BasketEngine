using System;
using System.Collections;
using System.Collections.Generic;
using BasketEngine; 
using BasketEngine.Cartesian; 
using BasketEngine.Renderer; 

class Program
{	
	static Character[] GenerateCharacterArray(double h, double v)
	{
		Stack<Character> CharacterStack = new Stack<Character>(); 
		for (double y = v; y >= -v; y -= 0.1f)
			for (double x = -h; x <= h; x += (0.1f))
				CharacterStack.Push(new Character(' ', new Vector2D(x, y), (ConsoleColor)new Random().Next(0, 15), (ConsoleColor)new Random().Next(0, 15)));	

		return CharacterStack.ToArray(); 
	}

	static void Main()
	{	
		Renderer.Render(new Cartesian2D(new Vector2D(6, 3), Program.GenerateCharacterArray(6, 3)));
	}
}