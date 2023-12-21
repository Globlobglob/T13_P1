using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_P1
{
    class Avto
    {

        private string color;

        public string Color      
        {
            get { return color ; }
            set { color = value; }
        }
       
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed =( value<20||value>120)?0:value; }
        }
       
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Avto() { }
        public Avto(string color,int speed , string brand ) 
        {
            this.Brand = brand;
            this.Color = color;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return ($"Brand={Brand}\nColor={Color}\nSpeed={Speed}");
        }




    }
}
