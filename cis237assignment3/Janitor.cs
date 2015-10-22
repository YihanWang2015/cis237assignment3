//Yihan Wang
//CIS237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        private bool trashCompactor, vacuum;
        private decimal trashCompactorCost = 10m;
        private decimal vacuumCost = 10m;


		public bool TrashCompactor
		{
			get { return this.trashCompactor; }
			set { this.trashCompactor = value; }
		}

		public bool Vacuum
		{
			get { return this.vacuum; }
			set { this.vacuum = value; }
		}



        //8 parameters with 6 base parameters
        public Janitor(string material, string color, string model,
                        bool toolbox, bool computerConnection, bool arm,
                        bool trashCompactor, bool vacuum)
            : base(material, color, model, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
			CalculateTotalCost ();
        }
			
        public void CalculateTotalCost()
        {
			if (!this.vacuum)
				vacuumCost = 0;
			if (!this.trashCompactor)
				trashCompactorCost = 0;

			//Cost for both options
			totalCost += vacuumCost + trashCompactorCost;
				
        }

        public override string ToString()
        {

			return base.ToString () + " " +  (this.trashCompactor ? "trash compactor " : " ") + (this.vacuum ? "vacuum " : " ");

        }
    }
}
