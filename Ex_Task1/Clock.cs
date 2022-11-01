﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    class Clock
    {
        int hour; //Поля //переменные
        int minute;
        int second;
        public bool isCorrect = true;

        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                    hour = value % 24;
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Hour += value / 60;
                    minute = value % 60;
                }
            }
        }
        public int Secind
        {
            get
            {
                return second;
            }
            set
            {
                if (value < 0)
                    isCorrect = false;
                else
                {
                    Minute += value / 60;
                    second = value % 60;
                }
            }
        }


        public Clock(int hour, int minute, int second) //конструктор
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public int ToSecond() //методы
        {
            return second + minute * 60 + hour * 60 * 60;
        }
    }
}
