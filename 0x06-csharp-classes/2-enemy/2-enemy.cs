using System;

namespace Enemies
{
    ///<summary>Represents zombies enemies.</summary>
    public class Zombie
    {
        ///<summary>Health of a zombie.</summary>
        public int health;
        ///<summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>Initializes a new instance of the <see cref="Zombie"/> class with health value passed as argument.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
    }
}
