using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool IsCorrect = true;

        public int Gradus
        {
            get { return gradus; }
            set
            {
                if (value < 0)
                    IsCorrect = false;
                else
                    gradus = value;
            }
        }
        public int Min
        {
            get { return min; }
            set
            {
                if (value < 0)
                    IsCorrect = false;
                else
                    min = value;
            }
        }
        public int Sec
        {

            get { return sec; }
            set
            {
                if (value < 0)
                    IsCorrect = false;
                else
                    sec = value;
            }
        }
        public Angle(int gradus, int min, int sec) //Конструктор
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }
        public double ToRadians()
        {
            return ((gradus + min / 60 + sec/60/60) * Math.PI) / 180;
        }
    }
}
