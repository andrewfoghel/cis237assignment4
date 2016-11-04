using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new droid collection and set the size of it to 100.
            IDroidCollection droidCollection = new DroidCollection(100);



            //Hardcode droids to collection, varied to prove sort works, put in groups of 4
            //Set 1
            //Protocol
            droidCollection.Add("Carbonite", "Protocol", "Bronze", 4);
            //Astromech
            droidCollection.Add("Vanadium", "Astromech", "Silver", true, true, true, false, 4);
            //Utility
            droidCollection.Add("Quadranium", "Utility", "Gold", true, false, true);
            //Janitor
            droidCollection.Add("Carbonite", "Janitor", "Silver", true, true, false, false, true);
          
            //Set 2
            //Protocol
            droidCollection.Add("Vanadium", "Protocol", "Gold", 3);
            //Astromech
            droidCollection.Add("Quadranium", "Astromech", "Silver", false, true, true, false, 5);
            //Utility
            droidCollection.Add("Carbonite", "Utility", "Bronze", true, true, false);
            //Janitor
            droidCollection.Add("Carbonite", "Janitor", "Gold", false, true, true, false, true);

            //Set 3
            //Protocol
            droidCollection.Add("Vanadium", "Protocol", "Gold", 1);
            //Astromech
            droidCollection.Add("Vanadium", "Astromech", "Bronze", true, false, false, false, 2);
            //Utility
            droidCollection.Add("Quadranium", "Utility", "Silver", false, true, true);
            //Janitor
            droidCollection.Add("Quadranium", "Janitor", "Gold", true, true, true, true, true);



            //Create a user interface and pass the droidCollection into it as a dependency
            UserInterface userInterface = new UserInterface(droidCollection);

            //Display the main greeting for the program
            userInterface.DisplayGreeting();

            //Display the main menu for the program
            userInterface.DisplayMainMenu();

            //Get the choice that the user makes
            int choice = userInterface.GetMenuChoice();

            //While the choice is not equal to 3, continue to do work with the program
            while (choice != 5)
            {
                //Test which choice was made
                switch (choice)
                {
                    //Choose to create a droid
                    case 1:
                        userInterface.CreateDroid();
                        break;

                    //Choose to Print the droid
                    case 2:
                        userInterface.PrintDroidList();
                        break;

                    //Choose to sort by model
                    case 3:
                        userInterface.sortModel();
                        break;

                    //Choose to sort by total cost

                    case 4:
                        userInterface.sortCost();
                        break;


        }

                //Re-display the menu, and re-prompt for the choice
                userInterface.DisplayMainMenu();
                choice = userInterface.GetMenuChoice();

            }
        }
    }
}

