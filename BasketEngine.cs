using System;
using BasketEngine.Cartesian;

namespace BasketEngine
{
	public class Character
	{
		public Vector2D Position;   //  Postion of the character in the cartesian plane

		public ConsoleColor Color,  // Foreground color of the character.
		BackgroundColor; 

		public char CharacterValue;	//	Character value 

		public Character(char characterValue)
		{
			this.CharacterValue = characterValue; 

			this.Position = new Vector2D(); 

			this.Color = ConsoleColor.White;    
			this.BackgroundColor = ConsoleColor.Black;    
		}

		public Character(char characterValue, int x, int y)
		{
			this.CharacterValue = characterValue;

			this.Position = new Vector2D(x, y);
			
			this.Color = ConsoleColor.White;
			this.BackgroundColor = ConsoleColor.Black;
		}

		public Character(char characterValue, int x, int y, ConsoleColor color)
		{
			this.CharacterValue = characterValue;
		
			this.Position = new Vector2D(x, y);
			
			this.Color = color;
			this.BackgroundColor = ConsoleColor.Black;
		}

		public Character(char characterValue, int x, int y, ConsoleColor color, ConsoleColor backgroundColor)
		{
			this.CharacterValue = characterValue;
		
			this.Position = new Vector2D(x, y);
			
			this.Color = color;
			this.BackgroundColor = backgroundColor;
		}

		public Character(char characterValue, Vector2D position)
		{
			this.CharacterValue = characterValue;
			this.Position = position;		
			this.Color = ConsoleColor.White;
			this.BackgroundColor = ConsoleColor.Black;
		}
		
		public Character(char characterValue, Vector2D position, ConsoleColor color)
		{
			this.CharacterValue = characterValue;
			this.Position = position;
			this.Color = color;
			this.BackgroundColor = ConsoleColor.Black;
		}

		public Character(char characterValue, Vector2D position, ConsoleColor color, ConsoleColor backgroundColor)
		{
			this.CharacterValue = characterValue;
			this.Position = position;
			this.Color = color;
			this.BackgroundColor = backgroundColor;
		}
	}
}
