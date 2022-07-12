using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// It represents a single six sided die that rolls 1-6
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Creates the die and rolls it to start with a 
        /// random number
        /// </summary>
        public Die()
        {
            Roll();
        }
        /// <summary>
        /// The current face up value of the die 
        /// </summary>
        public byte FaceValue { get; private set; }
        
        /// <summary>
        /// True if the die currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls the die and set the <see cref="FaceValue"/> 
        /// to the new number. If the die is not currently held.
        /// Returns the <see cref="FaceValue"/>
        /// </summary>
        /// <returns>Returns the <see cref="FaceValue"/></returns>>
        public byte Roll()
        {
            if (!IsHeld)
            {
                // Generate random number
                Random random = new();
                byte newValue = (byte)random.Next(1, 7);
                // Set to face up value
                FaceValue = newValue;
            }
            // Return new number
            return FaceValue;
        }

    }
}
