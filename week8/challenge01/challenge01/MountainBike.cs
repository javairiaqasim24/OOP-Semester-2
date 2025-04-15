using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge01
{
    internal class MountainBike:Bicycle
    {
        private int SeatHeight;

        public MountainBike(int SeatHeight, int candence, int gear, int speed)
            :base(candence, gear, speed)
        { 
            this.SeatHeight=SeatHeight;
        }

        public void setSeatHeight(int SeatHeight)
        {
            this.SeatHeight = SeatHeight;
        }
        public int getSeatHeight()
        {
            return this.SeatHeight;
        }
        }
}
