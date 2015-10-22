//Yihan Wang
//CIS237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {

        private bool toolbox, computerConnection, arm;
		protected decimal computerConnectionCost = 10m, armCost = 10m, toolboxCost = 10m;


        //six parameters constructor with three base parameters
		public Utility(string material, string color, string model, bool toolbox, bool computerConnection, bool arm)
			: base(material, color, model)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
			CalculateBaseCost ();
			CalculateTotalCost ();
        }

        public bool Toolbox
        {
            get { return this.toolbox; }
            set { this.toolbox = value; }
        }

        public bool ComputerConnection
        {
            get { return this.computerConnection; }
            set { this.computerConnection = value; }
        }

        public bool Arm
        {
            get { return this.arm; }
            set { this.arm = value; }
        }

        public void CalculateTotalCost()
        {
			if (!this.toolbox)
				toolboxCost = 0;
			if (!this.arm)
				armCost = 0;
			if (!this.computerConnection)
				computerConnectionCost = 0;
			
				//Cost for both options
				totalCost += toolboxCost + armCost + computerConnectionCost;

        }


        public override string ToString()
        {
			return base.ToString() + "      " +this.totalCost + "              "  + (this.toolbox ? "toolbox " : " ") + (this.arm ? "Arm " : " ") +(this.computerConnection ? "Connection" : " ") ;
        }

    }
}
