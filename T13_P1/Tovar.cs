using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_P1
{
    class Tovar
    {
        private int price;

        public int Price
        {
            get { return price; }
            set { price = (value<0||value>10)?0:value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int kvo;

        public int Kvo
        {
            get { return kvo; }
            set { kvo = (value<0||value>10)?0:value; }
        }

        public Tovar() { }
        public Tovar(string name,int kvo,int price) 
        {    this.Price = price;
             this.Name = name;
             this.Kvo = kvo;
        }


        public void Cena()
        {
            Console.WriteLine("стоимость заказанного товара={0}", (kvo * price));
        }


    }
}
