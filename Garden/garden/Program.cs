namespace Garden {
    class Program{
        static void Main(string[] args){
            const double PI = 3.141592653589;
            double length, width, area, perimeter;
            double radius, circumference;
            string name;
            int choice;

            // Introduction and ask user for their name
            Console.WriteLine("Welcome to my garden creator store where I can summon gardens!");
            Console.WriteLine("What is your full legal name?");
            name = Console.ReadLine();

            // Ask if user wants a rectangle or circle garden
            Console.WriteLine("Do you want your garden to be a rectangle or a circle?");
            Console.WriteLine("1 = rectangle | 2 = circle");
            choice = Convert.ToInt32(Console.ReadLine());

            // Determine choice
            if(choice == 1){    // Rectangle

                // Ask for garden parameters
                Console.WriteLine("What is the length of your garden going to be?");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What is the width of your garden going to be?");
                width = Convert.ToDouble(Console.ReadLine());

                // Calculate perimeter and area of garden
                perimeter = (2 * length) + (2 * width);
                area = length * width;

                // Output the garden parameters to the user
                Console.WriteLine("I now summon the garden with the following parameters!!!");
                Console.WriteLine($"You want the length of the garden to be {length} smoots!"); // Smoots!! https://en.wikipedia.org/wiki/Smoot
                Console.WriteLine($"You want the length of the garden to be {width} smoots!");
                Console.WriteLine($"Your garden will have a perimeter of {perimeter} smoots!");
                Console.WriteLine($"Your garden will have an area of {area} square smoots!");
            }
            else if(choice == 2){   // Circle
                
                // Ask for garden parameters
                Console.WriteLine("What is the radius of your garden?");
                radius = Convert.ToDouble(Console.ReadLine());

                // Calculate circumference and area
                circumference = 2*PI*radius;
                area = PI*(radius*radius);

                // Output the garden parameters to the user
                Console.WriteLine("I now summon the garden with the following parameters!!!");
                Console.WriteLine($"You want the radius of the garden to be {radius} smoots which means the diameter will be {radius*2} smoots!");
                Console.WriteLine($"Your garden will have a circumference of {circumference} smoots!");
                Console.WriteLine($"Your garden will have an area of {area} square smoots!");
            }
            
            // Congratulate to the user on their new garden
            Console.WriteLine($"Congratulations {name}! You are now a proud owner of a garden! If you need any help tending to it or to exterminate it, my garden creator store is always available!!");
            Console.WriteLine("The price of the garden will be €7994.99. Failure to pay will result in the extermination of your garden.");
            



        }
    }
}