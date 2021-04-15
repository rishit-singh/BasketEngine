using System; 
using System.Text; 
using System.Collections;
using System.Collections.Generic;
using BasketEngine.Tools;

namespace BasketEngine.Cartesian
{

	/// <summary>
	/// Stores a 2D vector
	/// </summary>
	public class Vector2D
	{
		public double X, Y;	//	X and Y coordinates

		public Vector2D()
		{
			this.X = 0;
			this.Y = 0;
		}

		public Vector2D(double x, double y)
		{
			this.X = x; 
			this.Y = y;
		}

		public static Vector2D operator +(Vector2D lhs, Vector2D rhs)	//	+ operator overload
		{
			return new Vector2D(lhs.X + rhs.X, lhs.Y  + rhs.Y);
		}
		
		public static Vector2D operator -(Vector2D lhs, Vector2D rhs)	//	- operator overload
		{
			return new Vector2D(lhs.X - rhs.X, lhs.Y - rhs.Y);
		}
		
		public static Vector2D operator *(Vector2D lhs, Vector2D rhs)	//	+ operator overload
		{
			return new Vector2D(lhs.X * rhs.X, lhs.Y * rhs.Y);
		}

		public static Vector2D operator /(Vector2D lhs, Vector2D rhs)	//	+ operator overload
		{
			return new Vector2D(lhs.X / rhs.X, lhs.Y  / rhs.Y);
		}
	}

	/// <summary>
	/// Stores a 2D Cartesian plane 
	/// </summary>
	public class Cartesian2D	
	{
		public Character[] Characters;		//	Stores all the character instances of the current Cartesian2D instance.

		public Vector2D Resolution;	//	Resolution of the current cartesian

		protected Stack<Character> CharacterStack;	//	Stack storing all character instances.	

		private void SortCharacterArray()
		{
			for (int x = 0; x < this.Characters.Length; x++)
				for (int y = 0; y < (this.Characters.Length - x - 1); x++)
					if (this.Characters[x].Position.Y > this.Characters[x + 1].Position.Y)
						GeneralTools.Swap<Character>(ref this.Characters[x], ref this.Characters[x + 1]);
		}


		public void AddCharacter(Character character)
		{
			this.CharacterStack.Push(character);
		}

		public void Update()
		{
			this.Characters = this.CharacterStack.ToArray();
			
			this.SortCharacterArray();
		}

		public Cartesian2D(Vector2D resolution)
		{
			this.Resolution = resolution;

			this.CharacterStack = new Stack<Character>();

			this.Characters = this.CharacterStack.ToArray();
			
			this.SortCharacterArray();
		}

		public Cartesian2D(Vector2D resolution, Character initialCharacter)
		{
			this.Resolution = resolution;

			this.CharacterStack = new Stack<Character>();
			
			this.CharacterStack.Push(initialCharacter);

			this.Characters = this.CharacterStack.ToArray();

			this.SortCharacterArray();
		}

		public Cartesian2D(Vector2D resolution, Character[] characters)
		{
			this.Resolution = resolution;

			this.CharacterStack = new Stack<Character>();
			
			for (int x = 0; x < characters.Length; x++)
				this.CharacterStack.Push(characters[x]);

			this.Characters = this.CharacterStack.ToArray();
			
			this.SortCharacterArray();
		}
	}
}