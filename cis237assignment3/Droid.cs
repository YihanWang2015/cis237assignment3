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

        //zero argument constructor 
        public Droid()
        {

        }

        //3 parameter constructors
        public Droid(string material, string model, string color)
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

        }

        public void CalculateTotalCost()
        {

        }


        public override string ToString()
        {
            return base.ToString();
        }
    }

}
