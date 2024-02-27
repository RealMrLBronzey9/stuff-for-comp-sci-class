using System.Net;

namespace Smoothie{
    class Program{
        static void Main(string[] args){

            // Cup Variables
            char cupSize;
            int cupCost = 0;    // Cost is the amount of oz in the cup
            
            // Ingredient variables
            int amountOfIngredients;

            // Cost variables
            double finalCost;

            // Display welcome message
            Console.WriteLine("Welcome to the smoothie calculator!");
            


            // Display cup sizes in oz and ask user what cup size they want (using S, M, L, or X)
            Console.WriteLine("Cup Sizes:\n(S)mall - 10 oz\n(M)edium - 12 oz\n(L)arge - 15 oz\nE(X)tra Large - 30 oz");
            Console.WriteLine("Enter desired cup size (S, M, L or X): ");
            
            cupSize = Convert.ToChar(Console.ReadLine());

            // Check if user input is a valid cup size
            if (cupSize == 'S'){    // Small
                cupCost = 10;
            }
            else if(cupSize == 'M'){    // Medium
                cupCost = 12;
            }
            else if(cupSize == 'L'){    // Large
                cupCost = 15;
            }
            else if(cupSize == 'X'){    // Extra Large
                cupCost = 30;
            }
            else{
                // Cup size invalid, give user default smoothie
                Console.WriteLine("Congratulations for choosing a Gallon of Water as your drink! The cost of your smoothie will be PHP 900000000");
                Environment.Exit(0);    // End program
            }



            // Display to the user the amount of ingredients they can add
            Console.WriteLine("You can add a max of 10 ingredients to your smoothie");
            Console.WriteLine("Enter desired amount of ingredients (1-10)");

            // Get user choice on amount of ingredients
            amountOfIngredients = Convert.ToInt32(Console.ReadLine());

            // Check if user amount of ingredients is between 1-10
            if (amountOfIngredients >= 1 && amountOfIngredients <= 10){
                // Continue program
                Console.WriteLine($"You selected {amountOfIngredients} ingredients!");
            }
            else{
                // Amount of ingredient size invalid, give user double default smoothie
                Console.WriteLine("Congratulations for choosing two Gallons of Water as your drink! The cost of your smoothhie will be PHP 1800000000");
                Environment.Exit(0);
            }



            // Calculate smoothie cost
            finalCost = Convert.ToDouble((0.1 * amountOfIngredients * cupCost) + 1.75);
            finalCost = Math.Round(finalCost, 2);   // Round to two decimals (no one wants an output of 5.3500000000000005)
            
            // Display final cost of smoothie
            Console.WriteLine($"Congratulations for choosing a smoothie with a cupsize of {cupCost}oz and {amountOfIngredients} ingredients!\nThe cost of the smoothie will be ${finalCost}");

            Environment.Exit(0);

        }
    }
}