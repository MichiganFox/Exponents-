// Method
// EXPONENTS / Powers Table
// Task: Display a table of powers. Ask the user if they would like to go again, and if so loop back to the beginning.
//The application prompts the user to enter an integer.

using System;
using System.Security.Cryptography.X509Certificates;

int numSelect = 0;
bool exponents = true;
while (exponents)
{
  
    
    Console.WriteLine("Please enter an integer between 1 and 1290.");
    numSelect = int.Parse(Console.ReadLine());
    if (numSelect < 1 || numSelect > 1290)
    {
        Console.WriteLine("You entered an invalid number. Pleae pick a number between 1 and 1290.");
        
    }
    else
    {
        for (int X = 1; X <= numSelect; X++) 
        {
            int numSquare = (X * X);
            int numCube = (X * X * X);              
            Console.WriteLine("Number\tSquared\tCubed");
            Console.WriteLine((X) + "\t"+numSquare + "\t"+numCube);
           //(String.Format("{0,8}{1,8}{2,8}", i, square(i), cube(i))
        }
    }
     Console.WriteLine("Do you want to continue? y/n");
    string userAnswer = Console.ReadLine();
    if(userAnswer == "no" || userAnswer == "n")
    {
        exponents = false;
    }
}
//static int cube(int numSelect) somethign to try later 









