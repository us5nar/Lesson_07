using System;

namespace Lesson_07
{
    public class Wehicle : IComparable
    {
        int speed;
        string color;
        int power;
        bool isNew;
        bool isFree;
        public Wehicle()
        {
            speed = 100;
            color = "red";
            power = 1000;
            isNew = true;
            isFree = false;
        }
        public override string ToString()
        {
            return string.Format("wehicle: color {0}, speed {1}, power {2}", color, speed, power);
        }

        public int CompareTo(object obj)
        {
            if (obj is Wehicle)
            {
                Wehicle wechicleToCompare = (Wehicle)obj;
                //if (this.speed < wechicleToCompare.speed)
                //{
                //    return -1;
                //}
                //else if (this.speed > wechicleToCompare.speed)
                //{
                //    return 1;
                //}
                //else
                //{
                //    return 0;
                //}

                return this.speed.CompareTo(wechicleToCompare.speed);
            }
            else
            {
                //ERROR!!!!!!!!
                return 0;
            }
        }

        public Wehicle(string Color, int Speed):this()
    {
            color = Color;
            speed = Speed;
            isFree = true;
        }
        public Wehicle(string Color, int Speed, int Power) : this()
    {
            color = Color;
            speed = Speed;
            power = Power;
            isFree = true;
        }
        public Wehicle(string Color, int Speed, int Power, bool IsNew, bool IsFree)
        {
            speed = Speed;
            color = Color;
            power = Power;
            isNew = IsNew;
            isFree = IsFree;
        }
    }
}