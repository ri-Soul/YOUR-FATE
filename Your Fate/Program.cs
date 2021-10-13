using System;

namespace Your_Fate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "YourFate";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Random numberGen = new Random();

            string[] wizard =
            {
                "Gandalf de gray", "Gandalf The Gray", "Gandalf The White", "Saruman", "Radagast The Brown" 
            };
            
            int numb = numberGen.Next(0, 5);

            Console.WriteLine("You get: " + wizard[numb] );

            Console.ReadKey();

            if(numb != 0)
            {
                if(numb != 1)
                {
                    if(numb != 2)
                    {
                        if(numb != 3)
                        {
                            if(numb != 4)
                            {
                                Console.WriteLine("ERROR");
                            }else
                            {
                                Console.WriteLine("Hello my name is Radagast The Brown and i will predict your fate.");
                            }
                        }else
                        {
                            Console.WriteLine("Hello my name is Saruman and i will predict your fate.");
                        }
                    }else
                    {
                        Console.WriteLine("Hello my name is Gandalf The White and i will predict your fate.");
                    }

                }else
                {
                    Console.WriteLine("Hello my name is Gandalf The Gray and i will predict your fate.");
                }
            }else
            {
                Console.WriteLine("Hello my name is Gandalf The Gay and i will predict your fate.");
            }

            Console.ReadKey();
            geslacht();
        }

        public static void geslacht() 
        {

            string[] geslacht = 
            {
                "Gril", "Boy"
            };

            string[] Jongens =
            {"Noah", "Sem", "Liam", "Lucas", "Daan", "Finn", "Levi", "James", "Milan", "Sam", "Nour", "Benjamin", "Luca", "Bram", "Mason", "Max", "Thomas", "AdamHugo",
            "Jesse", "Boaz", "Olivier", "Teun", "Julian", "Lars", "Thijs", "Gijs", "Siem", "Guus", "Mats", "Zayn", "Otis", "Jens", "Jack", "Floris", "Ties", "Vince",
            "Joep", "David", "Jan","Stijn", "Sven", "Dex", "Jurre", "Morris", "Ruben", "Owen", "Jayden", "Mohammed", "Tobias", "Moos", "Tim", "Abel", "Tijn", "Jace",
            "Willem", "Oliver", "Cas", "Fedde", "Ryan", "Jaxx", "Roan", "Quinn", "Xavi", "Daniël", "Dani", "Alexander", "Dean", "Jake", "Seppe", "Ezra", "Mohamed",
            "Pepijn","Tom", "Jason", "Aiden", "Jax", "Nathan", "Kai", "Rayan", "Pim", "Oscar", "Elias", "Melle", "Boris", "Mick", "Senne", "Samuel", "Lenn", "Hidde",
            "Amir", "Johannes", "Job", "Joshua", "Niek", "Tygo", "Stef", "Arthur"
            };

            string[] Meisjes = 
            { "Emma", "Julia", "Mila", "Tess", "Sophie", "Zoë", "Sara", "Nora", "Yara", "Eva", "Liv", "Lotte", "Evi", "Noor", "Anna", "Milou", "Olivia", "Saar", "Lauren",
             "Nina", "Lieke", "Fleur", "Lynn", "Sofie", "Elin", "Fien", "Nova", "Sarah", "MaudLina", "Mia", "Loïs", "Sofia", "Emily", "Roos", "Fenna", "Ella", "Isa",
             "Hailey", "Luna", "Hannah", "Julie", "Noa", "Elena", "Sophia", "Bo", "Suze", "Lara", "Maria", "Jasmijn", "Lena", "Esmee", "Cato", "Amy", "Vera", "Lisa",
             "Liz", "Juul", "Floor", "Hanna", "Norah", "Rosa", "Noé", "Ivy", "Charlotte", "Isabella", "Amber", "Feline", "Elise", "Puck", "Veerle", "Lizzy", "Lize",
             "Linde", "Livia", "Naomi", "Rosie", "Charlie", "Merel", "Isabel", "Liva", "Fenne", "Anne", "Maeve", "Kiki", "Jill", "Amira", "Benthe", "Iris", "Romy",
             "Romée", "Eline", "Sanne", "Tessa", "Fiene", "Lola", "Loua", "Femke", "Nola", "Fay"
            };

            Random numberGen = new Random();

            int numb2 = numberGen.Next(0, 2);

            Console.WriteLine("You are a " + geslacht[numb2]);

            Console.ReadKey();

            if(numb2 != 0)
            {
                if(numb2 != 1)
                {
                    Console.WriteLine("ERROR");

                }else
                {
                    int numb3 = numberGen.Next(0, 100);
                    Console.WriteLine("Your name is " + Jongens[numb3] );
                }
            }else
            {
                int numb3 = numberGen.Next(0, 100);
                Console.WriteLine("Your name is " + Meisjes[numb3] );
            }

            Console.ReadKey();
            home();
        }

        public static void home() 
        {
            string[] home = 
            {
                "an apartment", "a bungalow", "a penthouse", "a studio", "a villa", "a house", "a cardboard box"
            };

            Random numberGen = new Random();

            int numb4 = numberGen.Next(0, 6);

            Console.WriteLine("You live in " + home[numb4]);

            Console.ReadKey();
            Pet();

        }

        public static void Pet()
        {
            string[] pets =
            {
                "a kangourou", "a dog", "a monkey", "a cat", "a rabbit", "a turtle", "a lama", "a horse", "a pig", "a donkey"
            };

            Random numberGen = new Random();

            int numb5 = numberGen.Next(0, 10);

            Console.WriteLine("Your pet is " + pets[numb5]);

            Console.ReadKey();
            food();
        }

        public static void food()
        {
            string[] food =
            {
                "a pizza", "a haribo", "a macaroni", "a fries", "a icecream", "a mango", "a taco", "a kebab", "a steak", "a croque monsieur", "a hamburger", "legobloxs",
                "a shoe", "one single gummy bear", "a stone", "a person", "a book", "a patat", "la baguette"
            };

            Random numberGen = new Random();

            int numb6 = numberGen.Next(0, 18);

            Console.WriteLine("Tonight you are going to eat " + food[numb6]);

            Console.ReadKey();
            petname();
        }

        public static void petname()
        {
            string[] petnames =
            {
                "Momo", "Appa", "Alpha", "Haribo"
            };
            Random numberGen = new Random();

            int numb7 = numberGen.Next(0, 4);

            Console.WriteLine("Your pets name is " + petnames[numb7]);

            Console.ReadKey();
            Your_Fate();
        }

        public static void Your_Fate()
        {
            string[] YourFate =
            {
                "You got cancer and you died.", "You lived happily ever after.", "You committed suicide.",
                "You were run over by a truck.", "You made many friends and lived happily ever after."
            };

            Random numberGen = new Random();

            int numb8 = numberGen.Next(0, 5);

            Console.WriteLine("You ended: " + YourFate[numb8]);

            Console.ReadKey();

        }

    }

}
 