using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {



        public UserInterface()
        {

        }

        //displays the main menu and asks for input
        public void DisplayMainMenu(List<Droid> droid, DroidCollection droidCollection)
        {
            bool quitMain = true;

            do
            {
                Console.WriteLine("Welcome to Droid manager");
                Console.WriteLine("1.Add a Droid");
                Console.WriteLine("2.Print the list of Droids");
                Console.WriteLine("3.Exit");

                string optionSelection = Console.ReadLine();
                if (optionSelection == "1")
                {
                    addDroidUI(droid, droidCollection);

                }
                else if (optionSelection == "2")
                {
                    //Print the list
                }
                else if (optionSelection == "3")
                {
                    Environment.Exit(0);
                }


            } while (quitMain != true);
        }

        private void addDroidUI(List<Droid> droid, DroidCollection droidCollection) {
			List<object> parameters;
			int droidtype;

            //Print the Droid models
			Console.WriteLine("Please select a number for Droid type");
			Console.WriteLine("1 : Protocol Droid");
			Console.WriteLine("2 : Utility Droid");
			Console.WriteLine("3 : Janitor Droid");
			Console.WriteLine("4 : Astromech Droid");

            //Get the color, and material
			Console.Write("Enter a Color:  ");
			parameters.Add(new (Console.ReadLine));
			Console.Write("Enter a Material:  ");
			parameters.Add(new(Console.ReadLine));
			
			string droidSelection = Console.ReadLine ();

            //Check which droid was selected by the user and ask for options
            switch (droidSelection)
	        {
                case "1":
                    Console.WriteLine ("Protocol Droid Selected");
				    droidtype = 1;
                    parameters.Add ("Protocol");
				    Console.WriteLine("Enter the number of languages");
                    parameters.Add(Console.ReadLine());
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
                case "2":
                    Console.WriteLine ("Utility Droid Selected");
				    droidtype = 2;
                    parameters.Add ("Utility");
				    Console.WriteLine("Toolbox?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("Computer Connection?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("arm?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
                case "3":
                    Console.WriteLine ("Janitor Droid Selected");
				    droidtype = 3;
                    parameters.Add ("Janitor");
				    Console.WriteLine("Toolbox?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("Computer Connection?(1:yes/2:no");
                    Console.WriteLine("arm?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("Trash Compactor?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("Vacuum?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
                case "4":
                    Console.WriteLine ("Astromech Droid Selected");
				    droidtype = 4;
                    parameters.Add ("Astromech");
				    Console.WriteLine("Toolbox?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("Computer Connection?(1:yes/2:no");
                    Console.WriteLine("arm?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("Fire Extinquisher?(1:yes/2:no");
                    parameters.Add(hasFeature());
                    Console.WriteLine("how many per ship?");
                    parameters.Add(Console.ReadLine());
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
	           }

        }

        //to check if feature is selected
        private bool hasFeature()
        {
            if (Console.ReadLine() == "1") { return (true); }
            else { return false; }
        }
    }


}
