//Yihan Wang
//CIS237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace cis237assignment3
{
	class DroidCollection:Droid
    {

        public DroidCollection()
        {

        }

		public void addDroid(List<Droid> droid, int droidtype, List<String> parameters)
        {
            //determine which droid is being used
            //add the information to the list

            if (droidtype == 1)
            {
				//Add to the List
                droid.Add(new Protocol(parameters[0],parameters[1],parameters[2], Convert.ToInt32(parameters[3])));
				//Calculate Cost

                parameters.Clear();
            }

            else if (droidtype == 2)
            {
				bool toolbox = checkBool (parameters [3]);
				bool computerConnection = checkBool (parameters [4]);
				bool arm = checkBool (parameters [5]);

				droid.Add(new Utility(parameters[0],parameters[1],parameters[2],toolbox,computerConnection,arm));
                parameters.Clear();
            }
            else if (droidtype == 3)
            {
				bool toolbox = checkBool (parameters [3]);
				bool computerConnection = checkBool (parameters [4]);
				bool arm = checkBool (parameters [5]);
				bool trashCompactor = checkBool(parameters[6]);
				bool vacuum = checkBool(parameters[7]);	

				droid.Add(new Janitor(parameters[0],parameters[1],parameters[2], toolbox,computerConnection,arm,trashCompactor,vacuum));
                //Clear list to allow for other Droids to be added
                parameters.Clear();
            }
            else if (droidtype == 4)
            {
				bool toolbox = checkBool (parameters [3]);
				bool computerConnection = checkBool (parameters [4]);
				bool arm = checkBool (parameters [5]);
				bool fireExtinquisher = checkBool(parameters[6]);

				droid.Add(new Astromech(parameters[0],parameters[1],parameters[2], toolbox,computerConnection,arm,fireExtinquisher, Convert.ToInt32(parameters[7])));
                parameters.Clear();

            }
        }

        public void printDroidList(List<Droid> droid)
        {
            //Print the Droid list
            Console.WriteLine("Droids:");
            Console.WriteLine("Material       Color         Model        Total Cost         Options");
            Console.Write("--------------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

			for (int i = 0; i < droid.Count(); i++)
			{
                Console.WriteLine(droid[i]);
            }
        }

		private bool checkBool(string value)
		{
			if (value == "1")
				return true;
			else
				return false;
	
		}
    }
}
