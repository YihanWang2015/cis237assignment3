//Yihan Wang
//CIS237 Assignment 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance of droid list object created
			List<Droid> droid = new List<Droid>();


            //instance of user interface
            UserInterface ui = new UserInterface();

            //instance of droid collection
            DroidCollection droidCollection = new DroidCollection();

            //display Main Menu of program 
            ui.DisplayMainMenu(droid, droidCollection);




        }
    }
}
