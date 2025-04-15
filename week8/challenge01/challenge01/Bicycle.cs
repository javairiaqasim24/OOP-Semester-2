using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge01
{
    internal class Bicycle
    {
        private int candence;
        private int gear;
        private int speed;

        public Bicycle(int candence, int gear, int speed)
        {
            this.candence = candence;
            this.gear = gear;
            this.speed = speed;
        }

        public void setcandence(int candence)
        {
            this.candence = candence;
        }

        public void setgear(int gear)
        {
            this.gear = gear;
        }
        public void speedUP(int increment)
        {
            this.speed += increment;
        }
        public void applybreak(int decrement)
        {
            this.speed -= decrement;
        }

        public int getcandence()
        {
            return this.candence;
        }
        public int getgear()
        {
            return this.gear;
        }
        public int getSpeed() 
        {
            return this.speed;
        }

    }
}
