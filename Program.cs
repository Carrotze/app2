using System;

class Program
{
  public static void Main(string[] args)
  {

    Dice dicey = new();
    void MainMenu()
    {
      //---------------Declared Variables--------------------
      int selector;
      //---------------Displayed Lines-----------------------
      Console.WriteLine("DnD Character Sheet by @Carrotze");
      Console.WriteLine();
      Console.WriteLine("1. Create Character");
      Console.WriteLine("2. Load Character");
      Console.WriteLine("3. Roll some dice");
      Console.WriteLine();
      Console.WriteLine("Please enter the number of the action you want to use.");
      selector = Uinput.fIntInput(3);
      switch (selector)
      {
        case 1:
          Console.WriteLine("Placeholder Create Character");
          break;
        case 2:
          Console.WriteLine("Placeholder Load Character");
          break;
        case 3:
          dicey.fRollDice();
          break;
      }



      //--------------Loop for User Input-------------------

    }
    void selector()
    {



    }
    //dicey.fRollDice();
    MainMenu();
  }
}