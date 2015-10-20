using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace cis237assignment3
{
    class DroidCollection
    {

        public DroidCollection()
        {

        }

        public void addDroid(List<Droid> droid, int droidtype, List<object> parameters)
        {
            //determine which droid is being used
            //add the information to the list

            if (droidtype == 1)
            {
                droid.Add(new Protocol(Convert.ToString(parameters[0]), Convert.ToString(parameters[1]), Convert.ToString(parameters[2]), Convert.ToInt32(parameters[3])));
                parameters.Clear();
            }
            else if (droidtype == 2)
            {
                droid.Add(new Utility(Convert.ToString(parameters[0]), Convert.ToString(parameters[1]), Convert.ToString(parameters[2]), Convert.ToBoolean(parameters[3]), Convert.ToBoolean(parameters[4]), Convert.ToBoolean(parameters[5])));
                parameters.Clear();
            }
            else if (droidtype == 3)
            {
                droid.Add(new Janitor(Convert.ToString(parameters[0]), Convert.ToString(parameters[1]), Convert.ToString(parameters[2]), Convert.ToBoolean(parameters[3]), Convert.ToBoolean(parameters[4]), Convert.ToBoolean(parameters[5]), Convert.ToBoolean(parameters[6]), Convert.ToBoolean(parameters[7])));
                //Clear list to allow for other Droids to be added
                parameters.Clear();
            }
            else if (droidtype == 4)
            {
                droid.Add(new Astromech(Convert.ToString(parameters[0]), Convert.ToString(parameters[1]), Convert.ToString(parameters[2]), Convert.ToBoolean(parameters[3]), Convert.ToBoolean(parameters[4]), Convert.ToBoolean(parameters[5]), Convert.ToBoolean(parameters[6]), Convert.ToInt32(parameters[7])));
                parameters.Clear();

            }
        }

        public void printDroidList(List<Droid> droid)
        {
            //Print the Droid list
            Console.WriteLine("Droids:");
            Console.WriteLine("Material \t Model \t Color \t Type \t Cost \t Optopns");
            Console.Write("--------------------------------------------------------");
            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < droid.Count; i++)
            {
                Console.WriteLine(droid[i]);
            }
        }
    }
}
