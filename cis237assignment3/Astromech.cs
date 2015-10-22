//Yihan Wang
//CIS237 Assignment 3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        private bool fireExtinquisher;
        private int numberShips;
        private const decimal COSTPERSHIP = 20.0m;
		private decimal fireExtinquisherCost = 10.0m;


        //Constructor with eight parameters with six base parameters
        public Astromech(string material, string color, string model,
                        bool toolbox, bool computerConnection, bool arm,
                        bool fireExtinquisher, int numberShips)
            : base(material, color, model, toolbox, computerConnection, arm)
        {
            this.fireExtinquisher = fireExtinquisher;
            this.numberShips = numberShips;
			CalculateTotalCost ();


        }


        //property of fire extinquisher
        public bool FireExtinquisher
        {
            get { return this.fireExtinquisher; }
            set { this.fireExtinquisher = value; }
        }

        //property of number ships
        public int NumberShips
        {
            get { return this.numberShips; }
            set { this.numberShips = value; }
        }


        public void CalculateTotalCost()
		{		
			//Set optional price
			if (!this.fireExtinquisher)
				fireExtinquisherCost = 0;

			//Cost
			totalCost += fireExtinquisherCost + this.numberShips * COSTPERSHIP; 
        }

        public override string ToString()
        {
			return base.ToString() + "  " + (this.fireExtinquisher ? "fire extinquisher " : " ") + "  " + "Number per ship: " + this.numberShips.ToString();
        }

    }
}
