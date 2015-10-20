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
        //Constructor with eight parameters with six base parameters
        public Astromech(string material, string model, string color,
                        bool toolbox, bool computerConnection, bool arm,
                        bool fireExtinquisher, int numberShips)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            this.fireExtinquisher = fireExtinquisher;
            this.numberShips = numberShips;

        }

        public Astromech()
        {

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

        }

        public decimal TotalCost();


        public override string ToString()
        {
            //return base.ToString();
        }

    }
}
