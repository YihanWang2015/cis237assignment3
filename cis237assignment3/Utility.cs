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
        protected decimal computerConnectionCost = 10m, armCost = 10m;

        public Utility()
        {

        }
        //six parameters constructor with three base parameters
        public Utility(string material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base(material, model, color)
        {
            this.toolbox = toolbox;
            this.computerConnection = computerConnection;
            this.arm = arm;
        }

        public bool Toolbox
        {
            get { return this.toolbox; }
            set { this.toolbox = value; }
        }

        public bool AomputerConnection
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

        }

        public decimal TotalCost();


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
