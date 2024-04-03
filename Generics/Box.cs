using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Box :IEquatable<Box>
    {
       

        public double height {  get; set; }
        public double lenght {  get; set; }
        public double width {  get; set; }
        public double volym {  get; private set; }

        

        public Box(double height, double lenght, double width)
        {
           this.height = height;
           this.lenght = lenght;
           this.width = width;
            volym = Getvolym();
        }

        public bool Equals(Box other)
        {
           if(new BoxSameProp().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double Getvolym()
        {
            return height * lenght * width;
        }
        
    }

    

}
