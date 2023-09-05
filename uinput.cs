using System;

class uinput 
{
	public static int fIntInput(int howmany)
	{
		Console.WriteLine("Please enter the number of the action you want to take.");
		var inputAsString = Console.ReadLine();
		int inputAsInt;
		while((!int.TryParse(inputAsString, out inputAsInt) || inputAsInt<0 || inputAsInt>howmany))
		{
			Console.WriteLine("Your input must be an integer between 1 and " +howmany);
			inputAsString = Console.ReadLine();	
		}
		return inputAsInt;		
	}

	
}



