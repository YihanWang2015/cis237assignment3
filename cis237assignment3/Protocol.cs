//Yihan Wang
//CIS237 Assignment 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int numberLanguages;
        private const decimal COSTPERLANGUAGE = 10.0m;


        public Protocol(string material, string color, string model, int numberLanguages)
            : base(material, color, model)
        {

            this.numberLanguages = numberLanguages;
			CalculateBaseCost ();
			CalculateTotalCost ();
        }

        public int NumberLanguages
        {
            get { return this.numberLanguages; }
            set { this.numberLanguages = value; }
        }


        public void CalculateTotalCost()
        {
			base.totalCost += this.numberLanguages * COSTPERLANGUAGE;
        }


        public override string ToString()
        {
			return base.ToString() + "       " + this.totalCost + "         " + " # of Languages: " + this.numberLanguages.ToString();
        }


    }
}
