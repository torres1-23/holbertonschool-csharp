using System;

namespace Enemies
{
    /// <summary>Represents zombies enemies.</summary>
    public class Zombie
    {
        // Health of a zombie.
        private int health;
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class with health value passed as argument.</summary>
        /// <param name="value">Zombie health value.</param>
        /// <exception cref="ArgumentException"><paramref name="value"/> is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        /// <summary>Get the value of the heallth of a zombie.</summary>
        /// <returns>The value of health of a zombie.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
