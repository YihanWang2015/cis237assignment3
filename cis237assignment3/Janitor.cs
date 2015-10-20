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
        public Janitor()
        {

        }

        //8 parameters with 6 base parameters
        public Janitor(string material, string model, string color,
                        bool toolbox, bool computerConnection, bool arm,
                        bool trashCompactor, bool vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            this.trashCompactor = trashCompactor;
            this.vacuum = vacuum;
        }
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

        public decimal TotalCost();



        public void CalculateTotalCost()
        {

        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}
