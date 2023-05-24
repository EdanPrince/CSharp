using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public abstract class GeometricObject
    {
        protected string color;
        protected double weight;
        protected GeometricObject() {
            color = "white";
            weight = 1.0;
        }
        protected GeometricObject(string color, double weight)
        {
            this.color = color;
            this.weight = weight;
        }
        public string PColor
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public double PWeight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public abstract double findArea();
        public abstract double findPerimeter();
    }
}
