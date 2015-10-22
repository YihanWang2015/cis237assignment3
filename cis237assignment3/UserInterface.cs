//Yihan Wang
//CIS237 Assignment 3

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
            bool quitMain = false;

            do
            {
                Console.WriteLine("Welcome to Droid manager");
				Console.WriteLine("Enter the number of the desired choice");
                Console.WriteLine("1.Add a Droid");
                Console.WriteLine("2.Print the list of Droids");
                Console.WriteLine("3.Exit");
				Console.Write("Select an option: ");
                string optionSelection = Console.ReadLine();
                if (optionSelection == "1")
                {
                    addDroidUI(droid, droidCollection);

                }
                else if (optionSelection == "2")
                {
					droidCollection.printDroidList(droid);
                }
                else if (optionSelection == "3")
                {
					Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
	

            } while (quitMain != true);
        }

		private void addDroidUI(List<Droid> droid, DroidCollection droidCollection) {
			List<string> parameters = new List<string>();
			int droidtype;
			string tools,arm,connection;
			string trash,vacuum,fire;


            //Get the color, and material
			Console.Write("Select a Material (default 1.Plastic):\n1.Plastic (20)\n2.Metal(40)\n");
			string material = Console.ReadLine();
			if (material == "2")
				material = "Metal";
			else
				material = "Plastic";
			parameters.Add (material);
			Console.Write("Select a Color (default 1.Silver):\n1.Silver\n2.Black\n");
            string color = Console.ReadLine();
			if (color == "1")
				color = "Silver";
			else
				color = "Black";
            parameters.Add(color);


			//Print the Droid models
			Console.WriteLine("Please select a number for Droid type");
			Console.WriteLine("1 : Protocol Droid");
			Console.WriteLine("2 : Utility Droid");
			Console.WriteLine("3 : Janitor Droid");
			Console.WriteLine("4 : Astromech Droid\n");			

			string droidSelection = Console.ReadLine ();

            //Check which droid was selected by the user and ask for options

			switch (droidSelection) {

			case "1":
				Console.WriteLine ("Protocol Droid Selected");
				droidtype = 1;
				parameters.Add ("Protocol");

				Console.WriteLine ("Enter the number of languages");
				string languages = Console.ReadLine ();
				parameters.Add (languages);
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
			case "2":
				Console.WriteLine ("Utility Droid Selected");
				droidtype = 2;
				parameters.Add ("Utility");
				Console.WriteLine ("Toolbox?(1:yes/2:no)");
				tools = Console.ReadLine ();
				if (tools == "yes" || tools == "1")
					tools = "1";
				else
					tools = "2";
				parameters.Add (tools);
				Console.WriteLine ("Computer Connection?(1:yes/2:no)");
				connection = Console.ReadLine ();
				if (connection == "yes" || connection == "1")
					connection = "1";
				else
					connection = "2";
				parameters.Add (connection);
				Console.WriteLine ("arm?(1:yes/2:no)");
				arm = Console.ReadLine ();
				if (arm == "yes" || arm == "1")
					arm = "1";
				else
					arm = "2";					
					parameters.Add(arm);
                	droidCollection.addDroid(droid, droidtype,parameters);
                    break;
			case "3":
					Console.WriteLine ("Janitor Droid Selected");
					droidtype = 3;
					parameters.Add ("Janitor");
				Console.WriteLine ("Toolbox?(1:yes/2:no)");
					tools = Console.ReadLine ();
				if (tools == "yes" || tools == "1")
					tools = "1";
				else
					tools = "2";	
					parameters.Add (tools);
				Console.WriteLine ("Computer Connection?(1:yes/2:no)");
					connection = Console.ReadLine ();
				if (connection == "yes" || connection == "1")
					connection = "1";
				else
					connection = "2";
				
					parameters.Add (connection);
					Console.WriteLine ("arm?(1:yes/2:no");
					arm = Console.ReadLine ();
				if (arm == "yes" || arm == "1")
					arm = "1";
				else
					arm = "2";					
					parameters.Add (arm);
				Console.WriteLine ("Trash Compactor?(1:yes/2:no)");
					trash = Console.ReadLine ();
				if (trash == "yes" || trash == "1")
					trash = "1";
				else
					trash = "2";					
					parameters.Add (trash);
				Console.WriteLine ("Vacuum?(1:yes/2:no)");
					vacuum = Console.ReadLine ();
				if (vacuum == "yes" || vacuum == "1")
					vacuum = "1";
				else
					vacuum = "2";	
					parameters.Add(vacuum);
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
			case "4":
					Console.WriteLine ("Astromech Droid Selected");
					droidtype = 4;
					parameters.Add ("Astromech");
				Console.WriteLine ("Toolbox?(1:yes/2:no)");
					tools = Console.ReadLine ();
				if (tools == "yes" || tools == "1")
					tools = "1";
				else
					tools = "2";	
					parameters.Add (tools);
				Console.WriteLine ("Computer Connection?(1:yes/2:no)");
					connection = Console.ReadLine ();
				if (connection == "yes" || connection == "1")
					connection = "1";
				else
					connection = "2";
					parameters.Add (connection);
				Console.WriteLine ("arm?(1:yes/2:no)");
					arm = Console.ReadLine ();
				if (arm == "yes" || arm == "1")
					arm = "1";
				else
					arm = "2";							parameters.Add (arm);
				Console.WriteLine ("Fire Extinquisher?(1:yes/2:no)");
					fire = Console.ReadLine();
				if (fire == "yes" || fire == "1")
					fire = "1";
				else
					fire = "2";
                    parameters.Add(fire);
				Console.WriteLine("how many per ship?");
                    parameters.Add(Console.ReadLine());
                    droidCollection.addDroid(droid, droidtype,parameters);
                    break;
	           }
	          

        }
			
    }


}
