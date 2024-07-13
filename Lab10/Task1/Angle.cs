using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Angle
    {
        private int gradus;
        private int min;
        private int sec;

        public int Gradus
        {
            get => gradus;
            set
            {
                gradus = value % 360;
            }
        }
        public int Min
        {
            get => min;
            set
            {
                if (value < 0)
                {
                    min = 0; 
                }
                else if (value > 59)
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
                else
                {
                    min = value;
                }
            }
        }
        public int Sec
        {
            get => sec;
            set
            {
                if (value < 0)
                {
                    sec = 0;
                }
                else if (value > 59)
                {
                    Min += value / 60;
                    sec = value % 60;
                }
                else
                {
                    sec = value;
                }
            }
        }

        public Angle()
        : this(0, 0, 0)
        { }

        public Angle(int gradus, int min = 0, int sec = 0)
        {
            Gradus = gradus; Min = min; Sec = sec;
        }

        public double ToRadians()
        {
            double gradus = (Min + Sec / 60.0) / 60.0;
            if (Gradus < 0)
            {
                gradus = -1 * gradus;
            }
            return (Gradus + gradus) * Math.PI / 180;
        }
    }
}
