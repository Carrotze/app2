using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dice{
   			
            public Random rnd;
            public  Dice() //Constructor
                {
                    rnd = new Random();
                }
              public int fd4()
                {
                    int rd4 = rnd.Next(4)+1;
                    return rd4;
                }
            public int fd6()
                {
                    int rd6 = rnd.Next(6)+1;
                    return rd6;
                }
              public int fd8()
                {
                    int rd8 = rnd.Next(8)+1;
                    return rd8;
                }
              public int fd10()
                {
                    int rd10 = rnd.Next(10)+1;
                    return rd10;
                }
              public int fd12()
                {
                    int rd12 = rnd.Next(12)+1;
                    return rd12;
                }
            public int fd20 ()
                {
                    int rd20 = rnd.Next (20)+1;
                    return rd20;
                }    
              public int fd100()
                {
                    int rd100 = rnd.Next(100)+1;
                    return rd100;
                }
            public int fStatRoll()
                {
                    int a, b, c, d;
                    a = fd6();
                    b = fd6();
                    c = fd6();
                    d = fd6();
                    int min = Math.Min(d, Math.Min(c, Math.Min(b,a))); 
                    return a+b+c+d-min;
                }
			public void fRollDice()
			{
				Console.Clear();
				Console.WriteLine("What dice do you want to roll?");
				Console.WriteLine("1. D4");
				Console.WriteLine("2. D6");
				Console.WriteLine("3. D8");
				Console.WriteLine("4. D10");
				Console.WriteLine("5. D12");
				Console.WriteLine("6. D20");
				Console.WriteLine("7. D100");
				Console.WriteLine("8. Back to Main Menu");
				
				int die=Uinput.fIntInput(8);
				switch (die) 
					{
					case 1:
					    Console.WriteLine(fd4());
					    break;
					case 2:
					    Console.WriteLine(fd6());
					    break;
					case 3:
					    Console.WriteLine(fd8());
					    break;
					case 4:
					    Console.WriteLine(fd10());
					    break;
					case 5:
					    Console.WriteLine(fd12());
					    break;
					case 6:
					    Console.WriteLine(fd20());
					    break;
					case 7:
					    Console.WriteLine(fd100());
					    break;
					case 8:
						Console.Clear();
						break;
					}
				
				
			}
          
  }