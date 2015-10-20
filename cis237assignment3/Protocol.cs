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
        private string material, model, color;

        public Protocol()
        {

        }

        public Protocol(string material, string model, string color, int numberLanguages)
            : base(material, model, color)
        {
            //this.material = material;
            //this.model = model;
            //this.color = color;
            this.numberLanguages = numberLanguages;

        }

        public int NumberLanguages
        {
            get { return this.numberLanguages; }
            set { this.numberLanguages = value; }
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
