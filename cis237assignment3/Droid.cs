//Yihan Wang
//CIS237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        //private variables for abstract droid class
        private string material;
        private string model;
        private string color;

        private decimal baseCost;
        protected decimal totalCost;

		//prices of material
		private decimal plasticCost = 20m;
		private decimal metalCost = 40m;

        //zero argument constructor 
        public Droid()
        {

        }

        //3 parameter constructors
        public Droid(string material, string color, string model)
        {
            this.material = material;
            this.model = model;
            this.color = color;
        }

        //property of material
        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }

        //property of model
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        //property of color
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //property of total cost
        public decimal TotalCost
        {
            get { return this.totalCost; }
            set { this.totalCost = value; }
        }


        public void CalculateBaseCost()
        {
			if (this.material == "Plastic")
				totalCost = plasticCost;
			else
				totalCost = metalCost;
        }

        public void CalculateTotalCost()
        {
			totalCost = baseCost;
        }


        public override string ToString()
        {
			return this.material + "        " + this.color + "         " + this.model;
        }
    }

}
